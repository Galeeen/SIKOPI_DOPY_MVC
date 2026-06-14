using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriLookup : IRepositoriLookup
    {
        public List<LookupItem> AmbilJenisBiji()
        {
            return AmbilLookup(
                "jenis_biji_kopi_mentah",
                "id_jenis_biji_kopi_mentah"
            );
        }

        public List<LookupItem> AmbilMetodeProses()
        {
            return AmbilLookup(
                "metode_proses",
                "id_metode_proses"
            );
        }

        public List<LookupItem> AmbilGreenBeanAktif()
        {
            var hasil = new List<LookupItem>();

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT
                    id_biji_mentah,
                    nama_biji || ' - Stok: ' || stok_kg || ' kg' AS nama
                FROM biji_kopi_mentah
                WHERE is_aktif = TRUE
                ORDER BY nama_biji ASC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hasil.Add(new LookupItem
                {
                    Id = Convert.ToInt32(reader["id_biji_mentah"]),
                    Nama = reader["nama"].ToString() ?? ""
                });
            }

            return hasil;
        }

        private List<LookupItem> AmbilLookup(string namaTabel, string namaKolomId)
        {
            var hasil = new List<LookupItem>();

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = $@"
                SELECT 
                    {namaKolomId},
                    nama
                FROM {namaTabel}
                ORDER BY nama ASC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                hasil.Add(new LookupItem
                {
                    Id = Convert.ToInt32(reader[namaKolomId]),
                    Nama = reader["nama"].ToString() ?? ""
                });
            }

            return hasil;
        }
        public List<GreenBeanLookupItem> AmbilGreenBeanAktifDetail()
        {
            var daftarGreenBean = new List<GreenBeanLookupItem>();

            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
        SELECT
            id_biji_mentah,
            nama_biji,
            stok_kg
        FROM biji_kopi_mentah
        WHERE is_aktif = TRUE
          AND stok_kg > 0
        ORDER BY nama_biji ASC;
    ";

            using var cmd = new Npgsql.NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daftarGreenBean.Add(new GreenBeanLookupItem
                {
                    Id = Convert.ToInt32(reader["id_biji_mentah"]),
                    Nama = reader["nama_biji"].ToString() ?? "",
                    StokKg = Convert.ToDecimal(reader["stok_kg"])
                });
            }

            return daftarGreenBean;
        }
    }
}