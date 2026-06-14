using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

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
                    br.jumlah_biji_dipakai_kg,
                    br.hasil_roasting_gram,
                    br.level_roasting,
                    br.tanggal_batch
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
                    jumlah_biji_dipakai_kg,
                    hasil_roasting_gram,
                    level_roasting,
                    tanggal_batch
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
                JumlahBijiDipakaiKg = Convert.ToDecimal(reader["jumlah_biji_dipakai_kg"]),
                HasilRoastingGram = Convert.ToDecimal(reader["hasil_roasting_gram"]),
                LevelRoasting = reader["level_roasting"].ToString() ?? "",
                TanggalBatch = BacaDateTime(reader["tanggal_batch"])
            };
        }

        public void Tambah(BatchRoasting batch)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                decimal stokSekarang = AmbilStokGreenBean(conn, trx, batch.IdBijiMentah);

                if (stokSekarang < batch.JumlahBijiDipakaiKg)
                    throw new Exception("Stok green bean tidak mencukupi untuk batch roasting ini.");

                string sqlInsertBatch = @"
                    INSERT INTO batch_roasting
                    (
                        id_biji_mentah,
                        id_pengguna,
                        kode_batch,
                        jumlah_biji_dipakai_kg,
                        hasil_roasting_gram,
                        level_roasting,
                        tanggal_batch,
                        is_aktif
                    )
                    VALUES
                    (
                        @id_biji_mentah,
                        @id_pengguna,
                        @kode_batch,
                        @jumlah_biji_dipakai_kg,
                        @hasil_roasting_gram,
                        @level_roasting,
                        @tanggal_batch,
                        TRUE
                    )
                    RETURNING id_batch;
                ";

                using var cmdBatch = new NpgsqlCommand(sqlInsertBatch, conn, trx);
                cmdBatch.Parameters.AddWithValue("@id_biji_mentah", batch.IdBijiMentah);
                cmdBatch.Parameters.AddWithValue("@id_pengguna", batch.IdPengguna);
                cmdBatch.Parameters.AddWithValue("@kode_batch", batch.KodeBatch);
                cmdBatch.Parameters.AddWithValue("@jumlah_biji_dipakai_kg", batch.JumlahBijiDipakaiKg);
                cmdBatch.Parameters.AddWithValue("@hasil_roasting_gram", batch.HasilRoastingGram);
                cmdBatch.Parameters.AddWithValue("@level_roasting", batch.LevelRoasting);
                cmdBatch.Parameters.AddWithValue("@tanggal_batch", batch.TanggalBatch);

                int idBatchBaru = Convert.ToInt32(cmdBatch.ExecuteScalar());

                KurangiStokGreenBean(conn, trx, batch.IdBijiMentah, batch.JumlahBijiDipakaiKg);

                string namaProduk = BuatNamaProduk(conn, trx, batch.IdBijiMentah, batch.LevelRoasting, batch.KodeBatch);

                int idRoastedBaru = TambahProdukRoasted(
                    conn,
                    trx,
                    idBatchBaru,
                    namaProduk,
                    batch.HasilRoastingGram
                );

                TambahRiwayatGreenBean(
                    conn,
                    trx,
                    batch.IdBijiMentah,
                    "KELUAR",
                    batch.JumlahBijiDipakaiKg,
                    $"Batch roasting: {batch.KodeBatch}"
                );

                TambahRiwayatRoasted(
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
            BatchRoasting? dataLamaNullable = AmbilById(batch.Id);

            if (dataLamaNullable is null)
                throw new Exception("Data batch roasting tidak ditemukan.");

            BatchRoasting dataLama = dataLamaNullable;

            if (dataLama.IdBijiMentah != batch.IdBijiMentah)
                throw new Exception("Green bean tidak boleh diganti saat edit batch. Hapus batch lalu buat batch baru jika salah green bean.");

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                decimal selisihPemakaian = batch.JumlahBijiDipakaiKg - dataLama.JumlahBijiDipakaiKg;

                if (selisihPemakaian > 0)
                {
                    decimal stokSekarang = AmbilStokGreenBean(conn, trx, batch.IdBijiMentah);

                    if (stokSekarang < selisihPemakaian)
                        throw new Exception("Stok green bean tidak mencukupi untuk perubahan jumlah batch.");
                }

                string sqlUpdateBatch = @"
                    UPDATE batch_roasting
                    SET
                        kode_batch = @kode_batch,
                        jumlah_biji_dipakai_kg = @jumlah_biji_dipakai_kg,
                        hasil_roasting_gram = @hasil_roasting_gram,
                        level_roasting = @level_roasting,
                        tanggal_batch = @tanggal_batch
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdBatch = new NpgsqlCommand(sqlUpdateBatch, conn, trx);
                cmdBatch.Parameters.AddWithValue("@id_batch", batch.Id);
                cmdBatch.Parameters.AddWithValue("@kode_batch", batch.KodeBatch);
                cmdBatch.Parameters.AddWithValue("@jumlah_biji_dipakai_kg", batch.JumlahBijiDipakaiKg);
                cmdBatch.Parameters.AddWithValue("@hasil_roasting_gram", batch.HasilRoastingGram);
                cmdBatch.Parameters.AddWithValue("@level_roasting", batch.LevelRoasting);
                cmdBatch.Parameters.AddWithValue("@tanggal_batch", batch.TanggalBatch);

                int jumlahBaris = cmdBatch.ExecuteNonQuery();

                if (jumlahBaris == 0)
                    throw new Exception("Data batch roasting gagal diubah.");

                if (selisihPemakaian > 0)
                {
                    KurangiStokGreenBean(conn, trx, batch.IdBijiMentah, selisihPemakaian);
                }
                else if (selisihPemakaian < 0)
                {
                    TambahStokGreenBean(conn, trx, batch.IdBijiMentah, Math.Abs(selisihPemakaian));
                }

                string namaProduk = BuatNamaProduk(conn, trx, batch.IdBijiMentah, batch.LevelRoasting, batch.KodeBatch);

                string sqlUpdateRoasted = @"
                    UPDATE biji_kopi_roasted
                    SET
                        nama_produk = @nama_produk,
                        stok_gram = @stok_gram
                    WHERE id_batch = @id_batch
                      AND is_aktif = TRUE;
                ";

                using var cmdRoasted = new NpgsqlCommand(sqlUpdateRoasted, conn, trx);
                cmdRoasted.Parameters.AddWithValue("@id_batch", batch.Id);
                cmdRoasted.Parameters.AddWithValue("@nama_produk", namaProduk);
                cmdRoasted.Parameters.AddWithValue("@stok_gram", batch.HasilRoastingGram);
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
            BatchRoasting? dataLamaNullable = AmbilById(idBatch);

            if (dataLamaNullable is null)
                throw new Exception("Data batch roasting tidak ditemukan.");

            BatchRoasting dataLama = dataLamaNullable;

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
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

                TambahStokGreenBean(conn, trx, dataLama.IdBijiMentah, dataLama.JumlahBijiDipakaiKg);

                TambahRiwayatGreenBean(
                    conn,
                    trx,
                    dataLama.IdBijiMentah,
                    "MASUK",
                    dataLama.JumlahBijiDipakaiKg,
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

        private decimal AmbilStokGreenBean(NpgsqlConnection conn, NpgsqlTransaction trx, int idBijiMentah)
        {
            string sql = @"
                SELECT stok_kg
                FROM biji_kopi_mentah
                WHERE id_biji_mentah = @id_biji_mentah
                  AND is_aktif = TRUE;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);

            object? hasil = cmd.ExecuteScalar();

            if (hasil == null || hasil == DBNull.Value)
                throw new Exception("Data green bean tidak ditemukan.");

            return Convert.ToDecimal(hasil);
        }

        private void KurangiStokGreenBean(NpgsqlConnection conn, NpgsqlTransaction trx, int idBijiMentah, decimal jumlah)
        {
            string sql = @"
                UPDATE biji_kopi_mentah
                SET stok_kg = stok_kg - @jumlah
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.ExecuteNonQuery();
        }

        private void TambahStokGreenBean(NpgsqlConnection conn, NpgsqlTransaction trx, int idBijiMentah, decimal jumlah)
        {
            string sql = @"
                UPDATE biji_kopi_mentah
                SET stok_kg = stok_kg + @jumlah
                WHERE id_biji_mentah = @id_biji_mentah;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.ExecuteNonQuery();
        }

        private int TambahProdukRoasted(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBatch,
            string namaProduk,
            decimal stokGram)
        {
            string sql = @"
                INSERT INTO biji_kopi_roasted
                (
                    id_batch,
                    nama_produk,
                    stok_gram,
                    harga_per_gram,
                    status_harga,
                    is_aktif
                )
                VALUES
                (
                    @id_batch,
                    @nama_produk,
                    @stok_gram,
                    0,
                    'MENUNGGU_HARGA',
                    TRUE
                )
                RETURNING id_roasted;
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_batch", idBatch);
            cmd.Parameters.AddWithValue("@nama_produk", namaProduk);
            cmd.Parameters.AddWithValue("@stok_gram", stokGram);

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

        private void TambahRiwayatGreenBean(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            string arah,
            decimal jumlah,
            string referensi)
        {
            string sql = @"
                INSERT INTO riwayat_stok
                (
                    id_biji_mentah,
                    kategori,
                    arah,
                    jumlah,
                    satuan,
                    referensi
                )
                VALUES
                (
                    @id_biji_mentah,
                    'GREEN_BEAN',
                    @arah,
                    @jumlah,
                    'KG',
                    @referensi
                );
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmd.Parameters.AddWithValue("@arah", arah);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.Parameters.AddWithValue("@referensi", referensi);
            cmd.ExecuteNonQuery();
        }

        private void TambahRiwayatRoasted(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idRoasted,
            string arah,
            decimal jumlah,
            string referensi)
        {
            string sql = @"
                INSERT INTO riwayat_stok
                (
                    id_roasted,
                    kategori,
                    arah,
                    jumlah,
                    satuan,
                    referensi
                )
                VALUES
                (
                    @id_roasted,
                    'ROASTED_BEAN',
                    @arah,
                    @jumlah,
                    'GRAM',
                    @referensi
                );
            ";

            using var cmd = new NpgsqlCommand(sql, conn, trx);
            cmd.Parameters.AddWithValue("@id_roasted", idRoasted);
            cmd.Parameters.AddWithValue("@arah", arah);
            cmd.Parameters.AddWithValue("@jumlah", jumlah);
            cmd.Parameters.AddWithValue("@referensi", referensi);
            cmd.ExecuteNonQuery();
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