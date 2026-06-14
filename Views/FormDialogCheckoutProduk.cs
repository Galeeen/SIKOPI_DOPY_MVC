using System;
using System.Globalization;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormDialogCheckoutProduk : Form
    {
        private readonly RoastBean _produk;
        private readonly Pengguna _penggunaLogin;
        private readonly PenjualanController _penjualanController;

        public FormDialogCheckoutProduk(RoastBean produk, Pengguna penggunaLogin)
        {
            InitializeComponent();

            _produk = produk;
            _penggunaLogin = penggunaLogin;
            _penjualanController = new PenjualanController();

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            btnBayar.Click -= btnBayar_Click;
            btnBayar.Click += btnBayar_Click;

            numJumlahGram.ValueChanged -= numJumlahGram_ValueChanged;
            numJumlahGram.ValueChanged += numJumlahGram_ValueChanged;

            MuatProduk();
            HitungTotal();
        }

        private void MuatProduk()
        {
            Text = "Catat Pembelian Produk";

            lblJudul.Text = "Catat Pembelian Produk";
            lblProduk.Text = _produk.NamaProduk;

            lblInfoProduk.Text =
                $"Rp {_produk.HargaPerGram.ToString("N0", new CultureInfo("id-ID"))}/g • " +
                $"Stok: {_produk.StokGram.ToString("N0", new CultureInfo("id-ID"))}g";

            btnBayar.Text = "Catat Pembelian";

     
            numJumlahGram.Enabled = true;
            btnBayar.Enabled = true;

            numJumlahGram.DecimalPlaces = 4;
            numJumlahGram.ThousandsSeparator = true;
            numJumlahGram.Minimum = 0.01M;
            numJumlahGram.Maximum = 100000;
            numJumlahGram.Increment = 0.01M;
            decimal stokTersedia = _produk.StokGram;

            if (stokTersedia <= 0)
            {
                numJumlahGram.Value = 0.01M;
                numJumlahGram.Enabled = false;
                btnBayar.Enabled = false;

                lblTotal.Text = "Rp 0";
                return;
            }

            numJumlahGram.Maximum = stokTersedia;

            if (stokTersedia >= 100)
                numJumlahGram.Value = 100;
            else
                numJumlahGram.Value = stokTersedia;
        }

        private void numJumlahGram_ValueChanged(object? sender, EventArgs e)
        {
            HitungTotal();
        }

        private void HitungTotal()
        {
            decimal jumlahGram = numJumlahGram.Value;
            decimal total = jumlahGram * _produk.HargaPerGram;

            lblTotal.Text = "Rp " + total.ToString("N0", new CultureInfo("id-ID"));
        }

        private void btnBayar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNamaPembeli.Text))
                    throw new Exception("Nama pembeli wajib diisi.");

                decimal jumlahGram = numJumlahGram.Value;

                if (jumlahGram <= 0)
                    throw new Exception("Jumlah pembelian harus lebih dari 0 gram.");

                if (_produk.StokGram <= 0)
                    throw new Exception("Stok produk ini sudah habis.");

                if (jumlahGram > _produk.StokGram)
                    throw new Exception(
                        $"Jumlah pembelian melebihi stok tersedia. " +
                        $"Stok tersedia: {_produk.StokGram.ToString("N0", new CultureInfo("id-ID"))}g."
                    );

                var pembelian = new PembelianProduk
                {
                    IdRoasted = _produk.Id,
                    IdPengguna = _penggunaLogin.Id,
                    NamaPembeli = txtNamaPembeli.Text.Trim(),
                    JumlahGram = jumlahGram
                };

                string nomorCatatan = _penjualanController.ProsesPembelian(pembelian);

                MessageBox.Show(
                    "Pembelian berhasil dicatat.\nNomor catatan: " + nomorCatatan,
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Mencatat Pembelian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}