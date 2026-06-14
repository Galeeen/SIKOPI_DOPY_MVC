using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class PenjualController
    {
        private readonly IRepositoriPenjual _repositoriPenjual;

        public PenjualController()
        {
            _repositoriPenjual = new RepositoriPenjual();
        }

        public RingkasanPenjualan AmbilRingkasan()
        {
            return _repositoriPenjual.AmbilRingkasan();
        }

        public DataTable AmbilRiwayatPenjualan()
        {
            return _repositoriPenjual.AmbilRiwayatPenjualan();
        }
    }
}