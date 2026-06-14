using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormLogin : Form
    {
        private readonly AuthController _authController;

        public FormLogin()
        {
            InitializeComponent();
            _authController = new AuthController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblPesan.Text = "";

                Pengguna pengguna = _authController.Login(
                    txtUsername.Text.Trim(),
                    txtPassword.Text
                    );


             

                if (pengguna.Peran == "Admin")
                {
                    FormUtamaAdmin formAdmin = new FormUtamaAdmin(pengguna);
                    formAdmin.Show();
                    Hide();
                }
                else if (pengguna.Peran == "Karyawan Produksi")
                {
                    FormUtamaProduksi formProduksi = new FormUtamaProduksi(pengguna);
                    formProduksi.Show();
                    Hide();
                }
                else if (pengguna.Peran == "Karyawan Penjual")
                {
                    MessageBox.Show(
                        "Role Karyawan Penjual belum dibuat.",
                        "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Role tidak dikenali: " + pengguna.Peran,
                        "Gagal Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
               

            }
            catch (Exception ex)
            {
                lblPesan.Text = ex.Message;
            }

        }

        private void pnlKiri_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
