using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SIKOPI_DOPY_MVC.Models;


namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriGreenBean
    {
        DataTable AmbilSemua();
        GreenBean? AmbilById(int idBijiMentah);
        void Tambah(GreenBean greenBean);
        void Ubah(GreenBean greenBean);
        void Hapus(int idBijiMentah);
    }
}
