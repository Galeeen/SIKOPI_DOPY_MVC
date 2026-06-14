using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories

{
    public class RepositoriPengguna : IRepositoriPengguna
    {
        public Pengguna?AmbilByNamaPengguna(string namaPenggguna)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
               SELECT 
                    id_pengguna, 
                    nama_pengguna, 
                    kata_sandi, 
                    nama_lengkap, 
                    peran
                FROM pengguna
                WHERE nama_pengguna = @nama_pengguna
                Limit 1;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("nama_pengguna", namaPenggguna);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Pengguna
            {
                Id = Convert.ToInt32(reader["id_pengguna"]),
                NamaPengguna = reader["nama_pengguna"].ToString() ??"",
                KataSandi = reader["kata_sandi"].ToString() ?? "",
                NamaLengkap = reader["nama_lengkap"].ToString() ?? "",
                Peran = reader["peran"].ToString() ?? ""
            };
        }
    }
}
