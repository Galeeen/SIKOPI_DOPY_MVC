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
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormManajemenUserAdmin : Form
    {
        private readonly ManajemenUserController _manajemenUserController;
        private readonly Pengguna _penggunaLogin;

        public FormManajemenUserAdmin(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _manajemenUserController = new ManajemenUserController();

            SambungkanEvent();
            MuatDataUser();
        }

        private void SambungkanEvent()
        {
            btnTambahUser.Click -= btnTambahUser_Click;
            btnTambahUser.Click += btnTambahUser_Click;
        }

        private void MuatDataUser()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                List<Pengguna> daftarUser = _manajemenUserController.AmbilSemuaUser();

                foreach (Pengguna pengguna in daftarUser)
                {
                    Panel card = BuatCardUser(pengguna);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private Panel BuatCardUser(Pengguna pengguna)
        {
            Panel card = new Panel
            {
                Width = 330,
                Height = 155,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 20, 20),
                BorderStyle = BorderStyle.FixedSingle,
                Tag = pengguna.Id
            };

            Label lblInisial = new Label
            {
                Text = AmbilInisial(pengguna.NamaLengkap),
                Width = 55,
                Height = 55,
                Location = new Point(22, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(225, 229, 255),
                ForeColor = Color.MediumSlateBlue,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };

            Label lblNama = new Label
            {
                Text = pengguna.NamaLengkap,
                Location = new Point(92, 24),
                Width = 150,
                Height = 48,
                Font = new Font("Segoe UI", 11, FontStyle.Bold)
            };

            Label lblUsername = new Label
            {
                Text = "@" + pengguna.NamaPengguna,
                Location = new Point(92, 72),
                Width = 180,
                Height = 24,
                ForeColor = Color.DimGray,
                Font = new Font("Segoe UI", 9)
            };

            Label lblRole = new Label
            {
                Text = AmbilLabelRole(pengguna.Peran),
                Width = 95,
                Height = 28,
                Location = new Point(220, 25),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = AmbilWarnaRoleBackground(pengguna.Peran),
                ForeColor = AmbilWarnaRoleText(pengguna.Peran),
                Font = new Font("Segoe UI", 9)
            };

            Panel garis = new Panel
            {
                Height = 1,
                Width = 285,
                Location = new Point(22, 98),
                BackColor = Color.Gainsboro
            };

            Button btnEdit = new Button
            {
                Text = "✎ Edit",
                Width = 135,
                Height = 38,
                Location = new Point(22, 110),
                BackColor = Color.FromArgb(235, 239, 255),
                ForeColor = Color.MediumSlateBlue,
                FlatStyle = FlatStyle.Flat,
                Tag = pengguna.Id
            };

            Button btnHapus = new Button
            {
                Text = "🗑 Hapus",
                Width = 135,
                Height = 38,
                Location = new Point(172, 110),
                BackColor = Color.FromArgb(255, 238, 238),
                ForeColor = Color.Red,
                FlatStyle = FlatStyle.Flat,
                Tag = pengguna.Id
            };

            btnEdit.Click += btnEdit_Click;
            btnHapus.Click += btnHapus_Click;

            card.Controls.Add(lblInisial);
            card.Controls.Add(lblNama);
            card.Controls.Add(lblUsername);
            card.Controls.Add(lblRole);
            card.Controls.Add(garis);
            card.Controls.Add(btnEdit);
            card.Controls.Add(btnHapus);

            return card;
        }

        private string AmbilInisial(string namaLengkap)
        {
            if (string.IsNullOrWhiteSpace(namaLengkap))
                return "?";

            return namaLengkap.Trim().Substring(0, 1).ToUpper();
        }

        private string AmbilLabelRole(string peran)
        {
            if (peran == "Admin")
                return "Admin";

            if (peran == "Karyawan Produksi")
                return "Roaster";

            if (peran == "Karyawan Penjual")
                return "Penjual";

            return peran;
        }

        private Color AmbilWarnaRoleBackground(string peran)
        {
            if (peran == "Admin")
                return Color.FromArgb(229, 232, 255);

            if (peran == "Karyawan Produksi")
                return Color.FromArgb(255, 240, 205);

            if (peran == "Karyawan Penjual")
                return Color.FromArgb(210, 247, 226);

            return Color.Gainsboro;
        }

        private Color AmbilWarnaRoleText(string peran)
        {
            if (peran == "Admin")
                return Color.MediumSlateBlue;

            if (peran == "Karyawan Produksi")
                return Color.DarkOrange;

            if (peran == "Karyawan Penjual")
                return Color.SeaGreen;

            return Color.Black;
        }

        private void btnTambahUser_Click(object? sender, EventArgs e)
        {
            using var form = new FormDialogUser(_manajemenUserController);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatDataUser();
            }
        }

        private void btnEdit_Click(object? sender, EventArgs e)
        {
            if (sender is not Button tombol)
                return;

            int idUser = Convert.ToInt32(tombol.Tag);

            try
            {
                Pengguna pengguna = _manajemenUserController.AmbilUserById(idUser);

                using var form = new FormDialogUser(_manajemenUserController, pengguna);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    MuatDataUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Edit User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnHapus_Click(object? sender, EventArgs e)
        {
            if (sender is not Button tombol)
                return;

            int idUser = Convert.ToInt32(tombol.Tag);

            DialogResult hasil = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus user ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (hasil != DialogResult.Yes)
                return;

            try
            {
                _manajemenUserController.HapusUser(idUser, _penggunaLogin.Id);

                MessageBox.Show(
                    "User berhasil dihapus.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MuatDataUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "User gagal dihapus. Kemungkinan user ini sudah digunakan pada data batch roasting atau penjualan.\n\nDetail: " + ex.Message,
                    "Gagal Hapus User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void label1_Click(object? sender, EventArgs e)
        {
        }
    }
}