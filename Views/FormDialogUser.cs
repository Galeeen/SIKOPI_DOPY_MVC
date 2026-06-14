using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormDialogUser : Form
    {
        private readonly ManajemenUserController _manajemenUserController;
        private readonly Pengguna? _penggunaEdit;
        private readonly bool _modeEdit;

        public FormDialogUser(ManajemenUserController manajemenUserController)
        {
            InitializeComponent();

            _manajemenUserController = manajemenUserController;
            _penggunaEdit = null;
            _modeEdit = false;

            SambungkanEvent();
            MuatRole();
            AturModeTambah();
        }

        public FormDialogUser(ManajemenUserController manajemenUserController, Pengguna pengguna)
        {
            InitializeComponent();

            _manajemenUserController = manajemenUserController;
            _penggunaEdit = pengguna;
            _modeEdit = true;

            SambungkanEvent();
            MuatRole();
            AturModeEdit();
        }

        private void SambungkanEvent()
        {
            btnSimpan.Click -= btnSimpan_Click;
            btnSimpan.Click += btnSimpan_Click;

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;
        }

        private void MuatRole()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Karyawan Produksi");
            cmbRole.Items.Add("Karyawan Penjual");
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cmbRole.Items.Count > 0)
                cmbRole.SelectedIndex = 0;
        }

        private void AturModeTambah()
        {
            Text = "Tambah User";
            lblJudul.Text = "Tambah User";
            lblPassword.Text = "Password";

            txtNamaLengkap.UseSystemPasswordChar = false;
            txtUsername.UseSystemPasswordChar = false;
            txtPassword.UseSystemPasswordChar = false;

            txtNamaLengkap.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            cmbRole.SelectedIndex = 0;
        }

        private void AturModeEdit()
        {
            if (_penggunaEdit == null)
                return;

            Text = "Edit User";
            lblJudul.Text = "Edit User";
            lblPassword.Text = "Password (kosongkan jika tidak diubah)";

            txtNamaLengkap.UseSystemPasswordChar = false;
            txtUsername.UseSystemPasswordChar = false;
            txtPassword.UseSystemPasswordChar = false;

            txtNamaLengkap.Text = _penggunaEdit.NamaLengkap;
            txtUsername.Text = _penggunaEdit.NamaPengguna;
            txtPassword.Clear();

            int indexRole = cmbRole.Items.IndexOf(_penggunaEdit.Peran);
            cmbRole.SelectedIndex = indexRole >= 0 ? indexRole : 0;
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            try
            {
                Pengguna pengguna = new Pengguna
                {
                    Id = _penggunaEdit?.Id ?? 0,
                    NamaLengkap = txtNamaLengkap.Text.Trim(),
                    NamaPengguna = txtUsername.Text.Trim(),
                    KataSandi = txtPassword.Text.Trim(),
                    Peran = cmbRole.SelectedItem?.ToString() ?? ""
                };

                if (_modeEdit)
                {
                    bool ubahPassword = !string.IsNullOrWhiteSpace(txtPassword.Text);
                    _manajemenUserController.UbahUser(pengguna, ubahPassword);
                }
                else
                {
                    _manajemenUserController.TambahUser(pengguna);
                }

                MessageBox.Show(
                    "Data user berhasil disimpan.",
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
                    "Gagal Simpan User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}