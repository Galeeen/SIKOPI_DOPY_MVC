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
    public partial class FormDashboardProduksi : Form
    {
        private readonly DashboardProduksiController _dashboardProduksiController;

        public FormDashboardProduksi()
        {
            InitializeComponent();

            _dashboardProduksiController = new DashboardProduksiController();

            MuatDataDashboard();
        }

        private void MuatDataDashboard()
        {
            MuatRingkasan();
            MuatBatchTerbaru();
        }

        private void MuatRingkasan()
        {
            try
            {
                RingkasanDashboardProduksi ringkasan =
                    _dashboardProduksiController.AmbilRingkasan();

                CultureInfo id = new CultureInfo("id-ID");

                lblTotalBatch.Text =
                    "Total Batch\r\n" +
                    ringkasan.TotalBatch.ToString("N0", id);

                lblBatchHariIni.Text =
                    "Batch Hari Ini\r\n" +
                    ringkasan.BatchHariIni.ToString("N0", id);

                lblGreenBeanHariIni.Text =
                    "Green Bean Dipakai Hari Ini\r\n" +
                    ringkasan.GreenBeanDipakaiHariIniGram.ToString("N0", id) + " g";

                lblHasilRoastingHariIni.Text =
                    "Hasil Roasting Hari Ini\r\n" +
                    ringkasan.HasilRoastingHariIniGram.ToString("N0", id) + " g";

                lblTotalRoastBean.Text =
                    "Total Stok Roast Bean\r\n" +
                    ringkasan.TotalStokRoastBeanGram.ToString("N0", id) + " g";

                lblMenungguHarga.Text =
                    "Produk Menunggu Harga\r\n" +
                    ringkasan.ProdukMenungguHarga.ToString("N0", id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Ringkasan Produksi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatBatchTerbaru()
        {
            try
            {
                dgvBatchTerbaru.Columns.Clear();
                dgvBatchTerbaru.DataSource = _dashboardProduksiController.AmbilBatchTerbaru();

                AturGridBatchTerbaru();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Batch Terbaru",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridBatchTerbaru()
        {
            if (dgvBatchTerbaru.Columns.Count == 0)
                return;

            if (dgvBatchTerbaru.Columns.Contains("id_batch"))
                dgvBatchTerbaru.Columns["id_batch"].Visible = false;

            if (dgvBatchTerbaru.Columns.Contains("kode_batch"))
                dgvBatchTerbaru.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvBatchTerbaru.Columns.Contains("green_bean"))
                dgvBatchTerbaru.Columns["green_bean"].HeaderText = "GREEN BEAN";

            if (dgvBatchTerbaru.Columns.Contains("jumlah_biji_dipakai_gram"))
            {
                dgvBatchTerbaru.Columns["jumlah_biji_dipakai_gram"].HeaderText = "BERAT MASUK";
                dgvBatchTerbaru.Columns["jumlah_biji_dipakai_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchTerbaru.Columns.Contains("hasil_roasting_gram"))
            {
                dgvBatchTerbaru.Columns["hasil_roasting_gram"].HeaderText = "HASIL ROASTING";
                dgvBatchTerbaru.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchTerbaru.Columns.Contains("level_roasting"))
                dgvBatchTerbaru.Columns["level_roasting"].HeaderText = "LEVEL";

            if (dgvBatchTerbaru.Columns.Contains("tanggal_batch"))
            {
                dgvBatchTerbaru.Columns["tanggal_batch"].HeaderText = "TANGGAL";
                dgvBatchTerbaru.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBatchTerbaru.Columns.Contains("catatan"))
                dgvBatchTerbaru.Columns["catatan"].HeaderText = "CATATAN";
        }
    }
}