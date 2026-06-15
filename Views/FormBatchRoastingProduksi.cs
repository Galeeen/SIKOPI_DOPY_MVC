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
    public partial class FormBatchRoastingProduksi : Form
    {
        private readonly BatchRoastingProduksiController _batchRoastingProduksiController;
        private readonly BatchRoastingController _batchRoastingController;
        private readonly Pengguna _penggunaLogin;

        public FormBatchRoastingProduksi(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _batchRoastingProduksiController = new BatchRoastingProduksiController();
            _batchRoastingController = new BatchRoastingController(_penggunaLogin.Id);

            SambungkanEvent();
            MuatSemuaData();
        }

        private void SambungkanEvent()
        {
            btnTambahBatch.Click -= btnTambahBatch_Click;
            btnTambahBatch.Click += btnTambahBatch_Click;

            dgvBatchRoasting.CellClick -= dgvBatchRoasting_CellClick;
            dgvBatchRoasting.CellClick += dgvBatchRoasting_CellClick;
        }
        private void MuatSemuaData()
        {
            MuatBatchRoasting();
            MuatRoastBean();
        }

        private void MuatBatchRoasting()
        {
            try
            {
                dgvBatchRoasting.Columns.Clear();
                dgvBatchRoasting.DataSource = _batchRoastingProduksiController.AmbilBatchRoasting();

                AturGridBatchRoasting();
                TambahKolomAksiBatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Memuat Data Batch Roasting",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MuatRoastBean()
        {
            try
            {
                dgvRoastBean.Columns.Clear();
                dgvRoastBean.DataSource = _batchRoastingProduksiController.AmbilRoastBean();

                AturGridRoastBean();
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

        private void AturGridBatchRoasting()
        {
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.RowHeadersVisible = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvBatchRoasting.Columns.Contains("id_batch"))
                dgvBatchRoasting.Columns["id_batch"].Visible = false;

            if (dgvBatchRoasting.Columns.Contains("kode_batch"))
                dgvBatchRoasting.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvBatchRoasting.Columns.Contains("green_bean"))
                dgvBatchRoasting.Columns["green_bean"].HeaderText = "GREEN BEAN";

            if (dgvBatchRoasting.Columns.Contains("jumlah_biji_dipakai_gram"))
            {
                dgvBatchRoasting.Columns["jumlah_biji_dipakai_gram"].HeaderText = "BERAT MASUK (GRAM)";
                dgvBatchRoasting.Columns["jumlah_biji_dipakai_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchRoasting.Columns.Contains("hasil_roasting_gram"))
            {
                dgvBatchRoasting.Columns["hasil_roasting_gram"].HeaderText = "BERAT KELUAR (GRAM)";
                dgvBatchRoasting.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvBatchRoasting.Columns.Contains("level_roasting"))
                dgvBatchRoasting.Columns["level_roasting"].HeaderText = "LEVEL ROASTING";

            if (dgvBatchRoasting.Columns.Contains("tanggal_batch"))
            {
                dgvBatchRoasting.Columns["tanggal_batch"].HeaderText = "TANGGAL BATCH";
                dgvBatchRoasting.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvBatchRoasting.Columns.Contains("catatan"))
                dgvBatchRoasting.Columns["catatan"].HeaderText = "CATATAN";
        }

        private void TambahKolomAksiBatch()
        {
            if (dgvBatchRoasting.Columns.Contains("colEdit"))
                dgvBatchRoasting.Columns.Remove("colEdit");

            if (dgvBatchRoasting.Columns.Contains("colHapus"))
                dgvBatchRoasting.Columns.Remove("colHapus");

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

            dgvBatchRoasting.Columns.Add(colEdit);
            dgvBatchRoasting.Columns.Add(colHapus);

            dgvBatchRoasting.Columns["colEdit"].DisplayIndex = dgvBatchRoasting.Columns.Count - 2;
            dgvBatchRoasting.Columns["colHapus"].DisplayIndex = dgvBatchRoasting.Columns.Count - 1;
        }

        private void AturGridRoastBean()
        {
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvRoastBean.Columns.Contains("id_roasted"))
                dgvRoastBean.Columns["id_roasted"].Visible = false;

            if (dgvRoastBean.Columns.Contains("kode_batch"))
                dgvRoastBean.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvRoastBean.Columns.Contains("nama_produk"))
                dgvRoastBean.Columns["nama_produk"].HeaderText = "NAMA PRODUK";

            if (dgvRoastBean.Columns.Contains("level_roasting"))
                dgvRoastBean.Columns["level_roasting"].HeaderText = "LEVEL ROASTING";

            if (dgvRoastBean.Columns.Contains("hasil_roasting_gram"))
            {
                dgvRoastBean.Columns["hasil_roasting_gram"].HeaderText = "HASIL ROASTING (GRAM)";
                dgvRoastBean.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("stok_gram"))
            {
                dgvRoastBean.Columns["stok_gram"].HeaderText = "STOK GRAM";
                dgvRoastBean.Columns["stok_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("harga_per_gram"))
            {
                dgvRoastBean.Columns["harga_per_gram"].HeaderText = "HARGA/GRAM";
                dgvRoastBean.Columns["harga_per_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvRoastBean.Columns.Contains("status_harga"))
                dgvRoastBean.Columns["status_harga"].HeaderText = "STATUS HARGA";

            if (dgvRoastBean.Columns.Contains("tanggal_batch"))
            {
                dgvRoastBean.Columns["tanggal_batch"].HeaderText = "TANGGAL BATCH";
                dgvRoastBean.Columns["tanggal_batch"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvRoastBean.Columns.Contains("catatan"))
                dgvRoastBean.Columns["catatan"].HeaderText = "CATATAN";
        }



        private void btnTambahBatch_Click(object? sender, EventArgs e)
        {
            using var form = new FormDialogBatchRoasting(_penggunaLogin);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatSemuaData();
            }
        }

        private void dgvBatchRoasting_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string namaKolom = dgvBatchRoasting.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colEdit" && namaKolom != "colHapus")
                return;

            if (!dgvBatchRoasting.Columns.Contains("id_batch"))
            {
                MessageBox.Show(
                    "Kolom id_batch tidak ditemukan.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int idBatch = Convert.ToInt32(
                dgvBatchRoasting.Rows[e.RowIndex].Cells["id_batch"].Value
            );

            if (namaKolom == "colEdit")
            {
                EditBatch(idBatch);
            }
            else if (namaKolom == "colHapus")
            {
                HapusBatch(idBatch);
            }
        }

        private void EditBatch(int idBatch)
        {
            using var form = new FormDialogBatchRoasting(_penggunaLogin, idBatch);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatSemuaData();
            }
        }

        private void HapusBatch(int idBatch)
        {
            DialogResult hasil = MessageBox.Show(
                "Yakin ingin menghapus batch roasting ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (hasil != DialogResult.Yes)
                return;

            try
            {
                _batchRoastingController.HapusBatch(idBatch);

                MessageBox.Show(
                    "Batch roasting berhasil dihapus.",
                    "Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MuatSemuaData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Menghapus Batch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}