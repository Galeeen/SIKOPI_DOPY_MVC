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
    public partial class FormDashboardPenjual : Form
    {
        private readonly PenjualController _penjualController;

        public FormDashboardPenjual()
        {
            InitializeComponent();

            _penjualController = new PenjualController();

            MuatRingkasan();
        }

        private void MuatRingkasan()
        {
            try
            {
                RingkasanPenjualan ringkasan = _penjualController.AmbilRingkasan();

                lblTransaksiHariIni.Text =
                    "Transaksi Hari Ini\r\n" +
                    ringkasan.TotalTransaksiHariIni.ToString("N0", new CultureInfo("id-ID"));

                lblOmzetHariIni.Text =
                    "Omzet Hari Ini\r\nRp " +
                    ringkasan.OmzetHariIni.ToString("N0", new CultureInfo("id-ID"));

                lblProdukTerjual.Text =
                    "Produk Terjual\r\n" +
                    ringkasan.ProdukTerjualGramHariIni.ToString("N0", new CultureInfo("id-ID")) +
                    " g";

                lblTotalTransaksi.Text =
                    "Total Transaksi\r\n" +
                    ringkasan.TotalTransaksiSemua.ToString("N0", new CultureInfo("id-ID"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Dashboard Penjual",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
