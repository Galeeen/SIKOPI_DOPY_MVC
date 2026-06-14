using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormUtamaPenjual : Form
    {
        private readonly Pengguna _penggunaLogin;

        public FormUtamaPenjual(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;

            SambungkanEvent();
            AturProfilUser();

            TampilkanDashboardPenjual();
        }

        private void SambungkanEvent()
        {
            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnBahanBakuPenjual.Click -= btnBahanBakuPenjual_Click;
            btnBahanBakuPenjual.Click += btnBahanBakuPenjual_Click; 

            btnEtalase.Click -= btnEtalase_Click;
            btnEtalase.Click += btnEtalase_Click;

            btnRiwayatPenjualan.Click -= btnRiwayatPenjualan_Click;
            btnRiwayatPenjualan.Click += btnRiwayatPenjualan_Click;

            btnKeluar.Click -= btnKeluar_Click;
            btnKeluar.Click += btnKeluar_Click;
        }

        private void AturProfilUser()
        {
            lblNamaUser.Text = _penggunaLogin.NamaLengkap;
            lblRole.Text = _penggunaLogin.Peran;
        }

        private void TampilkanFormDiPanel(Form form)
        {
            pnlKonten.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlKonten.Controls.Add(form);
            form.Show();
        }

        private void TampilkanDashboardPenjual()
        {
            TampilkanFormDiPanel(new FormDashboardPenjual());
        }

        private void btnDashboard_Click(object? sender, EventArgs e)
        {
            TampilkanDashboardPenjual();
        }

        private void btnBahanBakuPenjual_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBahanBakuPenjual());
        }

        private void btnEtalase_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormEtalaseToko(_penggunaLogin));
        }

        private void btnRiwayatPenjualan_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormRiwayatPenjualan());
        }

        private void btnKeluar_Click(object? sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah kamu yakin ingin keluar?",
                "Konfirmasi Keluar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil != DialogResult.Yes)
                return;

            Close();
        }
    }
}