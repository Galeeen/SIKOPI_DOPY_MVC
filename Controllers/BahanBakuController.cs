using System;
using System.Collections.Generic;
using System.Text;
using SIKOPI_DOPY_MVC.Repositories;
using SIKOPI_DOPY_MVC.Models;
using System.Data;

namespace SIKOPI_DOPY_MVC.Controllers
{
    public class BahanBakuController
    {
        private readonly IRepositoriGreenBean _repositoriGreenBean;

        public BahanBakuController()
        {
            _repositoriGreenBean = new RepositoriGreenBean();
        }

        public DataTable AmbilSemuaGreenBean()
        {
            return _repositoriGreenBean.AmbilSemua();
        }

        public GreenBean AmbilGreenBeanById(int idBijiMentah)
        {
            GreenBean? greenBean = _repositoriGreenBean.AmbilById(idBijiMentah);

            if (greenBean == null)
                throw new Exception("Data green bean tidak ditemukan.");

            return greenBean;
        }

        public void TambahGreenBean(GreenBean greenBean)
        {
            ValidasiGreenBean(greenBean);
            _repositoriGreenBean.Tambah(greenBean);
        }

        public void UbahGreenBean(GreenBean greenBean)
        {
            if (greenBean.Id <= 0)
                throw new Exception("ID green bean tidak valid.");

            ValidasiGreenBean(greenBean);
            _repositoriGreenBean.Ubah(greenBean);
        }

        public void HapusGreenBean(int idBijiMentah)
        {
            if (idBijiMentah <= 0)
                throw new Exception("ID green bean tidak valid.");

            _repositoriGreenBean.Hapus(idBijiMentah);
        }

        private void ValidasiGreenBean(GreenBean greenBean)
        {
            if (string.IsNullOrWhiteSpace(greenBean.NamaBiji))
                throw new Exception("Nama biji wajib diisi.");

            if (string.IsNullOrWhiteSpace(greenBean.AsalDaerah))
                throw new Exception("Asal daerah wajib diisi.");

            if (greenBean.IdJenisBijiKopiMentah <= 0)
                throw new Exception("Jenis biji wajib dipilih.");

            if (greenBean.IdMetodeProses <= 0)
                throw new Exception("Metode proses wajib dipilih.");

            if (string.IsNullOrWhiteSpace(greenBean.TingkatKualitas))
                throw new Exception("Grade/kualitas wajib diisi.");

            if (greenBean.KetinggianMdpl < 0)
                throw new Exception("Ketinggian tidak boleh minus.");

            if (greenBean.StokKg < 0)
                throw new Exception("Stok tidak boleh minus.");

            if (greenBean.HargaPerKg < 0)
                throw new Exception("Harga tidak boleh minus.");
        }
    }
}
