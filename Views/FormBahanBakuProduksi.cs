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
    public partial class FormBahanBakuProduksi : Form
    {
        private readonly BahanBakuProduksiController _bahanBakuProduksiController;

        public FormBahanBakuProduksi()
        {
            InitializeComponent();

            _bahanBakuProduksiController = new BahanBakuProduksiController();

            MuatSemuaData();
        }

        private void MuatSemuaData()
        {
            MuatGreenBean();
            MuatRoastBean();
        }

        private void MuatGreenBean()
        {
            try
            {
                dgvGreenBean.Columns.Clear();
                dgvGreenBean.DataSource = _bahanBakuProduksiController.AmbilGreenBean();

                AturGridGreenBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Green Bean",
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
                dgvRoastBean.DataSource = _bahanBakuProduksiController.AmbilRoastBean();

                AturGridRoastBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Roast Bean",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridGreenBean()
        {
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.MultiSelect = false;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvGreenBean.Columns.Contains("id_biji_mentah"))
                dgvGreenBean.Columns["id_biji_mentah"].Visible = false;

            if (dgvGreenBean.Columns.Contains("nama_biji"))
                dgvGreenBean.Columns["nama_biji"].HeaderText = "NAMA BIJI";

            if (dgvGreenBean.Columns.Contains("jenis_biji"))
                dgvGreenBean.Columns["jenis_biji"].HeaderText = "JENIS";

            if (dgvGreenBean.Columns.Contains("metode_proses"))
                dgvGreenBean.Columns["metode_proses"].HeaderText = "METODE";

            if (dgvGreenBean.Columns.Contains("asal_daerah"))
                dgvGreenBean.Columns["asal_daerah"].HeaderText = "ASAL";

            if (dgvGreenBean.Columns.Contains("ketinggian_mdpl"))
                dgvGreenBean.Columns["ketinggian_mdpl"].HeaderText = "KETINGGIAN";

            if (dgvGreenBean.Columns.Contains("tingkat_kualitas"))
                dgvGreenBean.Columns["tingkat_kualitas"].HeaderText = "KUALITAS";

            if (dgvGreenBean.Columns.Contains("stok_kg"))
            {
                dgvGreenBean.Columns["stok_kg"].HeaderText = "STOK KG";
                dgvGreenBean.Columns["stok_kg"].DefaultCellStyle.Format = "N2";
            }

            if (dgvGreenBean.Columns.Contains("harga_per_kg"))
            {
                dgvGreenBean.Columns["harga_per_kg"].HeaderText = "HARGA/KG";
                dgvGreenBean.Columns["harga_per_kg"].DefaultCellStyle.Format = "N0";
            }

            if (dgvGreenBean.Columns.Contains("tanggal_panen"))
            {
                dgvGreenBean.Columns["tanggal_panen"].HeaderText = "TGL PANEN";
                dgvGreenBean.Columns["tanggal_panen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvGreenBean.Columns.Contains("tanggal_masuk"))
            {
                dgvGreenBean.Columns["tanggal_masuk"].HeaderText = "TGL MASUK";
                dgvGreenBean.Columns["tanggal_masuk"].DefaultCellStyle.Format = "dd/MM/yyyy";
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

            if (dgvRoastBean.Columns.Contains("stok_gram"))
            {
                dgvRoastBean.Columns["stok_gram"].HeaderText = "STOK GRAM";
                dgvRoastBean.Columns["stok_gram"].DefaultCellStyle.Format = "N2";
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
                dgvRoastBean.Columns["tanggal_batch"].HeaderText = "TGL BATCH";
                dgvRoastBean.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvRoastBean.Columns.Contains("catatan"))
                dgvRoastBean.Columns["catatan"].HeaderText = "CATATAN";
        }
    }
}
