using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriManajemenUser
    {
        List<Pengguna> AmbilSemua();
        Pengguna? AmbilById(int id);
        void Tambah(Pengguna pengguna);
        void Ubah(Pengguna pengguna, bool ubahPassword);
        void Hapus(int id);
        bool UsernameSudahAda(string namaPengguna, int? kecualiId = null);
    }
}