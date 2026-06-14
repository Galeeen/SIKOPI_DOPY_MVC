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

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormRiwayatPenjualan : Form
    {
        private readonly PenjualController _penjualController;

        public FormRiwayatPenjualan()
        {
            InitializeComponent();

            _penjualController = new PenjualController();

            MuatRiwayatPenjualan();
        }

        private void MuatRiwayatPenjualan()
        {
            try
            {
                dgvRiwayatPenjualan.Columns.Clear();
                dgvRiwayatPenjualan.DataSource = _penjualController.AmbilRiwayatPenjualan();

                AturGridRiwayatPenjualan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Riwayat Penjualan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridRiwayatPenjualan()
        {
            dgvRiwayatPenjualan.ReadOnly = true;
            dgvRiwayatPenjualan.AllowUserToAddRows = false;
            dgvRiwayatPenjualan.AllowUserToDeleteRows = false;
            dgvRiwayatPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatPenjualan.MultiSelect = false;
            dgvRiwayatPenjualan.RowHeadersVisible = false;
            dgvRiwayatPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRiwayatPenjualan.Columns.Contains("id_penjualan"))
                dgvRiwayatPenjualan.Columns["id_penjualan"].Visible = false;

            if (dgvRiwayatPenjualan.Columns.Contains("nomor_invoice"))
                dgvRiwayatPenjualan.Columns["nomor_invoice"].HeaderText = "NO CATATAN";

            if (dgvRiwayatPenjualan.Columns.Contains("nama_pelanggan"))
                dgvRiwayatPenjualan.Columns["nama_pelanggan"].HeaderText = "NAMA PEMBELI";

            if (dgvRiwayatPenjualan.Columns.Contains("nama_produk"))
                dgvRiwayatPenjualan.Columns["nama_produk"].HeaderText = "PRODUK";

            if (dgvRiwayatPenjualan.Columns.Contains("jumlah_gram"))
            {
                dgvRiwayatPenjualan.Columns["jumlah_gram"].HeaderText = "JUMLAH GRAM";
                dgvRiwayatPenjualan.Columns["jumlah_gram"].DefaultCellStyle.Format = "N2";
            }

            if (dgvRiwayatPenjualan.Columns.Contains("harga_per_gram"))
            {
                dgvRiwayatPenjualan.Columns["harga_per_gram"].HeaderText = "HARGA/GRAM";
                dgvRiwayatPenjualan.Columns["harga_per_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRiwayatPenjualan.Columns.Contains("subtotal"))
            {
                dgvRiwayatPenjualan.Columns["subtotal"].HeaderText = "SUBTOTAL";
                dgvRiwayatPenjualan.Columns["subtotal"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRiwayatPenjualan.Columns.Contains("total_penjualan"))
            {
                dgvRiwayatPenjualan.Columns["total_penjualan"].HeaderText = "TOTAL";
                dgvRiwayatPenjualan.Columns["total_penjualan"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRiwayatPenjualan.Columns.Contains("tanggal_penjualan"))
            {
                dgvRiwayatPenjualan.Columns["tanggal_penjualan"].HeaderText = "TANGGAL";
                dgvRiwayatPenjualan.Columns["tanggal_penjualan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvRiwayatPenjualan.Columns.Contains("nama_penjual"))
                dgvRiwayatPenjualan.Columns["nama_penjual"].HeaderText = "PENJUAL";
        }
    }
}
