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
    public partial class FormDashboardAdmin : Form
    {
        private readonly DashboardAdminController _dashboardAdminController;

        public FormDashboardAdmin()
        {
            InitializeComponent();

            _dashboardAdminController = new DashboardAdminController();

            MuatSemuaData();
        }

        private void MuatSemuaData()
        {
            MuatRingkasan();
            MuatRiwayatStokTerbaru();
            MuatPenjualanTerbaru();
        }

        private void MuatRingkasan()
        {
            try
            {
                RingkasanDashboardAdmin ringkasan = _dashboardAdminController.AmbilRingkasan();

                lblTotalGreenBean.Text =
                    "Total Green Bean\r\n" +
                    ringkasan.TotalGreenBeanKg.ToString("N2", new CultureInfo("id-ID")) +
                    " Kg";

                lblTotalRoastBean.Text =
                    "Total Roast Bean\r\n" +
                    ringkasan.TotalRoastBeanGram.ToString("N0", new CultureInfo("id-ID")) +
                    " g";

                lblTotalBatch.Text =
                    "Total Batch\r\n" +
                    ringkasan.TotalBatch.ToString("N0", new CultureInfo("id-ID"));

                lblBatchHariIni.Text =
                    "Batch Hari Ini\r\n" +
                    ringkasan.BatchHariIni.ToString("N0", new CultureInfo("id-ID"));

                lblProdukSiapJual.Text =
                    "Produk Siap Jual\r\n" +
                    ringkasan.ProdukSiapJual.ToString("N0", new CultureInfo("id-ID"));

                lblMenungguHarga.Text =
                    "Menunggu Harga\r\n" +
                    ringkasan.ProdukMenungguHarga.ToString("N0", new CultureInfo("id-ID"));

                lblTransaksiHariIni.Text =
                    "Transaksi Hari Ini\r\n" +
                    ringkasan.TransaksiHariIni.ToString("N0", new CultureInfo("id-ID"));

                lblOmzetHariIni.Text =
                    "Omzet Hari Ini\r\nRp " +
                    ringkasan.OmzetHariIni.ToString("N0", new CultureInfo("id-ID"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Ringkasan Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRiwayatStokTerbaru()
        {
            try
            {
                dgvRiwayatStokTerbaru.Columns.Clear();
                dgvRiwayatStokTerbaru.DataSource = _dashboardAdminController.AmbilRiwayatStokTerbaru();

                AturGridRiwayatStok();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Riwayat Stok Terbaru",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatPenjualanTerbaru()
        {
            try
            {
                dgvPenjualanTerbaru.Columns.Clear();
                dgvPenjualanTerbaru.DataSource = _dashboardAdminController.AmbilPenjualanTerbaru();

                AturGridPenjualanTerbaru();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Penjualan Terbaru",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturGridRiwayatStok()
        {
            dgvRiwayatStokTerbaru.ReadOnly = true;
            dgvRiwayatStokTerbaru.AllowUserToAddRows = false;
            dgvRiwayatStokTerbaru.AllowUserToDeleteRows = false;
            dgvRiwayatStokTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatStokTerbaru.MultiSelect = false;
            dgvRiwayatStokTerbaru.RowHeadersVisible = false;
            dgvRiwayatStokTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRiwayatStokTerbaru.Columns.Contains("id_riwayat_stok"))
                dgvRiwayatStokTerbaru.Columns["id_riwayat_stok"].Visible = false;

            if (dgvRiwayatStokTerbaru.Columns.Contains("tanggal_riwayat"))
            {
                dgvRiwayatStokTerbaru.Columns["tanggal_riwayat"].HeaderText = "TANGGAL";
                dgvRiwayatStokTerbaru.Columns["tanggal_riwayat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvRiwayatStokTerbaru.Columns.Contains("kategori"))
                dgvRiwayatStokTerbaru.Columns["kategori"].HeaderText = "KATEGORI";

            if (dgvRiwayatStokTerbaru.Columns.Contains("arah"))
                dgvRiwayatStokTerbaru.Columns["arah"].HeaderText = "ARAH";

            if (dgvRiwayatStokTerbaru.Columns.Contains("nama_item"))
                dgvRiwayatStokTerbaru.Columns["nama_item"].HeaderText = "ITEM";

            if (dgvRiwayatStokTerbaru.Columns.Contains("jumlah"))
            {
                dgvRiwayatStokTerbaru.Columns["jumlah"].HeaderText = "JUMLAH";
                dgvRiwayatStokTerbaru.Columns["jumlah"].DefaultCellStyle.Format = "N2";
            }

            if (dgvRiwayatStokTerbaru.Columns.Contains("satuan"))
                dgvRiwayatStokTerbaru.Columns["satuan"].HeaderText = "SATUAN";

            if (dgvRiwayatStokTerbaru.Columns.Contains("referensi"))
                dgvRiwayatStokTerbaru.Columns["referensi"].HeaderText = "REFERENSI";
        }

        private void AturGridPenjualanTerbaru()
        {
            dgvPenjualanTerbaru.ReadOnly = true;
            dgvPenjualanTerbaru.AllowUserToAddRows = false;
            dgvPenjualanTerbaru.AllowUserToDeleteRows = false;
            dgvPenjualanTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualanTerbaru.MultiSelect = false;
            dgvPenjualanTerbaru.RowHeadersVisible = false;
            dgvPenjualanTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPenjualanTerbaru.Columns.Contains("id_penjualan"))
                dgvPenjualanTerbaru.Columns["id_penjualan"].Visible = false;

            if (dgvPenjualanTerbaru.Columns.Contains("nomor_invoice"))
                dgvPenjualanTerbaru.Columns["nomor_invoice"].HeaderText = "NO CATATAN";

            if (dgvPenjualanTerbaru.Columns.Contains("nama_pelanggan"))
                dgvPenjualanTerbaru.Columns["nama_pelanggan"].HeaderText = "PEMBELI";

            if (dgvPenjualanTerbaru.Columns.Contains("nama_produk"))
                dgvPenjualanTerbaru.Columns["nama_produk"].HeaderText = "PRODUK";

            if (dgvPenjualanTerbaru.Columns.Contains("jumlah_gram"))
            {
                dgvPenjualanTerbaru.Columns["jumlah_gram"].HeaderText = "JUMLAH GRAM";
                dgvPenjualanTerbaru.Columns["jumlah_gram"].DefaultCellStyle.Format = "N2";
            }

            if (dgvPenjualanTerbaru.Columns.Contains("harga_per_gram"))
            {
                dgvPenjualanTerbaru.Columns["harga_per_gram"].HeaderText = "HARGA/GRAM";
                dgvPenjualanTerbaru.Columns["harga_per_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvPenjualanTerbaru.Columns.Contains("subtotal"))
            {
                dgvPenjualanTerbaru.Columns["subtotal"].HeaderText = "SUBTOTAL";
                dgvPenjualanTerbaru.Columns["subtotal"].DefaultCellStyle.Format = "N0";
            }

            if (dgvPenjualanTerbaru.Columns.Contains("tanggal_penjualan"))
            {
                dgvPenjualanTerbaru.Columns["tanggal_penjualan"].HeaderText = "TANGGAL";
                dgvPenjualanTerbaru.Columns["tanggal_penjualan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            if (dgvPenjualanTerbaru.Columns.Contains("nama_penjual"))
                dgvPenjualanTerbaru.Columns["nama_penjual"].HeaderText = "PENJUAL";
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}