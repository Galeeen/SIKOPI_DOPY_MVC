using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormBatchRoastingProduksi : Form
    {
        private readonly BatchRoastingProduksiController _batchRoastingProduksiController;
        private readonly Pengguna _penggunaLogin;

        public FormBatchRoastingProduksi(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _batchRoastingProduksiController = new BatchRoastingProduksiController();

            SambungkanEvent();
            MuatSemuaData();
        }

        private void SambungkanEvent()
        {
            btnTambahBatch.Click -= btnTambahBatch_Click;
            btnTambahBatch.Click += btnTambahBatch_Click;
        }

        private void MuatSemuaData()
        {
            MuatBatchRoasting();
            MuatRoastBean();
        }

        private void MuatBatchRoasting()
        {
            try
            {
                dgvBatchRoasting.Columns.Clear();
                dgvBatchRoasting.DataSource = _batchRoastingProduksiController.AmbilBatchRoasting();

                AturGridBatchRoasting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Data Batch Roasting",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRoastBean()
        {
            try
            {
                dgvRoastBean.Columns.Clear();
                dgvRoastBean.DataSource = _batchRoastingProduksiController.AmbilRoastBean();

                AturGridRoastBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Data Roast Bean",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridBatchRoasting()
        {
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.RowHeadersVisible = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBatchRoasting.Columns.Contains("id_batch"))
                dgvBatchRoasting.Columns["id_batch"].Visible = false;

            if (dgvBatchRoasting.Columns.Contains("kode_batch"))
                dgvBatchRoasting.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvBatchRoasting.Columns.Contains("green_bean"))
                dgvBatchRoasting.Columns["green_bean"].HeaderText = "GREEN BEAN";

            if (dgvBatchRoasting.Columns.Contains("jumlah_biji_dipakai_gram"))
            {
                dgvBatchRoasting.Columns["jumlah_biji_dipakai_gram"].HeaderText = "BERAT MASUK (GRAM)";
                dgvBatchRoasting.Columns["jumlah_biji_dipakai_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchRoasting.Columns.Contains("hasil_roasting_gram"))
            {
                dgvBatchRoasting.Columns["hasil_roasting_gram"].HeaderText = "BERAT KELUAR (GRAM)";
                dgvBatchRoasting.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchRoasting.Columns.Contains("level_roasting"))
                dgvBatchRoasting.Columns["level_roasting"].HeaderText = "LEVEL ROASTING";

            if (dgvBatchRoasting.Columns.Contains("tanggal_batch"))
            {
                dgvBatchRoasting.Columns["tanggal_batch"].HeaderText = "TANGGAL BATCH";
                dgvBatchRoasting.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBatchRoasting.Columns.Contains("catatan"))
                dgvBatchRoasting.Columns["catatan"].HeaderText = "CATATAN";
        }

        private void AturGridRoastBean()
        {
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRoastBean.Columns.Contains("id_roasted"))
                dgvRoastBean.Columns["id_roasted"].Visible = false;

            if (dgvRoastBean.Columns.Contains("kode_batch"))
                dgvRoastBean.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvRoastBean.Columns.Contains("nama_produk"))
                dgvRoastBean.Columns["nama_produk"].HeaderText = "NAMA PRODUK";

            if (dgvRoastBean.Columns.Contains("level_roasting"))
                dgvRoastBean.Columns["level_roasting"].HeaderText = "LEVEL ROASTING";

            if (dgvRoastBean.Columns.Contains("hasil_roasting_gram"))
            {
                dgvRoastBean.Columns["hasil_roasting_gram"].HeaderText = "HASIL ROASTING (GRAM)";
                dgvRoastBean.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("stok_gram"))
            {
                dgvRoastBean.Columns["stok_gram"].HeaderText = "STOK GRAM";
                dgvRoastBean.Columns["stok_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("harga_per_gram"))
            {
                dgvRoastBean.Columns["harga_per_gram"].HeaderText = "HARGA/GRAM";
                dgvRoastBean.Columns["harga_per_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("status_harga"))
                dgvRoastBean.Columns["status_harga"].HeaderText = "STATUS HARGA";

            if (dgvRoastBean.Columns.Contains("tanggal_batch"))
            {
                dgvRoastBean.Columns["tanggal_batch"].HeaderText = "TANGGAL BATCH";
                dgvRoastBean.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvRoastBean.Columns.Contains("catatan"))
                dgvRoastBean.Columns["catatan"].HeaderText = "CATATAN";
        }

        private void btnTambahBatch_Click(object? sender, EventArgs e)
        {
            using var form = new FormDialogBatchRoasting(_penggunaLogin);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatSemuaData();
            }
        }
    }
}