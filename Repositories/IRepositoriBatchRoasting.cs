using SIKOPI_DOPY_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SIKOPI_DOPY_MVC.Repositories
{
    public interface IRepositoriBatchRoasting
    {
        DataTable AmbilSemua();
        BatchRoasting? AmbilById(int idBatch);
        void Tambah(BatchRoasting batchRoasting);
        void Ubah(BatchRoasting batchRoasting);
        void Hapus(int idBatch);
    }
}
