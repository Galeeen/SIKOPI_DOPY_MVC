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
    public class RepositoriDashboardAdmin : IRepositoriDashboardAdmin
    {
        public RingkasanDashboardAdmin AmbilRingkasan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    (
                        SELECT COALESCE(SUM(stok_kg), 0)
                        FROM biji_kopi_mentah
                        WHERE is_aktif = TRUE
                    ) AS total_green_bean_kg,

                    (
                        SELECT COALESCE(SUM(stok_gram), 0)
                        FROM biji_kopi_roasted
                        WHERE is_aktif = TRUE
                    ) AS total_roast_bean_gram,

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
                        SELECT COUNT(*)
                        FROM biji_kopi_roasted
                        WHERE is_aktif = TRUE
                          AND status_harga = 'SIAP_JUAL'
                          AND harga_per_gram > 0
                          AND stok_gram > 0
                    ) AS produk_siap_jual,

                    (
                        SELECT COUNT(*)
                        FROM biji_kopi_roasted
                        WHERE is_aktif = TRUE
                          AND (
                                status_harga = 'MENUNGGU_HARGA'
                                OR harga_per_gram <= 0
                              )
                    ) AS produk_menunggu_harga,

                    (
                        SELECT COUNT(*)
                        FROM penjualan
                        WHERE is_aktif = TRUE
                          AND DATE(tanggal_penjualan) = CURRENT_DATE
                    ) AS transaksi_hari_ini,

                    (
                        SELECT COALESCE(SUM(total_penjualan), 0)
                        FROM penjualan
                        WHERE is_aktif = TRUE
                          AND DATE(tanggal_penjualan) = CURRENT_DATE
                    ) AS omzet_hari_ini;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var ringkasan = new RingkasanDashboardAdmin();

            if (reader.Read())
            {
                ringkasan.TotalGreenBeanKg = Convert.ToDecimal(reader["total_green_bean_kg"]);
                ringkasan.TotalRoastBeanGram = Convert.ToDecimal(reader["total_roast_bean_gram"]);
                ringkasan.TotalBatch = Convert.ToInt32(reader["total_batch"]);
                ringkasan.BatchHariIni = Convert.ToInt32(reader["batch_hari_ini"]);
                ringkasan.ProdukSiapJual = Convert.ToInt32(reader["produk_siap_jual"]);
                ringkasan.ProdukMenungguHarga = Convert.ToInt32(reader["produk_menunggu_harga"]);
                ringkasan.TransaksiHariIni = Convert.ToInt32(reader["transaksi_hari_ini"]);
                ringkasan.OmzetHariIni = Convert.ToDecimal(reader["omzet_hari_ini"]);
            }

            return ringkasan;
        }

        public DataTable AmbilRiwayatStokTerbaru()
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
                ORDER BY rs.tanggal_riwayat DESC, rs.id_riwayat_stok DESC
                LIMIT 15;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public DataTable AmbilPenjualanTerbaru()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    p.id_penjualan,
                    p.nomor_invoice,
                    p.nama_pelanggan,
                    rb.nama_produk,
                    dp.jumlah_gram,
                    dp.harga_per_gram,
                    dp.subtotal,
                    p.tanggal_penjualan,
                    pg.nama_lengkap AS nama_penjual
                FROM penjualan p
                JOIN detail_penjualan dp
                    ON p.id_penjualan = dp.id_penjualan
                JOIN biji_kopi_roasted rb
                    ON dp.id_roasted = rb.id_roasted
                JOIN pengguna pg
                    ON p.id_pengguna = pg.id_pengguna
                WHERE p.is_aktif = TRUE
                ORDER BY p.tanggal_penjualan DESC, p.id_penjualan DESC
                LIMIT 15;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}