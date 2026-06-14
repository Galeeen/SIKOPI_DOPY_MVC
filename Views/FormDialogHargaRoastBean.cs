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
    public partial class FormDialogHargaRoastBean : Form
    {
        private readonly RoastBeanController _roastBeanController;
        private readonly int _idRoasted;

        public FormDialogHargaRoastBean(int idRoasted)
        {
            InitializeComponent();

            _roastBeanController = new RoastBeanController();
            _idRoasted = idRoasted;

            btnSimpan.Click -= btnSimpan_Click;
            btnSimpan.Click += btnSimpan_Click;

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            MuatData();
        }

        private void MuatData()
        {
            RoastBean roastBean = _roastBeanController.AmbilRoastBeanById(_idRoasted);

            lblNamaProduk.Text = "Produk: " + roastBean.NamaProduk;
            txtHargaPerGram.Text = roastBean.HargaPerGram.ToString(CultureInfo.InvariantCulture);
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                decimal hargaPerGram = AmbilDecimal(txtHargaPerGram.Text, "Harga per gram");

                _roastBeanController.UbahHargaRoastBean(_idRoasted, hargaPerGram);

                MessageBox.Show(
                    "Harga roast bean berhasil disimpan. Produk akan tampil di Etalase Toko.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Menyimpan Harga",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal AmbilDecimal(string teks, string namaField)
        {
            teks = teks.Replace(",", ".");

            if (!decimal.TryParse(
                    teks,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal nilai))
            {
                throw new Exception($"{namaField} harus berupa angka.");
            }

            if (nilai <= 0)
                throw new Exception($"{namaField} harus lebih dari 0.");

            return nilai;
        }
    }
}
