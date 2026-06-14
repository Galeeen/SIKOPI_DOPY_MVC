using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriBahanBakuProduksi : IRepositoriBahanBakuProduksi
    {
        public DataTable AmbilGreenBean()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    gb.id_biji_mentah,
                    gb.nama_biji,
                    jb.nama AS jenis_biji,
                    mp.nama AS metode_proses,
                    gb.asal_daerah,
                    gb.ketinggian_mdpl,
                    gb.tingkat_kualitas,
                    gb.stok_kg,
                    gb.harga_per_kg,
                    gb.tanggal_panen,
                    gb.tanggal_masuk
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

        public DataTable AmbilRoastBean()
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    rb.id_roasted,
                    br.kode_batch,
                    rb.nama_produk,
                    br.level_roasting,
                    rb.stok_gram,
                    rb.harga_per_gram,
                    rb.status_harga,
                    br.tanggal_batch,
                    rb.catatan
                FROM biji_kopi_roasted rb
                JOIN batch_roasting br
                    ON rb.id_batch = br.id_batch
                WHERE rb.is_aktif = TRUE
                ORDER BY rb.id_roasted DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}