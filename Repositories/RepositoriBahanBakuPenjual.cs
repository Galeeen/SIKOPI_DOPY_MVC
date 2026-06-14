using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriBahanBakuPenjual : IRepositoriBahanBakuPenjual
    {
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
                    br.hasil_roasting_gram,
                    rb.stok_gram,
                    rb.harga_per_gram,
                    rb.status_harga,
                    br.tanggal_batch,
                    COALESCE(rb.catatan, '') AS catatan
                FROM biji_kopi_roasted rb
                JOIN batch_roasting br
                    ON rb.id_batch = br.id_batch
                WHERE rb.is_aktif = TRUE
                  AND br.is_aktif = TRUE
                ORDER BY rb.status_harga ASC, rb.id_roasted DESC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);

            var dt = new DataTable();
            using var adapter = new NpgsqlDataAdapter(cmd);
            adapter.Fill(dt);

            return dt;
        }
    }
}