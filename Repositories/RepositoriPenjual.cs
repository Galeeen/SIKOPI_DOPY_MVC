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
    public class RepositoriPenjual : IRepositoriPenjual
    {
        public RingkasanPenjualan AmbilRingkasan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    COUNT(*) FILTER (
                        WHERE DATE(p.tanggal_penjualan) = CURRENT_DATE
                    ) AS total_transaksi_hari_ini,

                    COALESCE(SUM(p.total_penjualan) FILTER (
                        WHERE DATE(p.tanggal_penjualan) = CURRENT_DATE
                    ), 0) AS omzet_hari_ini,

                    COALESCE(SUM(dp.jumlah_gram) FILTER (
                        WHERE DATE(p.tanggal_penjualan) = CURRENT_DATE
                    ), 0) AS produk_terjual_gram_hari_ini,

                    COUNT(*) AS total_transaksi_semua
                FROM penjualan p
                LEFT JOIN detail_penjualan dp
                    ON p.id_penjualan = dp.id_penjualan
                WHERE p.is_aktif = TRUE;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            var ringkasan = new RingkasanPenjualan();

            if (reader.Read())
            {
                ringkasan.TotalTransaksiHariIni = Convert.ToInt32(reader["total_transaksi_hari_ini"]);
                ringkasan.OmzetHariIni = Convert.ToDecimal(reader["omzet_hari_ini"]);
                ringkasan.ProdukTerjualGramHariIni = Convert.ToDecimal(reader["produk_terjual_gram_hari_ini"]);
                ringkasan.TotalTransaksiSemua = Convert.ToInt32(reader["total_transaksi_semua"]);
            }

            return ringkasan;
        }

        public DataTable AmbilRiwayatPenjualan()
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
                    p.total_penjualan,
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
                ORDER BY p.tanggal_penjualan DESC, p.id_penjualan DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}