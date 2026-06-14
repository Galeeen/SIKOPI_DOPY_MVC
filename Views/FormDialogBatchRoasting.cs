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
        private int _idBijiMentahLama = 0;

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
            cmbGreenBean.DataSource = null;
            cmbGreenBean.DisplayMember = "Nama";
            cmbGreenBean.ValueMember = "Id";
            cmbGreenBean.DataSource = _repositoriLookup.AmbilGreenBeanAktifDetail();

            cmbLevelRoasting.Items.Clear();
            cmbLevelRoasting.Items.Add("Light");
            cmbLevelRoasting.Items.Add("Medium");
            cmbLevelRoasting.Items.Add("Medium Dark");
            cmbLevelRoasting.Items.Add("Dark");

            cmbLevelRoasting.DropDownStyle = ComboBoxStyle.DropDownList;

            if (cmbLevelRoasting.Items.Count > 0)
                cmbLevelRoasting.SelectedIndex = 0;

            TampilkanInfoGreenBeanTerpilih();
        }

        private void AturModeForm()
        {
            if (_idBatch.HasValue)
            {
                this.Text = "Edit Batch Roasting";

                // Saat edit, green bean tidak boleh diubah.
                cmbGreenBean.Enabled = false;

                MuatDataEdit(_idBatch.Value);
            }
            else
            {
                this.Text = "Tambah Batch Roasting";

                cmbGreenBean.Enabled = true;
                dtpTanggalBatch.Value = DateTime.Now;
                txtJumlahBijiDipakaiGram.Text = "0";
                txtHasilRoastingGram.Text = "0";
                txtCatatan.Text = "";
            }
        }

        private void MuatDataEdit(int idBatch)
        {
            BatchRoasting batch = _batchRoastingController.AmbilBatchById(idBatch);

            _kodeBatchLama = batch.KodeBatch;
            _idBijiMentahLama = batch.IdBijiMentah;

            txtJumlahBijiDipakaiGram.Text = batch.JumlahBijiDipakaiGram.ToString();
            txtHasilRoastingGram.Text = batch.HasilRoastingGram.ToString(CultureInfo.InvariantCulture);
            cmbLevelRoasting.Text = batch.LevelRoasting;
            dtpTanggalBatch.Value = batch.TanggalBatch;
            txtCatatan.Text = batch.Catatan;

            PilihGreenBeanDiCombo(_idBijiMentahLama);

            lblInfoGreenBean.Text = "Green bean tidak bisa diubah saat edit batch.";
        }

        private void PilihGreenBeanDiCombo(int idBijiMentah)
        {
            for (int i = 0; i < cmbGreenBean.Items.Count; i++)
            {
                if (cmbGreenBean.Items[i] is GreenBeanLookupItem item && item.Id == idBijiMentah)
                {
                    cmbGreenBean.SelectedIndex = i;
                    return;
                }
            }

           
            cmbGreenBean.SelectedIndex = -1;
        }

        private void cmbGreenBean_SelectedIndexChanged(object? sender, EventArgs e)
        {
            TampilkanInfoGreenBeanTerpilih();
        }

        private void TampilkanInfoGreenBeanTerpilih()
        {
            if (cmbGreenBean.SelectedItem is not GreenBeanLookupItem item)
            {
                lblInfoGreenBean.Text = "-";
                return;
            }

            lblInfoGreenBean.Text =
                $"Stok: {item.StokKg.ToString("0.##", CultureInfo.InvariantCulture)} kg | " +
                $"Asal: {item.AsalDaerah} | " +
                $"Proses: {item.MetodeProses}";
        }

        private void btnSimpan_Click(object? sender, EventArgs e)
        {
            try
            {
                if (cmbGreenBean.SelectedItem == null && !_idBatch.HasValue)
                {
                    MessageBox.Show(
                        "Green bean wajib dipilih.",
                        "Validasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                int idBijiMentah;

                if (_idBatch.HasValue)
                {
                    idBijiMentah = _idBijiMentahLama;
                }
                else
                {
                    GreenBeanLookupItem greenBeanDipilih = (GreenBeanLookupItem)cmbGreenBean.SelectedItem;
                    idBijiMentah = greenBeanDipilih.Id;
                }

                BatchRoasting batch = new BatchRoasting
                {
                    Id = _idBatch ?? 0,
                    IdBijiMentah = idBijiMentah,
                    IdPengguna = _penggunaLogin.Id,
                    KodeBatch = _kodeBatchLama,
                    JumlahBijiDipakaiGram = AmbilDecimal(txtJumlahBijiDipakaiGram.Text),
                    HasilRoastingGram = AmbilDecimal(txtHasilRoastingGram.Text),
                    LevelRoasting = cmbLevelRoasting.SelectedItem?.ToString() ?? "",
                    TanggalBatch = dtpTanggalBatch.Value,
                    Catatan = txtCatatan.Text.Trim()
                };

                if (_idBatch.HasValue)
                {
                    _batchRoastingController.UbahBatch(batch);
                }
                else
                {
                    _batchRoastingController.TambahBatch(batch);
                }

                MessageBox.Show(
                    "Data batch roasting berhasil disimpan.",
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
                    "Gagal Simpan Batch Roasting",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
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

        private decimal AmbilDecimal(string teks)
        {
            if (string.IsNullOrWhiteSpace(teks))
                return 0;

            teks = teks.Trim().Replace(",", ".");

            if (!decimal.TryParse(
                teks,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal hasil))
            {
                throw new Exception("Input angka tidak valid.");
            }

            return hasil;
        }

        private void btnBatal_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}