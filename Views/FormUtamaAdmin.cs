using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormUtamaAdmin : Form
    {
        private readonly Pengguna _penggunaLogin;

        public FormUtamaAdmin(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;

            btnDashboard.Click -= btnDashboard_Click;
            btnDashboard.Click += btnDashboard_Click;

            btnBahanBaku.Click -= btnBahanBaku_Click;
            btnBahanBaku.Click += btnBahanBaku_Click;

            btnBatchRoasting.Click -= btnBatchRoasting_Click;
            btnBatchRoasting.Click += btnBatchRoasting_Click;

            btnKeluar.Click -= btnKeluar_Click;
            btnKeluar.Click += btnKeluar_Click;

            lblNamaUser.Text = _penggunaLogin.NamaLengkap;
            lblRole.Text = _penggunaLogin.Peran;

            TampilkanFormDiPanel(new FormDashboardAdmin());
        }

        private void TampilkanFormDiPanel(Form form)
        {
            panelKontenAdmin.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelKontenAdmin.Controls.Add(form);
            form.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormDashboardAdmin());
        }

        private void btnBahanBaku_Click(object sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBahanBakuAdmin());
        }

        private void btnBatchRoasting_Click(object sender, EventArgs e)
        {
            TampilkanFormDiPanel(new FormBatchRoastingAdmin(_penggunaLogin));
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            var konfirmasi = MessageBox.Show(
                "Yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}