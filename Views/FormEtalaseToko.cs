using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormEtalaseToko : Form
    {
        private readonly Pengguna _penggunaLogin;
        private readonly RoastBeanController _roastBeanController;

        public FormEtalaseToko(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _roastBeanController = new RoastBeanController();

            MuatProdukEtalase();
        }

        private void MuatProdukEtalase()
        {
            try
            {
                flpProduk.Controls.Clear();

                List<RoastBean> produkList = _roastBeanController.AmbilProdukEtalase();

                if (produkList.Count == 0)
                {
                    TampilkanPesanKosong();
                    return;
                }

                foreach (RoastBean produk in produkList)
                {
                    Panel card = BuatCardProduk(produk);
                    flpProduk.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Etalase",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void TampilkanPesanKosong()
        {
            var lblKosong = new Label
            {
                Text = "Belum ada produk siap jual.\nInput harga roast bean terlebih dahulu di menu Bahan Baku > Roast Bean.",
                AutoSize = false,
                Width = 800,
                Height = 100,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                ForeColor = Color.DimGray,
                Margin = new Padding(10)
            };

            flpProduk.Controls.Add(lblKosong);
        }

        private Panel BuatCardProduk(RoastBean produk)
        {
            var card = new Panel
            {
                Width = 270,
                Height = 270,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(12),
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblIcon = new Label
            {
                Text = "☕",
                Font = new Font("Segoe UI Emoji", 24F, FontStyle.Regular),
                AutoSize = false,
                Width = 245,
                Height = 55,
                Location = new Point(12, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(180, 83, 9),
                ForeColor = Color.FromArgb(254, 243, 199)
            };

            var lblNama = new Label
            {
                Text = produk.NamaProduk,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                AutoSize = false,
                Width = 245,
                Height = 42,
                Location = new Point(12, 75)
            };

            var lblAsalBatch = new Label
            {
                Text = produk.AsalDaerah + " • " + produk.KodeBatch,
                AutoSize = false,
                Width = 245,
                Height = 24,
                Location = new Point(12, 116),
                ForeColor = Color.DimGray
            };

            var lblCatatan = new Label
            {
                Text = string.IsNullOrWhiteSpace(produk.Catatan) ? "-" : "\"" + produk.Catatan + "\"",
                AutoSize = false,
                Width = 245,
                Height = 28,
                Location = new Point(12, 142),
                ForeColor = Color.DimGray,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic)
            };

            var lblStokTitle = new Label
            {
                Text = "Stok",
                AutoSize = false,
                Width = 90,
                Height = 20,
                Location = new Point(12, 176),
                ForeColor = Color.Gray
            };

            var lblStok = new Label
            {
                Text = produk.StokGram.ToString("0.##", CultureInfo.InvariantCulture) + "g",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = false,
                Width = 90,
                Height = 24,
                Location = new Point(12, 198)
            };

            var lblHargaTitle = new Label
            {
                Text = "Harga",
                AutoSize = false,
                Width = 120,
                Height = 20,
                Location = new Point(136, 176),
                ForeColor = Color.Gray,
                TextAlign = ContentAlignment.TopRight
            };

            var lblHarga = new Label
            {
                Text = "Rp " + produk.HargaPerGram.ToString("N0", new CultureInfo("id-ID")) + "/g",
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Color.FromArgb(79, 70, 229),
                AutoSize = false,
                Width = 120,
                Height = 24,
                Location = new Point(136, 198),
                TextAlign = ContentAlignment.TopRight
            };

            var btnBeli = new Button
            {
                Text = "Beli Produk Ini",
                Width = 245,
                Height = 34,
                Location = new Point(12, 226),
                BackColor = Color.FromArgb(79, 70, 229),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Tag = produk
            };

            btnBeli.FlatAppearance.BorderSize = 0;
            btnBeli.Click += btnBeliProduk_Click;

            card.Controls.Add(lblIcon);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblAsalBatch);
            card.Controls.Add(lblCatatan);
            card.Controls.Add(lblStokTitle);
            card.Controls.Add(lblStok);
            card.Controls.Add(lblHargaTitle);
            card.Controls.Add(lblHarga);
            card.Controls.Add(btnBeli);

            return card;
        }

        private void btnBeliProduk_Click(object? sender, EventArgs e)
        {
            if (sender is not Button tombol)
                return;

            if (tombol.Tag is not RoastBean produk)
                return;

            using var form = new FormDialogCheckoutProduk(produk, _penggunaLogin);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatProdukEtalase();
            }
        }
    }
}