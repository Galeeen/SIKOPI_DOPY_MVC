using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;
using System;
using System.Data;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriBatchRoasting : IRepositoriBatchRoasting
    {
        public DataTable AmbilSemua()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    br.id_batch,
                    br.kode_batch,
                    gb.nama_biji AS green_bean,
                    br.jumlah_biji_dipakai_gram,
                    br.hasil_roasting_gram,
                    br.level_roasting,
                    br.tanggal_batch,
                    COALESCE(br.catatan, '') AS catatan
                FROM batch_roasting br
                JOIN biji_kopi_mentah gb
                    ON br.id_biji_mentah = gb.id_biji_mentah
                WHERE br.is_aktif = TRUE
                ORDER BY br.id_batch DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public BatchRoasting? AmbilById(int idBatch)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    id_batch,
                    id_biji_mentah,
                    id_pengguna,
                    kode_batch,
                    jumlah_biji_dipakai_gram,
                    hasil_roasting_gram,
                    level_roasting,
                    tanggal_batch,
                    COALESCE(catatan, '') AS catatan
                FROM batch_roasting
                WHERE id_batch = @id_batch
                  AND is_aktif = TRUE
                LIMIT 1;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_batch", idBatch);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new BatchRoasting
            {
                Id = Convert.ToInt32(reader["id_batch"]),
                IdBijiMentah = Convert.ToInt32(reader["id_biji_mentah"]),
                IdPengguna = Convert.ToInt32(reader["id_pengguna"]),
                KodeBatch = reader["kode_batch"].ToString() ?? "",
                JumlahBijiDipakaiGram = Convert.ToDecimal(reader["jumlah_biji_dipakai_gram"]),
                HasilRoastingGram = Convert.ToDecimal(reader["hasil_roasting_gram"]),
                LevelRoasting = reader["level_roasting"].ToString() ?? "",
                TanggalBatch = BacaDateTime(reader["tanggal_batch"]),
                Catatan = reader["catatan"].ToString() ?? ""
            };
        }

        public void Tambah(BatchRoasting batch)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                batch.LevelRoasting = NormalisasiLevelRoasting(batch.LevelRoasting);

                decimal stokGreenBeanGram = AmbilStokGreenBeanGram(conn, trx, batch.IdBijiMentah);

                if (batch.JumlahBijiDipakaiGram > stokGreenBeanGram)
                {
                    throw new Exception(
                        "Jumlah biji masuk melebihi stok green bean. " +
                        $"Stok tersedia: {stokGreenBeanGram:N0} gram."
                    );
                }

                if (batch.HasilRoastingGram >= batch.JumlahBijiDipakaiGram)
                {
                    throw new Exception(
                        "Hasil roasting tidak boleh sama atau lebih besar dari jumlah biji masuk. " +
                        "Pada proses penyangraian, hasil roast bean harus lebih kecil karena terjadi penyusutan."
                    );
                }

                string sqlInsertBatch = @"
                    INSERT INTO batch_roasting
                    (
                        id_biji_mentah,
                        id_pengguna,
                        kode_batch,
                        jumlah_biji_dipakai_gram,
                        hasil_roasting_gram,
                        level_roasting,
                        tanggal_batch,
                        catatan,
                        is_aktif
                    )
                    VALUES
                    (
                        @id_biji_mentah,
                        @id_pengguna,
                        @kode_batch,
                        @jumlah_biji_dipakai_gram,
                        @hasil_roasting_gram,
                        @level_roasting,
                        @tanggal_batch,
                        @catatan,
                        TRUE
                    )
                    RETURNING id_batch;
                ";

                using var cmdBatch = new NpgsqlCommand(sqlInsertBatch, conn, trx);
                cmdBatch.Parameters.AddWithValue("@id_biji_mentah", batch.IdBijiMentah);
                cmdBatch.Parameters.AddWithValue("@id_pengguna", batch.IdPengguna);
                cmdBatch.Parameters.AddWithValue("@kode_batch", batch.KodeBatch);
                cmdBatch.Parameters.AddWithValue("@jumlah_biji_dipakai_gram", batch.JumlahBijiDipakaiGram);
                cmdBatch.Parameters.AddWithValue("@hasil_roasting_gram", batch.HasilRoastingGram);
                cmdBatch.Parameters.AddWithValue("@level_roasting", batch.LevelRoasting);
                cmdBatch.Parameters.AddWithValue("@tanggal_batch", batch.TanggalBatch);
                cmdBatch.Parameters.AddWithValue("@catatan", batch.Catatan ?? "");

                int idBatchBaru = Convert.ToInt32(cmdBatch.ExecuteScalar());

                KurangiStokGreenBeanGram(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    batch.JumlahBijiDipakaiGram
                );

                string namaProduk = BuatNamaProduk(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    batch.LevelRoasting,
                    batch.KodeBatch
                );

                int idRoastedBaru = TambahProdukRoasted(
                    conn,
                    trx,
                    idBatchBaru,
                    namaProduk,
                    batch.HasilRoastingGram,
                    batch.Catatan ?? ""
                );

                TambahRiwayatGreenBeanKg(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    "KELUAR",
                    batch.JumlahBijiDipakaiGram / 1000,
                    $"Batch roasting: {batch.KodeBatch}"
                );

                TambahRiwayatRoastedGram(
                    conn,
                    trx,
                    idRoastedBaru,
                    "MASUK",
                    batch.HasilRoastingGram,
                    $"Hasil batch roasting: {batch.KodeBatch}"
                );

                trx.Commit();
            }
            catch
            {
                trx.Rollback();
                throw;
            }
        }

        public void Ubah(BatchRoasting batch)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                batch.LevelRoasting = NormalisasiLevelRoasting(batch.LevelRoasting);

                BatchRoasting dataLama = AmbilBatchDalamTransaksi(conn, trx, batch.Id);

                if (dataLama.IdBijiMentah != batch.IdBijiMentah)
                    throw new Exception("Green bean tidak boleh diganti saat edit batch.");

                decimal stokGreenBeanGram = AmbilStokGreenBeanGram(conn, trx, batch.IdBijiMentah);

                decimal stokTersediaUntukEditGram =
                    stokGreenBeanGram + dataLama.JumlahBijiDipakaiGram;

                if (batch.JumlahBijiDipakaiGram > stokTersediaUntukEditGram)
                {
                    throw new Exception(
                        "Jumlah biji masuk melebihi stok green bean. " +
                        $"Stok tersedia untuk edit: {stokTersediaUntukEditGram:N0} gram."
                    );
                }

                if (batch.HasilRoastingGram >= batch.JumlahBijiDipakaiGram)
                {
                    throw new Exception(
                        "Hasil roasting tidak boleh sama atau lebih besar dari jumlah biji masuk. " +
                        "Pada proses penyangraian, hasil roast bean harus lebih kecil karena terjadi penyusutan."
                    );
                }

                string sqlUpdateBatch = @"
                    UPDATE batch_roasting
                    SET
                        kode_batch = @kode_batch,
                        jumlah_biji_dipakai_gram = @jumlah_biji_dipakai_gram,
                        hasil_roasting_gram = @hasil_roasting_gram,
                        level_roasting = @level_roasting,
                        tanggal_batch = @tanggal_batch,
                        catatan = @catatan
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdBatch = new NpgsqlCommand(sqlUpdateBatch, conn, trx);
                cmdBatch.Parameters.AddWithValue("@id_batch", batch.Id);
                cmdBatch.Parameters.AddWithValue("@kode_batch", batch.KodeBatch);
                cmdBatch.Parameters.AddWithValue("@jumlah_biji_dipakai_gram", batch.JumlahBijiDipakaiGram);
                cmdBatch.Parameters.AddWithValue("@hasil_roasting_gram", batch.HasilRoastingGram);
                cmdBatch.Parameters.AddWithValue("@level_roasting", batch.LevelRoasting);
                cmdBatch.Parameters.AddWithValue("@tanggal_batch", batch.TanggalBatch);
                cmdBatch.Parameters.AddWithValue("@catatan", batch.Catatan ?? "");

                int jumlahBaris = cmdBatch.ExecuteNonQuery();

                if (jumlahBaris == 0)
                    throw new Exception("Data batch roasting gagal diubah.");

                UpdateStokGreenBeanSaatEditGram(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    dataLama.JumlahBijiDipakaiGram,
                    batch.JumlahBijiDipakaiGram
                );

                string namaProduk = BuatNamaProduk(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    batch.LevelRoasting,
                    batch.KodeBatch
                );

                string sqlUpdateRoasted = @"
                    UPDATE biji_kopi_roasted
                    SET
                        nama_produk = @nama_produk,
                        stok_gram = @stok_gram,
                        catatan = @catatan
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdRoasted = new NpgsqlCommand(sqlUpdateRoasted, conn, trx);
                cmdRoasted.Parameters.AddWithValue("@id_batch", batch.Id);
                cmdRoasted.Parameters.AddWithValue("@nama_produk", namaProduk);
                cmdRoasted.Parameters.AddWithValue("@stok_gram", batch.HasilRoastingGram);
                cmdRoasted.Parameters.AddWithValue("@catatan", batch.Catatan ?? "");
                cmdRoasted.ExecuteNonQuery();

                trx.Commit();
            }
            catch
            {
                trx.Rollback();
                throw;
            }
        }

        public void Hapus(int idBatch)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                BatchRoasting dataLama = AmbilBatchDalamTransaksi(conn, trx, idBatch);

                string sqlHapusBatch = @"
                    UPDATE batch_roasting
                    SET is_aktif = FALSE
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdBatch = new NpgsqlCommand(sqlHapusBatch, conn, trx);
                cmdBatch.Parameters.AddWithValue("@id_batch", idBatch);

                int jumlahBaris = cmdBatch.ExecuteNonQuery();

                if (jumlahBaris == 0)
                    throw new Exception("Data batch roasting gagal dihapus.");

                string sqlHapusRoasted = @"
                    UPDATE biji_kopi_roasted
                    SET is_aktif = FALSE
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdRoasted = new NpgsqlCommand(sqlHapusRoasted, conn, trx);
                cmdRoasted.Parameters.AddWithValue("@id_batch", idBatch);
                cmdRoasted.ExecuteNonQuery();

                TambahStokGreenBeanGram(
                    conn,
                    trx,
                    dataLama.IdBijiMentah,
                    dataLama.JumlahBijiDipakaiGram
                );

                TambahRiwayatGreenBeanKg(
                    conn,
                    trx,
                    dataLama.IdBijiMentah,
                    "MASUK",
                    dataLama.JumlahBijiDipakaiGram / 1000,
                    $"Hapus batch roasting: {dataLama.KodeBatch}"
                );

                trx.Commit();
            }
            catch
            {
                trx.Rollback();
                throw;
            }
        }

        private BatchRoasting AmbilBatchDalamTransaksi(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBatch)
        {
            string sql = @"
                SELECT
                    id_batch,
                    id_biji_mentah,
                    id_pengguna,
                    kode_batch,
                    jumlah_biji_dipakai_gram,
                    hasil_roasting_gram,
                    level_roasting,
                    tanggal_batch,
                    COALESCE(catatan, '') AS catatan
                FROM batch_roasting
                WHERE id_batch = @id_batch
                  AND is_aktif = TRUE
                FOR UPDATE;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_batch", idBatch);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                throw new Exception("Data batch roasting tidak ditemukan.");

            return new BatchRoasting
            {
                Id = Convert.ToInt32(reader["id_batch"]),
                IdBijiMentah = Convert.ToInt32(reader["id_biji_mentah"]),
                IdPengguna = Convert.ToInt32(reader["id_pengguna"]),
                KodeBatch = reader["kode_batch"].ToString() ?? "",
                JumlahBijiDipakaiGram = Convert.ToDecimal(reader["jumlah_biji_dipakai_gram"]),
                HasilRoastingGram = Convert.ToDecimal(reader["hasil_roasting_gram"]),
                LevelRoasting = reader["level_roasting"].ToString() ?? "",
                TanggalBatch = BacaDateTime(reader["tanggal_batch"]),
                Catatan = reader["catatan"].ToString() ?? ""
            };
        }

        private decimal AmbilStokGreenBeanGram(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah)
        {
            string sql = @"
                SELECT stok_kg
                FROM biji_kopi_mentah
                WHERE id_biji_mentah = @id_biji_mentah
                  AND is_aktif = TRUE
                FOR UPDATE;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);

            object? hasil = cmd.ExecuteScalar();

            if (hasil == null || hasil == DBNull.Value)
                throw new Exception("Data green bean tidak ditemukan.");

            decimal stokKg = Convert.ToDecimal(hasil);
            return stokKg * 1000;
        }

        private void KurangiStokGreenBeanGram(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            decimal jumlahGram)
        {
            string sql = @"
                UPDATE biji_kopi_mentah
                SET stok_kg = stok_kg - (@jumlah_gram / 1000.0)
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@jumlah_gram", jumlahGram);
            cmd.ExecuteNonQuery();
        }

        private void TambahStokGreenBeanGram(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            decimal jumlahGram)
        {
            string sql = @"
                UPDATE biji_kopi_mentah
                SET stok_kg = stok_kg + (@jumlah_gram / 1000.0)
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@jumlah_gram", jumlahGram);
            cmd.ExecuteNonQuery();
        }

        private void UpdateStokGreenBeanSaatEditGram(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            decimal jumlahLamaGram,
            decimal jumlahBaruGram)
        {
            string sql = @"
                UPDATE biji_kopi_mentah
                SET stok_kg = stok_kg
                    + (@jumlah_lama_gram / 1000.0)
                    - (@jumlah_baru_gram / 1000.0)
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@jumlah_lama_gram", jumlahLamaGram);
            cmd.Parameters.AddWithValue("@jumlah_baru_gram", jumlahBaruGram);
            cmd.ExecuteNonQuery();
        }

        private int TambahProdukRoasted(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBatch,
            string namaProduk,
            decimal stokGram,
            string catatan)
        {
            string sql = @"
                INSERT INTO biji_kopi_roasted
                (
                    id_batch,
                    nama_produk,
                    stok_gram,
                    harga_per_gram,
                    status_harga,
                    catatan,
                    is_aktif
                )
                VALUES
                (
                    @id_batch,
                    @nama_produk,
                    @stok_gram,
                    0,
                    'MENUNGGU_HARGA',
                    @catatan,
                    TRUE
                )
                RETURNING id_roasted;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_batch", idBatch);
            cmd.Parameters.AddWithValue("@nama_produk", namaProduk);
            cmd.Parameters.AddWithValue("@stok_gram", stokGram);
            cmd.Parameters.AddWithValue("@catatan", catatan ?? "");

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private string BuatNamaProduk(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            string levelRoasting,
            string kodeBatch)
        {
            string sql = @"
                SELECT nama_biji
                FROM biji_kopi_mentah
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);

            string namaBiji = cmd.ExecuteScalar()?.ToString() ?? "Roasted Bean";

            return $"{namaBiji} - {levelRoasting} - {kodeBatch}";
        }

        private void TambahRiwayatGreenBeanKg(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            string arah,
            decimal jumlahKg,
            string referensi)
        {
            string sql = @"
                INSERT INTO riwayat_stok
                (
                    id_biji_mentah,
                    id_roasted,
                    kategori,
                    arah,
                    jumlah,
                    satuan,
                    referensi,
                    tanggal_riwayat
                )
                VALUES
                (
                    @id_biji_mentah,
                    NULL,
                    'GREEN_BEAN',
                    @arah,
                    @jumlah,
                    'kg',
                    @referensi,
                    NOW()
                );
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@arah", arah);
            cmd.Parameters.AddWithValue("@jumlah", jumlahKg);
            cmd.Parameters.AddWithValue("@referensi", referensi);
            cmd.ExecuteNonQuery();
        }

        private void TambahRiwayatRoastedGram(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idRoasted,
            string arah,
            decimal jumlahGram,
            string referensi)
        {
            string sql = @"
                INSERT INTO riwayat_stok
                (
                    id_biji_mentah,
                    id_roasted,
                    kategori,
                    arah,
                    jumlah,
                    satuan,
                    referensi,
                    tanggal_riwayat
                )
                VALUES
                (
                    NULL,
                    @id_roasted,
                    'ROASTED_BEAN',
                    @arah,
                    @jumlah,
                    'gram',
                    @referensi,
                    NOW()
                );
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_roasted", idRoasted);
            cmd.Parameters.AddWithValue("@arah", arah);
            cmd.Parameters.AddWithValue("@jumlah", jumlahGram);
            cmd.Parameters.AddWithValue("@referensi", referensi);
            cmd.ExecuteNonQuery();
        }

        private string NormalisasiLevelRoasting(string levelRoasting)
        {
            string nilai = levelRoasting.Trim();

            if (nilai == "Light Roast")
                return "Light";

            if (nilai == "Medium Roast")
                return "Medium";

            if (nilai == "Medium-Dark")
                return "Medium Dark";

            if (nilai == "Medium Dark Roast")
                return "Medium Dark";

            if (nilai == "Dark Roast")
                return "Dark";

            return nilai;
        }

        private DateTime BacaDateTime(object nilai)
        {
            if (nilai == DBNull.Value)
                return DateTime.Now;

            if (nilai is DateTime dateTime)
                return dateTime;

            if (nilai is DateOnly dateOnly)
                return dateOnly.ToDateTime(TimeOnly.MinValue);

            return Convert.ToDateTime(nilai);
        }
    }
}