using System.Data;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class BatchRoastingController
    {
        private readonly IRepositoriBatchRoasting _repositoriBatchRoasting;
        private readonly int _idPenggunaLogin;

        public BatchRoastingController(int idPenggunaLogin)
        {
            _repositoriBatchRoasting = new RepositoriBatchRoasting();
            _idPenggunaLogin = idPenggunaLogin;
        }

        public DataTable AmbilSemuaBatch()
        {
            return _repositoriBatchRoasting.AmbilSemua();
        }

        public BatchRoasting AmbilBatchById(int idBatch)
        {
            BatchRoasting? batch = _repositoriBatchRoasting.AmbilById(idBatch);

            if (batch is null)
                throw new Exception("Data batch roasting tidak ditemukan.");

            return batch;
        }

        public void TambahBatch(BatchRoasting batch)
        {
            batch.IdPengguna = _idPenggunaLogin;

            // Kode batch dibuat otomatis di sini, bukan dari form
            batch.KodeBatch = BuatKodeBatchOtomatis();

            ValidasiBatch(batch);
            _repositoriBatchRoasting.Tambah(batch);
        }

        public void UbahBatch(BatchRoasting batch)
        {
            if (batch.Id <= 0)
                throw new Exception("ID batch tidak valid.");

            ValidasiBatch(batch);
            _repositoriBatchRoasting.Ubah(batch);
        }

        public void HapusBatch(int idBatch)
        {
            if (idBatch <= 0)
                throw new Exception("ID batch tidak valid.");

            _repositoriBatchRoasting.Hapus(idBatch);
        }

        private string BuatKodeBatchOtomatis()
        {
            return "BATCH-" + DateTime.Now.ToString("yyyyMMdd-HHmmssfff");
        }

        private void ValidasiBatch(BatchRoasting batch)
        {
            if (batch.IdBijiMentah <= 0)
                throw new Exception("Green bean wajib dipilih.");

            if (string.IsNullOrWhiteSpace(batch.KodeBatch))
                throw new Exception("Kode batch gagal dibuat otomatis.");

            if (batch.JumlahBijiDipakaiKg <= 0)
                throw new Exception("Green bean dipakai harus lebih dari 0.");

            if (batch.HasilRoastingGram <= 0)
                throw new Exception("Hasil roast bean harus lebih dari 0.");

            if (string.IsNullOrWhiteSpace(batch.LevelRoasting))
                throw new Exception("Roast level wajib dipilih.");
        }
    }
}