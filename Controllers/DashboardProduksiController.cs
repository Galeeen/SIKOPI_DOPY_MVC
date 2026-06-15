using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class DashboardProduksiController
    {
        private readonly IRepositoriDashboardProduksi _repositoriDashboardProduksi;

        public DashboardProduksiController()
        {
            _repositoriDashboardProduksi = new RepositoriDashboardProduksi();
        }

        public RingkasanDashboardProduksi AmbilRingkasan()
        {
            return _repositoriDashboardProduksi.AmbilRingkasan();
        }

        public DataTable AmbilBatchTerbaru()
        {
            return _repositoriDashboardProduksi.AmbilBatchTerbaru();
        }
    }
}