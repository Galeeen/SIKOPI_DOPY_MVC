using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIKOPI_DOPY_MVC.Helpers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public class RepositoriManajemenUser : IRepositoriManajemenUser
    {
        public List<Pengguna> AmbilSemua()
        {
            var daftarUser = new List<Pengguna>();

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
                ORDER BY id_pengguna ASC;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                daftarUser.Add(new Pengguna
                {
                    Id = Convert.ToInt32(reader["id_pengguna"]),
                    NamaPengguna = reader["nama_pengguna"].ToString() ?? "",
                    KataSandi = reader["kata_sandi"].ToString() ?? "",
                    NamaLengkap = reader["nama_lengkap"].ToString() ?? "",
                    Peran = reader["peran"].ToString() ?? ""
                });
            }

            return daftarUser;
        }

        public Pengguna? AmbilById(int id)
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
                WHERE id_pengguna = @id_pengguna;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_pengguna", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return null;

            return new Pengguna
            {
                Id = Convert.ToInt32(reader["id_pengguna"]),
                NamaPengguna = reader["nama_pengguna"].ToString() ?? "",
                KataSandi = reader["kata_sandi"].ToString() ?? "",
                NamaLengkap = reader["nama_lengkap"].ToString() ?? "",
                Peran = reader["peran"].ToString() ?? ""
            };
        }

        public void Tambah(Pengguna pengguna)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                INSERT INTO pengguna
                (nama_pengguna, kata_sandi, nama_lengkap, peran)
                VALUES
                (@nama_pengguna, @kata_sandi, @nama_lengkap, @peran);
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama_pengguna", pengguna.NamaPengguna);
            cmd.Parameters.AddWithValue("@kata_sandi", pengguna.KataSandi);
            cmd.Parameters.AddWithValue("@nama_lengkap", pengguna.NamaLengkap);
            cmd.Parameters.AddWithValue("@peran", pengguna.Peran);

            cmd.ExecuteNonQuery();
        }

        public void Ubah(Pengguna pengguna, bool ubahPassword)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql;

            if (ubahPassword)
            {
                sql = @"
                    UPDATE pengguna
                    SET
                        nama_pengguna = @nama_pengguna,
                        kata_sandi = @kata_sandi,
                        nama_lengkap = @nama_lengkap,
                        peran = @peran
                    WHERE id_pengguna = @id_pengguna;
                ";
            }
            else
            {
                sql = @"
                    UPDATE pengguna
                    SET
                        nama_pengguna = @nama_pengguna,
                        nama_lengkap = @nama_lengkap,
                        peran = @peran
                    WHERE id_pengguna = @id_pengguna;
                ";
            }

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_pengguna", pengguna.Id);
            cmd.Parameters.AddWithValue("@nama_pengguna", pengguna.NamaPengguna);
            cmd.Parameters.AddWithValue("@nama_lengkap", pengguna.NamaLengkap);
            cmd.Parameters.AddWithValue("@peran", pengguna.Peran);

            if (ubahPassword)
                cmd.Parameters.AddWithValue("@kata_sandi", pengguna.KataSandi);

            cmd.ExecuteNonQuery();
        }

        public void Hapus(int id)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                DELETE FROM pengguna
                WHERE id_pengguna = @id_pengguna;
            ";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_pengguna", id);

            cmd.ExecuteNonQuery();
        }

        public bool UsernameSudahAda(string namaPengguna, int? kecualiId = null)
        {
            using var conn = KoneksiDB.GetConnection();
            conn.Open();

            string sql = @"
                SELECT COUNT(*)
                FROM pengguna
                WHERE LOWER(nama_pengguna) = LOWER(@nama_pengguna)
            ";

            if (kecualiId.HasValue)
            {
                sql += " AND id_pengguna <> @kecuali_id";
            }

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nama_pengguna", namaPengguna);

            if (kecualiId.HasValue)
                cmd.Parameters.AddWithValue("@kecuali_id", kecualiId.Value);

            int jumlah = Convert.ToInt32(cmd.ExecuteScalar());

            return jumlah > 0;
        }
    }
}