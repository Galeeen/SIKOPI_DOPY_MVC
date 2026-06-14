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

            if (batch.IdPengguna <= 0)
                throw new Exception("Pengguna tidak valid.");

            if (batch.JumlahBijiDipakaiGram <= 0)
                throw new Exception("Jumlah biji masuk harus lebih dari 0 gram.");

            if (batch.HasilRoastingGram <= 0)
                throw new Exception("Hasil roasting harus lebih dari 0 gram.");

            if (batch.HasilRoastingGram >= batch.JumlahBijiDipakaiGram)
            {
                throw new Exception(
                    "Berat keluar tidak boleh sama atau lebih besar dari berat masuk."
                );
            }

            if (string.IsNullOrWhiteSpace(batch.LevelRoasting))
                throw new Exception("Level roasting wajib dipilih.");

            if (
                batch.LevelRoasting != "Light" &&
                batch.LevelRoasting != "Medium" &&
                batch.LevelRoasting != "Medium Dark" &&
                batch.LevelRoasting != "Dark"
            )
            {
                throw new Exception("Level roasting tidak valid.");
            }
        }
    }
}