using System;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriRiwayat : IRepositoriRiwayat
    {
        public RingkasanRiwayat AmbilRingkasan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            var ringkasan = new RingkasanRiwayat();

            string sqlStok = @"
                SELECT
                    COALESCE(SUM(CASE WHEN kategori = 'GREEN_BEAN' AND arah = 'MASUK' THEN jumlah ELSE 0 END), 0) AS green_bean_masuk,
                    COALESCE(SUM(CASE WHEN kategori = 'GREEN_BEAN' AND arah = 'KELUAR' THEN jumlah ELSE 0 END), 0) AS green_bean_keluar,
                    COALESCE(SUM(CASE WHEN kategori = 'ROASTED_BEAN' AND arah = 'MASUK' THEN jumlah ELSE 0 END), 0) AS roast_bean_masuk,
                    COALESCE(SUM(CASE WHEN kategori = 'ROASTED_BEAN' AND arah = 'KELUAR' THEN jumlah ELSE 0 END), 0) AS roast_bean_keluar
                FROM riwayat_stok;
            ";

            using (var cmd = new NpgsqlCommand(sqlStok, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ringkasan.GreenBeanMasukKg = Convert.ToDecimal(reader["green_bean_masuk"]);
                    ringkasan.GreenBeanKeluarKg = Convert.ToDecimal(reader["green_bean_keluar"]);
                    ringkasan.RoastBeanMasukGram = Convert.ToDecimal(reader["roast_bean_masuk"]);
                    ringkasan.RoastBeanKeluarGram = Convert.ToDecimal(reader["roast_bean_keluar"]);
                }
            }

            string sqlPenjualan = @"
                SELECT
                    COUNT(*) AS jumlah_transaksi,
                    COALESCE(SUM(total_penjualan), 0) AS total_penjualan
                FROM penjualan
                WHERE is_aktif = TRUE;
            ";

            using (var cmd = new NpgsqlCommand(sqlPenjualan, conn))
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    ringkasan.JumlahTransaksi = Convert.ToInt32(reader["jumlah_transaksi"]);
                    ringkasan.TotalPenjualan = Convert.ToDecimal(reader["total_penjualan"]);
                }
            }

            return ringkasan;
        }

        public DataTable AmbilRiwayatStok()
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
                ORDER BY rs.tanggal_riwayat DESC, rs.id_riwayat_stok DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }

        public DataTable AmbilRiwayatPenjualan()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    p.id_penjualan,
                    p.nomor_invoice,
                    p.tanggal_penjualan,
                    p.nama_pelanggan,
                    u.nama_lengkap AS dicatat_oleh,
                    rb.nama_produk,
                    dp.jumlah_gram,
                    dp.harga_per_gram,
                    dp.subtotal,
                    p.total_penjualan
                FROM penjualan p
                JOIN detail_penjualan dp
                    ON p.id_penjualan = dp.id_penjualan
                JOIN biji_kopi_roasted rb
                    ON dp.id_roasted = rb.id_roasted
                JOIN pengguna u
                    ON p.id_pengguna = u.id_pengguna
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