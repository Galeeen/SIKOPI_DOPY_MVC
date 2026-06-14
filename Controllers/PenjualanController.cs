using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class PenjualanController
    {
        private readonly IRepositoriPenjualan _repositoriPenjualan;

        public PenjualanController()
        {
            _repositoriPenjualan = new RepositoriPenjualan();
        }

        public string ProsesPembelian(PembelianProduk pembelian)
        {
            if (pembelian.IdPengguna <= 0)
                throw new Exception("Pengguna pencatat tidak valid.");

            if (pembelian.IdRoasted <= 0)
                throw new Exception("Produk tidak valid.");

            if (string.IsNullOrWhiteSpace(pembelian.NamaPembeli))
                throw new Exception("Nama pembeli wajib diisi.");

            if (pembelian.JumlahGram <= 0)
                throw new Exception("Jumlah pembelian harus lebih dari 0 gram.");

            return _repositoriPenjualan.ProsesPembelian(pembelian);
        }
    }
}