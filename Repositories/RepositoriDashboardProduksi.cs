using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriDashboardProduksi : IRepositoriDashboardProduksi
    {
        public RingkasanDashboardProduksi AmbilRingkasan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    (
                        SELECT COUNT(*)
                        FROM batch_roasting
                        WHERE is_aktif = TRUE
                    ) AS total_batch,

                    (
                        SELECT COUNT(*)
                        FROM batch_roasting
                        WHERE is_aktif = TRUE
                          AND DATE(tanggal_batch) = CURRENT_DATE
                    ) AS batch_hari_ini,

                    (
                        SELECT COALESCE(SUM(jumlah_biji_dipakai_gram), 0)
                        FROM batch_roasting
                        WHERE is_aktif = TRUE
                          AND DATE(tanggal_batch) = CURRENT_DATE
                    ) AS green_bean_dipakai_hari_ini_gram,

                    (
                        SELECT COALESCE(SUM(hasil_roasting_gram), 0)
                        FROM batch_roasting
                        WHERE is_aktif = TRUE
                          AND DATE(tanggal_batch) = CURRENT_DATE
                    ) AS hasil_roasting_hari_ini_gram,

                    (
                        SELECT COALESCE(SUM(stok_gram), 0)
                        FROM biji_kopi_roasted
                        WHERE is_aktif = TRUE
                    ) AS total_stok_roast_bean_gram,

                    (
                        SELECT COUNT(*)
                        FROM biji_kopi_roasted
                        WHERE is_aktif = TRUE
                          AND status_harga = 'MENUNGGU_HARGA'
                    ) AS produk_menunggu_harga;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var ringkasan = new RingkasanDashboardProduksi();

            if (reader.Read())
            {
                ringkasan.TotalBatch = Convert.ToInt32(reader["total_batch"]);
                ringkasan.BatchHariIni = Convert.ToInt32(reader["batch_hari_ini"]);
                ringkasan.GreenBeanDipakaiHariIniGram = Convert.ToDecimal(reader["green_bean_dipakai_hari_ini_gram"]);
                ringkasan.HasilRoastingHariIniGram = Convert.ToDecimal(reader["hasil_roasting_hari_ini_gram"]);
                ringkasan.TotalStokRoastBeanGram = Convert.ToDecimal(reader["total_stok_roast_bean_gram"]);
                ringkasan.ProdukMenungguHarga = Convert.ToInt32(reader["produk_menunggu_harga"]);
            }

            return ringkasan;
        }

        public DataTable AmbilBatchTerbaru()
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
                ORDER BY br.id_batch DESC
                LIMIT 10;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}
