using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class ManajemenUserController
    {
        private readonly IRepositoriManajemenUser _repositoriUser;

        public ManajemenUserController()
        {
            _repositoriUser = new RepositoriManajemenUser();
        }

        public List<Pengguna> AmbilSemuaUser()
        {
            return _repositoriUser.AmbilSemua();
        }

        public Pengguna AmbilUserById(int id)
        {
            Pengguna? pengguna = _repositoriUser.AmbilById(id);

            if (pengguna == null)
                throw new Exception("Data user tidak ditemukan.");

            return pengguna;
        }

        public void TambahUser(Pengguna pengguna)
        {
            ValidasiUser(pengguna, true);

            if (_repositoriUser.UsernameSudahAda(pengguna.NamaPengguna))
                throw new Exception("Username sudah digunakan.");

            _repositoriUser.Tambah(pengguna);
        }

        public void UbahUser(Pengguna pengguna, bool ubahPassword)
        {
            ValidasiUser(pengguna, ubahPassword);

            if (_repositoriUser.UsernameSudahAda(pengguna.NamaPengguna, pengguna.Id))
                throw new Exception("Username sudah digunakan user lain.");

            _repositoriUser.Ubah(pengguna, ubahPassword);
        }

        public void HapusUser(int idUserYangDihapus, int idUserLogin)
        {
            if (idUserYangDihapus <= 0)
                throw new Exception("User tidak valid.");

            if (idUserYangDihapus == idUserLogin)
                throw new Exception("Akun yang sedang login tidak boleh dihapus.");

            _repositoriUser.Hapus(idUserYangDihapus);
        }

        private void ValidasiUser(Pengguna pengguna, bool wajibPassword)
        {
            if (string.IsNullOrWhiteSpace(pengguna.NamaLengkap))
                throw new Exception("Nama lengkap wajib diisi.");

            if (string.IsNullOrWhiteSpace(pengguna.NamaPengguna))
                throw new Exception("Username wajib diisi.");

            if (wajibPassword && string.IsNullOrWhiteSpace(pengguna.KataSandi))
                throw new Exception("Password wajib diisi.");

            if (string.IsNullOrWhiteSpace(pengguna.Peran))
                throw new Exception("Role wajib dipilih.");

            if (
                pengguna.Peran != "Admin" &&
                pengguna.Peran != "Karyawan Produksi" &&
                pengguna.Peran != "Karyawan Penjual"
            )
            {
                throw new Exception("Role tidak valid.");
            }
        }
    }
}