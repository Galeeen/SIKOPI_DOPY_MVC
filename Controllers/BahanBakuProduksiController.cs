using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class BahanBakuProduksiController
    {
        private readonly IRepositoriBahanBakuProduksi _repositoriBahanBakuProduksi;

        public BahanBakuProduksiController()
        {
            _repositoriBahanBakuProduksi = new RepositoriBahanBakuProduksi();
        }

        public DataTable AmbilGreenBean()
        {
            return _repositoriBahanBakuProduksi.AmbilGreenBean();
        }

        public DataTable AmbilRoastBean()
        {
            return _repositoriBahanBakuProduksi.AmbilRoastBean();
        }
    }
}