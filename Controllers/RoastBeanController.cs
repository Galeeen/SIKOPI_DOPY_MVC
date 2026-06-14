using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;


namespace SIKOPI_DOPY_MVC.Controllers
{
    public class RoastBeanController
    {
        private readonly IRepositoriRoastBean _repositoriRoastBean;

        public RoastBeanController()
        {
            _repositoriRoastBean = new RepositoriRoastBean();
        }

        public DataTable AmbilSemuaRoastBean()
        {
            return _repositoriRoastBean.AmbilSemua();
        }

        public RoastBean AmbilRoastBeanById(int idRoasted)
        {
            RoastBean? roastBean = _repositoriRoastBean.AmbilById(idRoasted);

            if (roastBean is null)
                throw new Exception("Data roast bean tidak ditemukan.");

            return roastBean;
        }

        public void UbahHargaRoastBean(int idRoasted, decimal hargaPerGram)
        {
            if (idRoasted <= 0)
                throw new Exception("ID roast bean tidak valid.");

            if (hargaPerGram <= 0)
                throw new Exception("Harga per gram harus lebih dari 0.");

            _repositoriRoastBean.UbahHarga(idRoasted, hargaPerGram);
        }

        public List<RoastBean> AmbilProdukEtalase()
        {
            return _repositoriRoastBean.AmbilSiapJual();
        }
    }
}