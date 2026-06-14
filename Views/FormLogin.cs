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

                if (pengguna.Peran != "Admin")
                {
                    MessageBox.Show(
                        "Untuk tahap ini hanya role Admin yang bisa masuk.",
                        "Akses Ditolak",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                FormUtamaAdmin formUtamaAdmin = new FormUtamaAdmin(pengguna);
                formUtamaAdmin.FormClosed += (s, args) => this.Close();

                this.Hide();
                formUtamaAdmin.Show();

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
