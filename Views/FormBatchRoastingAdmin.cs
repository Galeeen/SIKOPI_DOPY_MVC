using System;
using System.Data;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormBatchRoastingAdmin : Form
    {
        private readonly Pengguna _penggunaLogin;
        private readonly BatchRoastingController _batchRoastingController;
        private readonly BahanBakuController _bahanBakuController;

        public FormBatchRoastingAdmin(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _batchRoastingController = new BatchRoastingController(_penggunaLogin.Id);
            _bahanBakuController = new BahanBakuController();

            btnTambahBatch.Click -= btnTambahBatch_Click;
            btnTambahBatch.Click += btnTambahBatch_Click;

            dgvBatchRoasting.CellClick -= dgvBatchRoasting_CellClick;
            dgvBatchRoasting.CellClick += dgvBatchRoasting_CellClick;

            MuatDataGreenBean();
            MuatDataBatch();
        }

        private void MuatDataBatch()
        {
            try
            {
                dgvBatchRoasting.Columns.Clear();
                dgvBatchRoasting.DataSource = _batchRoastingController.AmbilSemuaBatch();

                AturKolomGrid();
                TambahKolomAksi();
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

      
        private void AturKolomGrid()
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

            if (dgvGreenBean.Columns.Contains("id_batch"))
                dgvGreenBean.Columns["id_batch"].Visible = false;

            if (dgvGreenBean.Columns.Contains("kode_batch"))
                dgvGreenBean.Columns["kode_batch"].HeaderText = "KODE BATCH";

            if (dgvGreenBean.Columns.Contains("green_bean"))
            {
                dgvGreenBean.Columns["green_bean"].HeaderText = "GREEN BEAN";
            }

            if (dgvGreenBean.Columns.Contains("jumlah_biji_dipakai_gram"))
            {
                dgvGreenBean.Columns["jumlah_biji_dipakai_gram"].HeaderText = "BIJI MASUK (GRAM)";
                dgvGreenBean.Columns["jumlah_biji_dipakai_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvGreenBean.Columns.Contains("hasil_roasting_gram"))
            {
                dgvGreenBean.Columns["hasil_roasting_gram"].HeaderText = "BERAT KELUAR (GRAM)";
                dgvGreenBean.Columns["hasil_roasting_gram"].DefaultCellStyle.Format = "N0";
            }

            if (dgvGreenBean.Columns.Contains("level_roasting"))
                dgvGreenBean.Columns["level_roasting"].HeaderText = "LEVEL ROASTING";

            if (dgvGreenBean.Columns.Contains("tanggal_batch"))
                dgvGreenBean.Columns["tanggal_batch"].HeaderText = "TANGGAL";

            if (dgvGreenBean.Columns.Contains("catatan"))
                dgvGreenBean.Columns["catatan"].HeaderText = "CATATAN";
        }

        private void TambahKolomAksi()
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

        private void btnTambahBatch_Click(object sender, EventArgs e)
        {
            using var form = new FormDialogBatchRoasting(_penggunaLogin);

            if (form.ShowDialog() == DialogResult.OK)
            {
                MuatDataBatch();
            }
        }

        private void dgvBatchRoasting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string namaKolom = dgvGreenBean.Columns[e.ColumnIndex].Name;

            if (namaKolom != "colEdit" && namaKolom != "colHapus")
                return;

            if (!dgvGreenBean.Columns.Contains("id_batch"))
            {
                MessageBox.Show(
                    "Kolom id_batch tidak ditemukan. Periksa query AmbilSemua di RepositoriBatchRoasting.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int idBatch = Convert.ToInt32(
                dgvGreenBean.Rows[e.RowIndex].Cells["id_batch"].Value
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
                MuatDataBatch();
            }
        }

        private void HapusBatch(int idBatch)
        {
            var konfirmasi = MessageBox.Show(
                "Yakin ingin menghapus batch roasting ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (konfirmasi != DialogResult.Yes)
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

                MuatDataBatch();
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

        private void MuatDataGreenBean()
        {
            try
            {
                dgvGreenBean.Columns.Clear();
                dgvGreenBean.DataSource = _bahanBakuController.AmbilSemuaGreenBean();

                AturKolomGridGreenBean();
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
                dgvGreenBean.Columns["nama_biji"].HeaderText = "NAMA BIJI";

            if (dgvGreenBean.Columns.Contains("asal_daerah"))
                dgvGreenBean.Columns["asal_daerah"].HeaderText = "ASAL";

            if (dgvGreenBean.Columns.Contains("jenis"))
                dgvGreenBean.Columns["jenis"].HeaderText = "JENIS";

            if (dgvGreenBean.Columns.Contains("jenis_biji"))
                dgvGreenBean.Columns["jenis_biji"].HeaderText = "JENIS";

            if (dgvGreenBean.Columns.Contains("metode_proses"))
                dgvGreenBean.Columns["metode_proses"].HeaderText = "PROSES";

            if (dgvGreenBean.Columns.Contains("ketinggian_mdpl"))
                dgvGreenBean.Columns["ketinggian_mdpl"].HeaderText = "KETINGGIAN";

            if (dgvGreenBean.Columns.Contains("tingkat_kualitas"))
                dgvGreenBean.Columns["tingkat_kualitas"].HeaderText = "GRADE";

            if (dgvGreenBean.Columns.Contains("stok_kg"))
            {
                dgvGreenBean.Columns["stok_kg"].HeaderText = "STOK KG";
                dgvGreenBean.Columns["stok_kg"].DefaultCellStyle.Format = "N2";
            }

            if (dgvGreenBean.Columns.Contains("harga_per_kg"))
            {
                dgvGreenBean.Columns["harga_per_kg"].HeaderText = "HARGA/KG";
                dgvGreenBean.Columns["harga_per_kg"].DefaultCellStyle.Format = "N0";
            }

            if (dgvGreenBean.Columns.Contains("tanggal_panen"))
            {
                dgvGreenBean.Columns["tanggal_panen"].HeaderText = "TANGGAL PANEN";
                dgvGreenBean.Columns["tanggal_panen"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }


        private void dgvBatchRoasting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgRoastBean_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}