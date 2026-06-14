using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriPenjual
    {
        RingkasanPenjualan AmbilRingkasan();
        DataTable AmbilRiwayatPenjualan();
    }
}
