using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;
using System.Globalization;


namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormRiwayatAdmin : Form
    {
        private readonly RiwayatController _riwayatController;

        public FormRiwayatAdmin()
        {
            InitializeComponent();

            _riwayatController = new RiwayatController();

            MuatSemuaData();
        }

        private void MuatSemuaData()
        {
            MuatRingkasan();
            MuatRiwayatStok();
            MuatRiwayatPenjualan();
        }

        private void MuatRingkasan()
        {
            try
            {
                RingkasanRiwayat ringkasan = _riwayatController.AmbilRingkasan();

                lblGreenBeanMasuk.Text =
                    "GB Masuk\r\n" +
                    ringkasan.GreenBeanMasukKg.ToString("0.##", CultureInfo.InvariantCulture) +
                    " Kg";

                lblGreenBeanKeluar.Text =
                    "GB Keluar\r\n" +
                    ringkasan.GreenBeanKeluarKg.ToString("0.##", CultureInfo.InvariantCulture) +
                    " Kg";

                lblRoastBeanMasuk.Text =
                    "RB Masuk\r\n" +
                    ringkasan.RoastBeanMasukGram.ToString("0.##", CultureInfo.InvariantCulture) +
                    " g";

                lblRoastBeanKeluar.Text =
                    "RB Keluar\r\n" +
                    ringkasan.RoastBeanKeluarGram.ToString("0.##", CultureInfo.InvariantCulture) +
                    " g";

                lblJumlahTransaksi.Text =
                    "Catatan\r\n" +
                    ringkasan.JumlahTransaksi.ToString("N0", new CultureInfo("id-ID"));

                lblTotalPenjualan.Text =
                    "Total Catat\r\nRp " +
                    ringkasan.TotalPenjualan.ToString("N0", new CultureInfo("id-ID"));
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

        private void MuatRiwayatStok()
        {
            try
            {
                dgvRiwayatStok.Columns.Clear();
                dgvRiwayatStok.DataSource = _riwayatController.AmbilRiwayatStok();

                AturGridRiwayatStok();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Riwayat Stok",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRiwayatPenjualan()
        {
            try
            {
                dgvTransaksiPenjualan.Columns.Clear();
                dgvTransaksiPenjualan.DataSource = _riwayatController.AmbilRiwayatPenjualan();

                AturGridTransaksiPenjualan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Catatan Pembelian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void label2_Click(object? sender, EventArgs e)
        {
        }

        private void AturGridRiwayatStok()
        {
            dgvRiwayatStok.ReadOnly = true;
            dgvRiwayatStok.AllowUserToAddRows = false;
            dgvRiwayatStok.AllowUserToDeleteRows = false;
            dgvRiwayatStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatStok.MultiSelect = false;
            dgvRiwayatStok.RowHeadersVisible = false;
            dgvRiwayatStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRiwayatStok.Columns.Contains("id_riwayat_stok"))
                dgvRiwayatStok.Columns["id_riwayat_stok"].Visible = false;

            if (dgvRiwayatStok.Columns.Contains("tanggal_riwayat"))
                dgvRiwayatStok.Columns["tanggal_riwayat"].HeaderText = "TANGGAL";

            if (dgvRiwayatStok.Columns.Contains("kategori"))
                dgvRiwayatStok.Columns["kategori"].HeaderText = "KATEGORI";

            if (dgvRiwayatStok.Columns.Contains("arah"))
                dgvRiwayatStok.Columns["arah"].HeaderText = "ARAH";

            if (dgvRiwayatStok.Columns.Contains("nama_item"))
                dgvRiwayatStok.Columns["nama_item"].HeaderText = "ITEM";

            if (dgvRiwayatStok.Columns.Contains("jumlah"))
                dgvRiwayatStok.Columns["jumlah"].HeaderText = "JUMLAH";

            if (dgvRiwayatStok.Columns.Contains("satuan"))
                dgvRiwayatStok.Columns["satuan"].HeaderText = "SATUAN";

            if (dgvRiwayatStok.Columns.Contains("referensi"))
                dgvRiwayatStok.Columns["referensi"].HeaderText = "REFERENSI";
        }

        private void AturGridTransaksiPenjualan()
        {
            dgvTransaksiPenjualan.ReadOnly = true;
            dgvTransaksiPenjualan.AllowUserToAddRows = false;
            dgvTransaksiPenjualan.AllowUserToDeleteRows = false;
            dgvTransaksiPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksiPenjualan.MultiSelect = false;
            dgvTransaksiPenjualan.RowHeadersVisible = false;
            dgvTransaksiPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvTransaksiPenjualan.Columns.Contains("id_penjualan"))
                dgvTransaksiPenjualan.Columns["id_penjualan"].Visible = false;

            if (dgvTransaksiPenjualan.Columns.Contains("nomor_invoice"))
                dgvTransaksiPenjualan.Columns["nomor_invoice"].HeaderText = "NO CATATAN";

            if (dgvTransaksiPenjualan.Columns.Contains("tanggal_penjualan"))
                dgvTransaksiPenjualan.Columns["tanggal_penjualan"].HeaderText = "TANGGAL";

            if (dgvTransaksiPenjualan.Columns.Contains("nama_pelanggan"))
                dgvTransaksiPenjualan.Columns["nama_pelanggan"].HeaderText = "PEMBELI";

            if (dgvTransaksiPenjualan.Columns.Contains("dicatat_oleh"))
                dgvTransaksiPenjualan.Columns["dicatat_oleh"].HeaderText = "DICATAT OLEH";

            if (dgvTransaksiPenjualan.Columns.Contains("nama_produk"))
                dgvTransaksiPenjualan.Columns["nama_produk"].HeaderText = "PRODUK";

            if (dgvTransaksiPenjualan.Columns.Contains("jumlah_gram"))
                dgvTransaksiPenjualan.Columns["jumlah_gram"].HeaderText = "JUMLAH GRAM";

            if (dgvTransaksiPenjualan.Columns.Contains("harga_per_gram"))
                dgvTransaksiPenjualan.Columns["harga_per_gram"].HeaderText = "HARGA/GRAM";

            if (dgvTransaksiPenjualan.Columns.Contains("subtotal"))
                dgvTransaksiPenjualan.Columns["subtotal"].HeaderText = "SUBTOTAL";

            if (dgvTransaksiPenjualan.Columns.Contains("total_penjualan"))
                dgvTransaksiPenjualan.Columns["total_penjualan"].HeaderText = "TOTAL";
        }

        private void pnlRingkasan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
