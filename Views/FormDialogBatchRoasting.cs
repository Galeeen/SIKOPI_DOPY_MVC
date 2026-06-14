using System;
using System.Globalization;
using System.Windows.Forms;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormDialogBatchRoasting : Form
    {
        private readonly Pengguna _penggunaLogin;
        private readonly BatchRoastingController _batchRoastingController;
        private readonly IRepositoriLookup _repositoriLookup;
        private readonly int? _idBatch;

        private string _kodeBatchLama = "";

        public FormDialogBatchRoasting(Pengguna penggunaLogin)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _batchRoastingController = new BatchRoastingController(_penggunaLogin.Id);
            _repositoriLookup = new RepositoriLookup();
            _idBatch = null;

            SambungkanEvent();
            MuatComboBox();
            AturModeForm();
        }

        public FormDialogBatchRoasting(Pengguna penggunaLogin, int idBatch)
        {
            InitializeComponent();

            _penggunaLogin = penggunaLogin;
            _batchRoastingController = new BatchRoastingController(_penggunaLogin.Id);
            _repositoriLookup = new RepositoriLookup();
            _idBatch = idBatch;

            SambungkanEvent();
            MuatComboBox();
            AturModeForm();
        }

        private void SambungkanEvent()
        {
            btnSimpan.Click -= btnSimpan_Click;
            btnSimpan.Click += btnSimpan_Click;

            btnBatal.Click -= btnBatal_Click;
            btnBatal.Click += btnBatal_Click;

            cmbGreenBean.SelectedIndexChanged -= cmbGreenBean_SelectedIndexChanged;
            cmbGreenBean.SelectedIndexChanged += cmbGreenBean_SelectedIndexChanged;
        }

        private void MuatComboBox()
        {
            cmbGreenBean.DisplayMember = "Nama";
            cmbGreenBean.ValueMember = "Id";
            cmbGreenBean.DataSource = _repositoriLookup.AmbilGreenBeanAktifDetail();

            cmbLevelRoasting.Items.Clear();
            cmbLevelRoasting.Items.Add("Light Roast");
            cmbLevelRoasting.Items.Add("Medium Roast");
            cmbLevelRoasting.Items.Add("Medium Dark Roast");
            cmbLevelRoasting.Items.Add("Dark Roast");

            if (cmbLevelRoasting.Items.Count > 0)
                cmbLevelRoasting.SelectedIndex = 1;

            TampilkanInfoGreenBean();
        }

        private void AturModeForm()
        {
            if (_idBatch.HasValue)
            {
                this.Text = "Edit Batch Roasting";
                btnSimpan.Text = "Update";

                MuatDataEdit(_idBatch.Value);
            }
            else
            {
                this.Text = "Tambah Batch Roasting";
                btnSimpan.Text = "Simpan";

                txtJumlahBijiDipakaiKg.Text = "0";
                txtHasilRoastingGram.Text = "0";
                txtCatatan.Text = "";
                dtpTanggalBatch.Value = DateTime.Now;
            }
        }

        private void MuatDataEdit(int idBatch)
        {
            BatchRoasting batch = _batchRoastingController.AmbilBatchById(idBatch);

            _kodeBatchLama = batch.KodeBatch;

            txtJumlahBijiDipakaiKg.Text = batch.JumlahBijiDipakaiKg.ToString(CultureInfo.InvariantCulture);
            txtHasilRoastingGram.Text = batch.HasilRoastingGram.ToString(CultureInfo.InvariantCulture);
            txtCatatan.Text = batch.Catatan;

            cmbGreenBean.SelectedValue = batch.IdBijiMentah;
            cmbGreenBean.Enabled = false;

            cmbLevelRoasting.Text = batch.LevelRoasting;
            dtpTanggalBatch.Value = batch.TanggalBatch;

            lblInfoGreenBean.Text = "Green bean tidak bisa diganti saat edit.";
        }

        private void cmbGreenBean_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanInfoGreenBean();
        }

        private void TampilkanInfoGreenBean()
        {
            if (cmbGreenBean.SelectedItem is GreenBeanLookupItem item)
            {
                lblInfoGreenBean.Text =
                    $"Tersedia: {item.StokKg:0.##} Kg • {item.AsalDaerah} • {item.MetodeProses}";
            }
            else
            {
                lblInfoGreenBean.Text = "Tersedia: -";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbGreenBean.SelectedValue == null)
                    throw new Exception("Green bean wajib dipilih.");

                if (cmbLevelRoasting.SelectedItem == null)
                    throw new Exception("Roast level wajib dipilih.");

                var batch = new BatchRoasting
                {
                    Id = _idBatch ?? 0,
                    IdBijiMentah = Convert.ToInt32(cmbGreenBean.SelectedValue),

                    // Tambah: kode dibuat otomatis di controller
                    // Edit: pakai kode lama dari database
                    KodeBatch = _idBatch.HasValue ? _kodeBatchLama : "",

                    JumlahBijiDipakaiKg = AmbilDecimal(
                        txtJumlahBijiDipakaiKg.Text,
                        "Green bean dipakai"
                    ),

                    HasilRoastingGram = AmbilDecimal(
                        txtHasilRoastingGram.Text,
                        "Hasil roast bean"
                    ),

                    LevelRoasting = cmbLevelRoasting.Text,
                    TanggalBatch = dtpTanggalBatch.Value.Date,
                    Catatan = txtCatatan.Text.Trim()
                };

                if (_idBatch.HasValue)
                {
                    _batchRoastingController.UbahBatch(batch);

                    MessageBox.Show(
                        "Batch roasting berhasil diubah.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    _batchRoastingController.TambahBatch(batch);

                    MessageBox.Show(
                        "Batch roasting berhasil ditambahkan.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Gagal Menyimpan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private decimal AmbilDecimal(string teks, string namaField)
        {
            teks = teks.Replace(",", ".");

            if (!decimal.TryParse(
                    teks,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal nilai))
            {
                throw new Exception($"{namaField} harus berupa angka.");
            }

            if (nilai <= 0)
                throw new Exception($"{namaField} harus lebih dari 0.");

            return nilai;
        }
    }
}