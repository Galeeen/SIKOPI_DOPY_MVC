using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class DashboardAdminController
    {
        private readonly IRepositoriDashboardAdmin _repositoriDashboardAdmin;

        public DashboardAdminController()
        {
            _repositoriDashboardAdmin = new RepositoriDashboardAdmin();
        }

        public RingkasanDashboardAdmin AmbilRingkasan()
        {
            return _repositoriDashboardAdmin.AmbilRingkasan();
        }

        public DataTable AmbilRiwayatStokTerbaru()
        {
            return _repositoriDashboardAdmin.AmbilRiwayatStokTerbaru();
        }

        public DataTable AmbilPenjualanTerbaru()
        {
            return _repositoriDashboardAdmin.AmbilPenjualanTerbaru();
        }
    }
}