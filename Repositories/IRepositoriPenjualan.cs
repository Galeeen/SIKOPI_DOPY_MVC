using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriPenjualan
    {
        string ProsesPembelian(PembelianProduk pembelian);
    }
}