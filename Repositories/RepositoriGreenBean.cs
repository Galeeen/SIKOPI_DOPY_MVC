using Microsoft.VisualBasic.Devices;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriGreenBean : IRepositoriGreenBean
    {
        public DataTable AmbilSemua()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    gb.id_biji_mentah,
                    gb.nama_biji,
                    gb.asal_daerah,
                    jb.nama AS jenis,
                    gb.ketinggian_mdpl,
                    mp.nama AS metode_proses,
                    gb.tingkat_kualitas,
                    gb.stok_kg,
                    gb.harga_per_kg,
                    gb.tanggal_panen
                FROM biji_kopi_mentah gb
                JOIN jenis_biji_kopi_mentah jb
                    ON gb.id_jenis_biji_kopi_mentah = jb.id_jenis_biji_kopi_mentah
                JOIN metode_proses mp
                    ON gb.id_metode_proses = mp.id_metode_proses
                WHERE gb.is_aktif = TRUE
                ORDER BY gb.id_biji_mentah DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public GreenBean? AmbilById(int idBijiMentah)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    id_biji_mentah,
                    id_jenis_biji_kopi_mentah,
                    id_metode_proses,
                    nama_biji,
                    asal_daerah,
                    ketinggian_mdpl,
                    tingkat_kualitas,
                    stok_kg,
                    harga_per_kg,
                    tanggal_panen
                FROM biji_kopi_mentah
                WHERE id_biji_mentah = @id_biji_mentah
                  AND is_aktif = TRUE
                LIMIT 1;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new GreenBean
            {
                Id = Convert.ToInt32(reader["id_biji_mentah"]),
                IdJenisBijiKopiMentah = Convert.ToInt32(reader["id_jenis_biji_kopi_mentah"]),
                IdMetodeProses = Convert.ToInt32(reader["id_metode_proses"]),
                NamaBiji = reader["nama_biji"].ToString() ?? "",
                AsalDaerah = reader["asal_daerah"].ToString() ?? "",
                KetinggianMdpl = reader["ketinggian_mdpl"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(reader["ketinggian_mdpl"]),
                TingkatKualitas = reader["tingkat_kualitas"].ToString() ?? "",
                StokKg = Convert.ToDecimal(reader["stok_kg"]),
                HargaPerKg = Convert.ToDecimal(reader["harga_per_kg"]),
                TanggalPanen = BacaTanggalPanen(reader["tanggal_panen"])
            };
        }

        public void Tambah(GreenBean greenBean)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                string sqlInsertGreenBean = @"
                    INSERT INTO biji_kopi_mentah
                    (
                        id_jenis_biji_kopi_mentah,
                        id_metode_proses,
                        nama_biji,
                        asal_daerah,
                        ketinggian_mdpl,
                        tingkat_kualitas,
                        stok_kg,
                        harga_per_kg,
                        tanggal_panen,
                        is_aktif
                    )
                    VALUES
                    (
                        @id_jenis_biji_kopi_mentah,
                        @id_metode_proses,
                        @nama_biji,
                        @asal_daerah,
                        @ketinggian_mdpl,
                        @tingkat_kualitas,
                        @stok_kg,
                        @harga_per_kg,
                        @tanggal_panen,
                        TRUE
                    )
                    RETURNING id_biji_mentah;
                ";

                using var cmd = new NpgsqlCommand(sqlInsertGreenBean, conn, trx);
                cmd.Parameters.AddWithValue("@id_jenis_biji_kopi_mentah", greenBean.IdJenisBijiKopiMentah);
                cmd.Parameters.AddWithValue("@id_metode_proses", greenBean.IdMetodeProses);
                cmd.Parameters.AddWithValue("@nama_biji", greenBean.NamaBiji);
                cmd.Parameters.AddWithValue("@asal_daerah", greenBean.AsalDaerah);
                cmd.Parameters.AddWithValue("@ketinggian_mdpl", greenBean.KetinggianMdpl);
                cmd.Parameters.AddWithValue("@tingkat_kualitas", greenBean.TingkatKualitas);
                cmd.Parameters.AddWithValue("@stok_kg", greenBean.StokKg);
                cmd.Parameters.AddWithValue("@harga_per_kg", greenBean.HargaPerKg);
                cmd.Parameters.AddWithValue(
                    "@tanggal_panen",
                    greenBean.TanggalPanen.HasValue
                        ? DateOnly.FromDateTime(greenBean.TanggalPanen.Value)
                        : DBNull.Value
                );

                int idBijiMentahBaru = Convert.ToInt32(cmd.ExecuteScalar());

                TambahRiwayatStok(
                    conn,
                    trx,
                    idBijiMentahBaru,
                    "MASUK",
                    greenBean.StokKg,
                    $"Tambah Green Bean: {greenBean.NamaBiji}"
                );

                trx.Commit();
            }
            catch
            {
                trx.Rollback();
                throw;
            }
        }

        public void Ubah(GreenBean greenBean)
        {
            GreenBean? dataLama = AmbilById(greenBean.Id);

            if (dataLama == null)
                throw new Exception("Data green bean tidak ditemukan.");

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            using var trx = conn.BeginTransaction();

            try
            {
                string sqlUpdate = @"
                    UPDATE biji_kopi_mentah
                    SET
                        id_jenis_biji_kopi_mentah = @id_jenis_biji_kopi_mentah,
                        id_metode_proses = @id_metode_proses,
                        nama_biji = @nama_biji,
                        asal_daerah = @asal_daerah,
                        ketinggian_mdpl = @ketinggian_mdpl,
                        tingkat_kualitas = @tingkat_kualitas,
                        stok_kg = @stok_kg,
                        harga_per_kg = @harga_per_kg,
                        tanggal_panen = @tanggal_panen
                    WHERE id_biji_mentah = @id_biji_mentah
                      AND is_aktif = TRUE;
                ";

                using var cmd = new NpgsqlCommand(sqlUpdate, conn, trx);
                cmd.Parameters.AddWithValue("@id_biji_mentah", greenBean.Id);
                cmd.Parameters.AddWithValue("@id_jenis_biji_kopi_mentah", greenBean.IdJenisBijiKopiMentah);
                cmd.Parameters.AddWithValue("@id_metode_proses", greenBean.IdMetodeProses);
                cmd.Parameters.AddWithValue("@nama_biji", greenBean.NamaBiji);
                cmd.Parameters.AddWithValue("@asal_daerah", greenBean.AsalDaerah);
                cmd.Parameters.AddWithValue("@ketinggian_mdpl", greenBean.KetinggianMdpl);
                cmd.Parameters.AddWithValue("@tingkat_kualitas", greenBean.TingkatKualitas);
                cmd.Parameters.AddWithValue("@stok_kg", greenBean.StokKg);
                cmd.Parameters.AddWithValue("@harga_per_kg", greenBean.HargaPerKg);
                cmd.Parameters.AddWithValue(
                    "@tanggal_panen",
                    greenBean.TanggalPanen.HasValue
                        ? DateOnly.FromDateTime(greenBean.TanggalPanen.Value)
                        : DBNull.Value
                );

                cmd.ExecuteNonQuery();

                decimal selisihStok = greenBean.StokKg - dataLama.StokKg;

                if (selisihStok != 0)
                {
                    string arah = selisihStok > 0 ? "MASUK" : "KELUAR";
                    decimal jumlah = Math.Abs(selisihStok);

                    TambahRiwayatStok(
                        conn,
                        trx,
                        greenBean.Id,
                        arah,
                        jumlah,
                        $"Update stok Green Bean: {greenBean.NamaBiji}"
                    );
                }

                trx.Commit();
            }
            catch
            {
                trx.Rollback();
                throw;
            }
        }

        public void Hapus(int idBijiMentah)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
        UPDATE biji_kopi_mentah
        SET is_aktif = FALSE
        WHERE id_biji_mentah = @id_biji_mentah
          AND is_aktif = TRUE;
    ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);

            int jumlahBaris = cmd.ExecuteNonQuery();

            if (jumlahBaris == 0)
                throw new Exception("Data green bean tidak ditemukan atau sudah dihapus.");
        }

        private void TambahRiwayatStok(
            NpgsqlConnection conn,
            NpgsqlTransaction trx,
            int idBijiMentah,
            string arah,
            decimal jumlah,
            string referensi)
        {
            string sqlRiwayat = @"
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

            using var cmdRiwayat = new NpgsqlCommand(sqlRiwayat, conn, trx);
            cmdRiwayat.Parameters.AddWithValue("@id_biji_mentah", idBijiMentah);
            cmdRiwayat.Parameters.AddWithValue("@arah", arah);
            cmdRiwayat.Parameters.AddWithValue("@jumlah", jumlah);
            cmdRiwayat.Parameters.AddWithValue("@referensi", referensi);
            cmdRiwayat.ExecuteNonQuery();
        }
        private DateTime? BacaTanggalPanen(object nilai)
        {
            if (nilai == DBNull.Value)
                return null;

            if (nilai is DateTime dateTime)
                return dateTime;

            if (nilai is DateOnly dateOnly)
                return dateOnly.ToDateTime(TimeOnly.MinValue);

            return Convert.ToDateTime(nilai);
        }
    }
}