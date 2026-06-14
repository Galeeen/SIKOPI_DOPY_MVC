using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class RiwayatController
    {
        private readonly IRepositoriRiwayat _repositoriRiwayat;

        public RiwayatController()
        {
            _repositoriRiwayat = new RepositoriRiwayat();
        }

        public RingkasanRiwayat AmbilRingkasan()
        {
            return _repositoriRiwayat.AmbilRingkasan();
        }

        public DataTable AmbilRiwayatStok()
        {
            return _repositoriRiwayat.AmbilRiwayatStok();
        }

        public DataTable AmbilRiwayatPenjualan()
        {
            return _repositoriRiwayat.AmbilRiwayatPenjualan();
        }
    }
}