using SIKOPI_DOPY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriPengguna
    {
        Pengguna? AmbilByNamaPengguna(string namaPengguna);
    }
}
