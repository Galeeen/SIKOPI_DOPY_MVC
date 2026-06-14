using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormBahanBakuAdmin : Form
    {
        private readonly BahanBakuController _bahanBakuController;
        private readonly RoastBeanController _roastBeanController;

        public FormBahanBakuAdmin()
        {
            InitializeComponent();

            _bahanBakuController = new BahanBakuController();
            _roastBeanController = new RoastBeanController();

            btnTambahGreenBean.Click -= btnTambahGreenBean_Click;
            btnTambahGreenBean.Click += btnTambahGreenBean_Click;

            dgvGreenBean.CellClick -= dgvGreenBean_CellClick;
            dgvGreenBean.CellClick += dgvGreenBean_CellClick;

            dgvRoastBean.CellClick -= dgvRoastBean_CellClick;
            dgvRoastBean.CellClick += dgvRoastBean_CellClick;

            tabBahanBaku.SelectedIndexChanged -= tabBahanBaku_SelectedIndexChanged;
            tabBahanBaku.SelectedIndexChanged += tabBahanBaku_SelectedIndexChanged;

            MuatDataGreenBean();
        }

        private void FormBahanBakuAdmin_Load(object? sender, EventArgs e)
        {
            MuatDataGreenBean();
        }

        private void tabBahanBaku_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabBahanBaku.SelectedTab == tabGreenBean)
            {
                MuatDataGreenBean();
            }
            else if (tabBahanBaku.SelectedTab == tabRoastBean)
            {
                MuatDataRoastBean();
            }
        }

        // =========================
        // GREEN BEAN
        // =========================

        private void MuatDataGreenBean()
        {
            try
            {
                dgvGreenBean.Columns.Clear();
                dgvGreenBean.DataSource = _bahanBakuController.AmbilSemuaGreenBean();

                AturKolomGridGreenBean();
                TambahKolomAksiGreenBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Data Green Bean",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturKolomGridGreenBean()
        {
            if (dgvGreenBean.Columns.Count == 0)
                return;

            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.MultiSelect = false;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvGreenBean.Columns.Contains("id_biji_mentah"))
                dgvGreenBean.Columns["id_biji_mentah"].Visible = false;

            if (dgvGreenBean.Columns.Contains("nama_biji"))
                dgvGreenBean.Columns["nama_biji"].HeaderText = "NAMA";

            if (dgvGreenBean.Columns.Contains("asal_daerah"))
                dgvGreenBean.Columns["asal_daerah"].HeaderText = "ASAL";

            if (dgvGreenBean.Columns.Contains("jenis"))
                dgvGreenBean.Columns["jenis"].HeaderText = "JENIS";

            if (dgvGreenBean.Columns.Contains("ketinggian_mdpl"))
                dgvGreenBean.Columns["ketinggian_mdpl"].HeaderText = "KETINGGIAN";

            if (dgvGreenBean.Columns.Contains("metode_proses"))
                dgvGreenBean.Columns["metode_proses"].HeaderText = "PROSES";

            if (dgvGreenBean.Columns.Contains("tingkat_kualitas"))
                dgvGreenBean.Columns["tingkat_kualitas"].HeaderText = "GRADE";

            if (dgvGreenBean.Columns.Contains("stok_kg"))
                dgvGreenBean.Columns["stok_kg"].HeaderText = "STOK KG";

            if (dgvGreenBean.Columns.Contains("harga_per_kg"))
                dgvGreenBean.Columns["harga_per_kg"].HeaderText = "HARGA/KG";

            if (dgvGreenBean.Columns.Contains("tanggal_panen"))
                dgvGreenBean.Columns["tanggal_panen"].HeaderText = "PANEN";
        }

        private void TambahKolomAksiGreenBean()
        {
            if (dgvGreenBean.Columns.Contains("colEdit"))
                dgvGreenBean.Columns.Remove("colEdit");

            if (dgvGreenBean.Columns.Contains("colHapus"))
                dgvGreenBean.Columns.Remove("colHapus");

            var colEdit = new DataGridViewButtonColumn
            {
                Name = "colEdit",
                HeaderText = "",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 80
            };

            var colHapus = new DataGridViewButtonColumn
            {
                Name = "colHapus",
                HeaderText = "",
                Text = "Hapus",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 80
            };

            dgvGreenBean.Columns.Add(colEdit);
            dgvGreenBean.Columns.Add(colHapus);

            dgvGreenBean.Columns["colEdit"].DisplayIndex = dgvGreenBean.Columns.Count - 2;
            dgvGreenBean.Columns["colHapus"].DisplayIndex = dgvGreenBean.Columns.Count - 1;
        }

        private void btnTambahGreenBean_Click(object? sender, EventArgs e)
        {
            using var form = new FormDialogGreenBean();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatDataGreenBean();
            }
        }

        private void dgvGreenBean_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string namaKolom = dgvGreenBean.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colEdit" && namaKolom != "colHapus")
                return;

            if (!dgvGreenBean.Columns.Contains("id_biji_mentah"))
            {
                MessageBox.Show(
                    "Kolom id_biji_mentah tidak ditemukan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int idBijiMentah = Convert.ToInt32(
                dgvGreenBean.Rows[e.RowIndex].Cells["id_biji_mentah"].Value
            );

            if (namaKolom == "colEdit")
            {
                EditGreenBean(idBijiMentah);
            }
            else if (namaKolom == "colHapus")
            {
                HapusGreenBean(idBijiMentah);
            }
        }

        private void EditGreenBean(int idBijiMentah)
        {
            using var form = new FormDialogGreenBean(idBijiMentah);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatDataGreenBean();
            }
        }

        private void HapusGreenBean(int idBijiMentah)
        {
            var konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus data green bean ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
                return;

            try
            {
                _bahanBakuController.HapusGreenBean(idBijiMentah);

                MessageBox.Show(
                    "Data green bean berhasil dihapus dari tampilan.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MuatDataGreenBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Menghapus",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =========================
        // ROAST BEAN
        // =========================

        private void MuatDataRoastBean()
        {
            try
            {
                dgvRoastBean.Columns.Clear();
                dgvRoastBean.DataSource = _roastBeanController.AmbilSemuaRoastBean();

                AturKolomGridRoastBean();
                TambahKolomAksiRoastBean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Data Roast Bean",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void AturKolomGridRoastBean()
        {
            if (dgvRoastBean.Columns.Count == 0)
                return;

            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRoastBean.Columns.Contains("id_roasted"))
                dgvRoastBean.Columns["id_roasted"].Visible = false;

            if (dgvRoastBean.Columns.Contains("nama_produk"))
                dgvRoastBean.Columns["nama_produk"].HeaderText = "PRODUK";

            if (dgvRoastBean.Columns.Contains("kode_batch"))
                dgvRoastBean.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvRoastBean.Columns.Contains("asal_daerah"))
                dgvRoastBean.Columns["asal_daerah"].HeaderText = "ASAL";

            if (dgvRoastBean.Columns.Contains("stok_gram"))
                dgvRoastBean.Columns["stok_gram"].HeaderText = "STOK GRAM";

            if (dgvRoastBean.Columns.Contains("harga_per_gram"))
                dgvRoastBean.Columns["harga_per_gram"].HeaderText = "HARGA / GRAM";

            if (dgvRoastBean.Columns.Contains("status_harga"))
                dgvRoastBean.Columns["status_harga"].HeaderText = "STATUS";

            if (dgvRoastBean.Columns.Contains("level_roasting"))
                dgvRoastBean.Columns["level_roasting"].HeaderText = "ROAST LEVEL";

            if (dgvRoastBean.Columns.Contains("catatan"))
                dgvRoastBean.Columns["catatan"].HeaderText = "CATATAN";
        }

        private void TambahKolomAksiRoastBean()
        {
            if (dgvRoastBean.Columns.Contains("colHarga"))
                dgvRoastBean.Columns.Remove("colHarga");

            var colHarga = new DataGridViewButtonColumn
            {
                Name = "colHarga",
                HeaderText = "",
                Text = "Input/Ubah Harga",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = 130
            };

            dgvRoastBean.Columns.Add(colHarga);
            dgvRoastBean.Columns["colHarga"].DisplayIndex = dgvRoastBean.Columns.Count - 1;
        }

        private void dgvRoastBean_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string namaKolom = dgvRoastBean.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colHarga")
                return;

            if (!dgvRoastBean.Columns.Contains("id_roasted"))
            {
                MessageBox.Show(
                    "Kolom id_roasted tidak ditemukan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int idRoasted = Convert.ToInt32(
                dgvRoastBean.Rows[e.RowIndex].Cells["id_roasted"].Value
            );

            using var form = new FormDialogHargaRoastBean(idRoasted);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatDataRoastBean();
            }
        }
    }
}