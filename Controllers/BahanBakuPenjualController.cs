using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class BahanBakuPenjualController
    {
        private readonly IRepositoriBahanBakuPenjual _repositoriBahanBakuPenjual;

        public BahanBakuPenjualController()
        {
            _repositoriBahanBakuPenjual = new RepositoriBahanBakuPenjual();
        }

        public DataTable AmbilRoastBean()
        {
            return _repositoriBahanBakuPenjual.AmbilRoastBean();
        }
    }
}