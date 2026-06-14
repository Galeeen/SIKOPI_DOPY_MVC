using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class BatchRoastingProduksiController
    {
        private readonly RepositoriBatchRoasting _repositoriBatchRoasting;
        private readonly RepositoriBahanBakuProduksi _repositoriBahanBakuProduksi;

        public BatchRoastingProduksiController()
        {
            _repositoriBatchRoasting = new RepositoriBatchRoasting();
            _repositoriBahanBakuProduksi = new RepositoriBahanBakuProduksi();
        }

        public DataTable AmbilBatchRoasting()
        {
            return _repositoriBatchRoasting.AmbilSemua();
        }

        public DataTable AmbilRoastBean()
        {
            return _repositoriBahanBakuProduksi.AmbilRoastBean();
        }
    }
}
