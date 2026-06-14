using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class RiwayatProduksiController
    {
        private readonly IRepositoriRiwayatProduksi _repositoriRiwayatProduksi;

        public RiwayatProduksiController()
        {
            _repositoriRiwayatProduksi = new RepositoriRiwayatProduksi();
        }

        public RingkasanRiwayatProduksi AmbilRingkasan()
        {
            return _repositoriRiwayatProduksi.AmbilRingkasan();
        }

        public DataTable AmbilRiwayatProduksi()
        {
            return _repositoriRiwayatProduksi.AmbilRiwayatProduksi();
        }
    }
}
