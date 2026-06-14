using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriBahanBakuProduksi
    {
        DataTable AmbilGreenBean();
        DataTable AmbilRoastBean();
    }
}