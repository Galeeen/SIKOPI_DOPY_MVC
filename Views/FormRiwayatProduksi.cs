using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormRiwayatProduksi : Form
    {
        private readonly RiwayatProduksiController _riwayatProduksiController;

        public FormRiwayatProduksi()
        {
            InitializeComponent();

            _riwayatProduksiController = new RiwayatProduksiController();

            MuatSemuaData();
        }

        private void MuatSemuaData()
        {
            MuatRingkasan();
            MuatRiwayatProduksi();
        }

        private void MuatRingkasan()
        {
            try
            {
                RingkasanRiwayatProduksi ringkasan = _riwayatProduksiController.AmbilRingkasan();

                lblGreenBeanKeluar.Text =
                    "GB Keluar\r\n" +
                    ringkasan.GreenBeanKeluarKg.ToString("0.##", CultureInfo.InvariantCulture) +
                    " Kg";

                lblRoastBeanMasuk.Text =
                    "RB Masuk\r\n" +
                    ringkasan.RoastBeanMasukGram.ToString("0.##", CultureInfo.InvariantCulture) +
                    " g";

                lblJumlahBatch.Text =
                    "Batch\r\n" +
                    ringkasan.JumlahBatch.ToString("N0", new CultureInfo("id-ID"));

                lblTotalAktivitas.Text =
                    "Aktivitas\r\n" +
                    ringkasan.TotalAktivitas.ToString("N0", new CultureInfo("id-ID"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Ringkasan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRiwayatProduksi()
        {
            try
            {
                dgvRiwayatProduksi.Columns.Clear();
                dgvRiwayatProduksi.DataSource = _riwayatProduksiController.AmbilRiwayatProduksi();

                AturGridRiwayatProduksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Riwayat Produksi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridRiwayatProduksi()
        {
            dgvRiwayatProduksi.ReadOnly = true;
            dgvRiwayatProduksi.AllowUserToAddRows = false;
            dgvRiwayatProduksi.AllowUserToDeleteRows = false;
            dgvRiwayatProduksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatProduksi.MultiSelect = false;
            dgvRiwayatProduksi.RowHeadersVisible = false;
            dgvRiwayatProduksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRiwayatProduksi.Columns.Contains("id_riwayat_stok"))
                dgvRiwayatProduksi.Columns["id_riwayat_stok"].Visible = false;

            if (dgvRiwayatProduksi.Columns.Contains("tanggal_riwayat"))
            {
                dgvRiwayatProduksi.Columns["tanggal_riwayat"].HeaderText = "TANGGAL";
                dgvRiwayatProduksi.Columns["tanggal_riwayat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvRiwayatProduksi.Columns.Contains("kategori"))
                dgvRiwayatProduksi.Columns["kategori"].HeaderText = "KATEGORI";

            if (dgvRiwayatProduksi.Columns.Contains("arah"))
                dgvRiwayatProduksi.Columns["arah"].HeaderText = "ARAH";

            if (dgvRiwayatProduksi.Columns.Contains("nama_item"))
                dgvRiwayatProduksi.Columns["nama_item"].HeaderText = "ITEM";

            if (dgvRiwayatProduksi.Columns.Contains("jumlah"))
            {
                dgvRiwayatProduksi.Columns["jumlah"].HeaderText = "JUMLAH";
                dgvRiwayatProduksi.Columns["jumlah"].DefaultCellStyle.Format = "N2";
            }

            if (dgvRiwayatProduksi.Columns.Contains("satuan"))
                dgvRiwayatProduksi.Columns["satuan"].HeaderText = "SATUAN";

            if (dgvRiwayatProduksi.Columns.Contains("referensi"))
                dgvRiwayatProduksi.Columns["referensi"].HeaderText = "REFERENSI";
        }
    }
}
