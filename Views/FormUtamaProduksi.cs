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
    public partial class FormUtamaProduksi : Form
    {
        private readonly Pengguna _penggunaLogin;

        public FormUtamaProduksi(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;

            SambungkanEvent();
            AturProfilUser();

            TampilkanDashboardProduksi();
        }



        private void SambungkanEvent()
        {
            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnBahanBaku.Click -= btnBahanBaku_Click;
            btnBahanBaku.Click += btnBahanBaku_Click;

            btnBatchRoasting.Click -= btnBatchRoasting_Click;
            btnBatchRoasting.Click += btnBatchRoasting_Click;

            btnRiwayat.Click -= btnRiwayat_Click;
            btnRiwayat.Click += btnRiwayat_Click;

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

        private void TampilkanDashboardProduksi()
        {
            TampilkanFormDiPanel(new FormDashboardProduksi());
        }

        private void btnDashboard_Click(object? sender, EventArgs e)
        {
            TampilkanDashboardProduksi();
        }

        private void btnBahanBaku_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBahanBakuProduksi());
        }

        private void btnBatchRoasting_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBatchRoastingProduksi(_penggunaLogin));
        }

        private void btnRiwayat_Click(object? sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormRiwayatProduksi());
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
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}