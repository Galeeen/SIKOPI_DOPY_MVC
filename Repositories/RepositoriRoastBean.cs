using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriRoastBean : IRepositoriRoastBean
    {
        public DataTable AmbilSemua()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    rb.id_roasted,
                    rb.nama_produk,
                    br.kode_batch,
                    gb.asal_daerah,
                    rb.stok_gram,
                    rb.harga_per_gram,
                    rb.status_harga,
                    br.level_roasting,
                    COALESCE(rb.catatan, br.catatan, '') AS catatan
                FROM biji_kopi_roasted rb
                JOIN batch_roasting br
                    ON rb.id_batch = br.id_batch
                JOIN biji_kopi_mentah gb
                    ON br.id_biji_mentah = gb.id_biji_mentah
                WHERE rb.is_aktif = TRUE
                ORDER BY rb.id_roasted DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public RoastBean? AmbilById(int idRoasted)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    rb.id_roasted,
                    rb.id_batch,
                    rb.nama_produk,
                    rb.stok_gram,
                    rb.harga_per_gram,
                    rb.status_harga,
                    br.kode_batch,
                    br.level_roasting,
                    gb.asal_daerah,
                    COALESCE(rb.catatan, br.catatan, '') AS catatan
                FROM biji_kopi_roasted rb
                JOIN batch_roasting br
                    ON rb.id_batch = br.id_batch
                JOIN biji_kopi_mentah gb
                    ON br.id_biji_mentah = gb.id_biji_mentah
                WHERE rb.id_roasted = @id_roasted
                  AND rb.is_aktif = TRUE
                LIMIT 1;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_roasted", idRoasted);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new RoastBean
            {
                Id = Convert.ToInt32(reader["id_roasted"]),
                IdBatch = Convert.ToInt32(reader["id_batch"]),
                NamaProduk = reader["nama_produk"].ToString() ?? "",
                StokGram = Convert.ToDecimal(reader["stok_gram"]),
                HargaPerGram = Convert.ToDecimal(reader["harga_per_gram"]),
                StatusHarga = reader["status_harga"].ToString() ?? "",
                KodeBatch = reader["kode_batch"].ToString() ?? "",
                LevelRoasting = reader["level_roasting"].ToString() ?? "",
                AsalDaerah = reader["asal_daerah"].ToString() ?? "",
                Catatan = reader["catatan"].ToString() ?? ""
            };
        }

        public void UbahHarga(int idRoasted, decimal hargaPerGram)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                UPDATE biji_kopi_roasted
                SET
                    harga_per_gram = @harga_per_gram,
                    status_harga = 'SIAP_JUAL'
                WHERE id_roasted = @id_roasted
                  AND is_aktif = TRUE;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_roasted", idRoasted);
            cmd.Parameters.AddWithValue("@harga_per_gram", hargaPerGram);

            int jumlahBaris = cmd.ExecuteNonQuery();

            if (jumlahBaris == 0)
                throw new Exception("Data roast bean tidak ditemukan atau gagal diubah.");
        }
    }
}