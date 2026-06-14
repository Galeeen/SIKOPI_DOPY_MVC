using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class AuthController
    {
        private readonly IRepositoriPengguna _repositoriPengguna;

        public AuthController()
        {
            _repositoriPengguna = new RepositoriPengguna();
        }

        public Pengguna Login(string namaPengguna, string kataSandi)
        {
            if (string.IsNullOrWhiteSpace(namaPengguna))
                throw new Exception("Username wajib diisi.");

            if (string.IsNullOrWhiteSpace(kataSandi))
                throw new Exception("Password wajib diisi.");

            Pengguna? pengguna = _repositoriPengguna.AmbilByNamaPengguna(namaPengguna);

            if (pengguna is null)
                throw new Exception("Username tidak ditemukan.");

            if (pengguna.KataSandi != kataSandi)
                throw new Exception("Password salah.");

            return pengguna;
        }
    }
}