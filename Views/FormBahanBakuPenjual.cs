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

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormBahanBakuPenjual : Form
    {
        private readonly BahanBakuPenjualController _bahanBakuPenjualController;

        public FormBahanBakuPenjual()
        {
            InitializeComponent();

            _bahanBakuPenjualController = new BahanBakuPenjualController();

            MuatRoastBean();
        }

        private void MuatRoastBean()
        {
            try
            {
                dgvRoastBean.Columns.Clear();
                dgvRoastBean.DataSource = _bahanBakuPenjualController.AmbilRoastBean();

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
    }
}
