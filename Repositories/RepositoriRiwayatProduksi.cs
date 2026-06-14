using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriRiwayatProduksi : IRepositoriRiwayatProduksi
    {
        public RingkasanRiwayatProduksi AmbilRingkasan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            var ringkasan = new RingkasanRiwayatProduksi();

            string sqlRiwayat = @"
                SELECT
                    COALESCE(SUM(
                        CASE 
                            WHEN kategori = 'GREEN_BEAN' AND arah = 'KELUAR' 
                            THEN jumlah 
                            ELSE 0 
                        END
                    ), 0) AS green_bean_keluar,

                    COALESCE(SUM(
                        CASE 
                            WHEN kategori = 'ROASTED_BEAN' AND arah = 'MASUK' 
                            THEN jumlah 
                            ELSE 0 
                        END
                    ), 0) AS roast_bean_masuk,

                    COUNT(*) AS total_aktivitas
                FROM riwayat_stok
                WHERE COALESCE(referensi, '') NOT LIKE 'CATAT-%';
            ";

            using (var cmd = new NpgsqlCommand(sqlRiwayat, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ringkasan.GreenBeanKeluarKg = Convert.ToDecimal(reader["green_bean_keluar"]);
                    ringkasan.RoastBeanMasukGram = Convert.ToDecimal(reader["roast_bean_masuk"]);
                    ringkasan.TotalAktivitas = Convert.ToInt32(reader["total_aktivitas"]);
                }
            }

            string sqlBatch = @"
                SELECT COUNT(*) 
                FROM batch_roasting
                WHERE is_aktif = TRUE;
            ";

            using (var cmd = new NpgsqlCommand(sqlBatch, conn))
            {
                ringkasan.JumlahBatch = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return ringkasan;
        }

        public DataTable AmbilRiwayatProduksi()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    rs.id_riwayat_stok,
                    rs.tanggal_riwayat,
                    rs.kategori,
                    rs.arah,
                    CASE
                        WHEN rs.kategori = 'GREEN_BEAN' THEN gb.nama_biji
                        WHEN rs.kategori = 'ROASTED_BEAN' THEN rb.nama_produk
                        ELSE '-'
                    END AS nama_item,
                    rs.jumlah,
                    rs.satuan,
                    COALESCE(rs.referensi, '-') AS referensi
                FROM riwayat_stok rs
                LEFT JOIN biji_kopi_mentah gb
                    ON rs.id_biji_mentah = gb.id_biji_mentah
                LEFT JOIN biji_kopi_roasted rb
                    ON rs.id_roasted = rb.id_roasted
                WHERE COALESCE(rs.referensi, '') NOT LIKE 'CATAT-%'
                ORDER BY rs.tanggal_riwayat DESC, rs.id_riwayat_stok DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}