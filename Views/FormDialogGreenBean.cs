using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System;
using System.Globalization;
using SIKOPI_DOPY_MVC.Controllers;
using SIKOPI_DOPY_MVC.Models;
using SIKOPI_DOPY_MVC.Repositories;

namespace SIKOPI_DOPY_MVC.Views
{
    public partial class FormDialogGreenBean : Form
    {
        private readonly BahanBakuController _bahanBakuController;
        private readonly IRepositoriLookup _repositoriLookup;
        private readonly int? _idBijiMentah;

        public FormDialogGreenBean()
        {
            InitializeComponent();

            _bahanBakuController = new BahanBakuController();
            _repositoriLookup = new RepositoriLookup();
            _idBijiMentah = null;
        }

        public FormDialogGreenBean(int idBijiMentah)
        {
            InitializeComponent();

            _bahanBakuController = new BahanBakuController();
            _repositoriLookup = new RepositoriLookup();
            _idBijiMentah = idBijiMentah;
        }

        private void FormDialogGreenBean_Load(object sender, EventArgs e)
        {
            MuatComboBox();

            if (_idBijiMentah.HasValue)
            {
                this.Text = "Edit Green Bean";
                btnSimpan.Text = "Update";

                MuatDataEdit(_idBijiMentah.Value);
            }
            else
            {
                this.Text = "Tambah Green Bean";
                btnSimpan.Text = "Simpan";

                txtStokKg.Text = "0";
                txtHargaPerKg.Text = "0";
            }
        }

        private void MuatComboBox()
        {
            cmbJenis.DataSource = _repositoriLookup.AmbilJenisBiji();
            cmbJenis.DisplayMember = "Nama";
            cmbJenis.ValueMember = "Id";

            cmbMetodeProses.DataSource = _repositoriLookup.AmbilMetodeProses();
            cmbMetodeProses.DisplayMember = "Nama";
            cmbMetodeProses.ValueMember = "Id";

            cmbTingkatKualitas.Items.Clear();
            cmbTingkatKualitas.Items.Add("Specialty");
            cmbTingkatKualitas.Items.Add("Grade 1");
            cmbTingkatKualitas.Items.Add("Grade 2");
            cmbTingkatKualitas.Items.Add("Komersial");

            if (cmbTingkatKualitas.Items.Count > 0)
                cmbTingkatKualitas.SelectedIndex = 0;
        }

        private void MuatDataEdit(int idBijiMentah)
        {
            GreenBean greenBean = _bahanBakuController.AmbilGreenBeanById(idBijiMentah);

            txtNamaBiji.Text = greenBean.NamaBiji;
            txtAsalDaerah.Text = greenBean.AsalDaerah;
            txtKetinggianMdpl.Text = greenBean.KetinggianMdpl.ToString();
            txtStokKg.Text = greenBean.StokKg.ToString(CultureInfo.InvariantCulture);
            txtHargaPerKg.Text = greenBean.HargaPerKg.ToString(CultureInfo.InvariantCulture);

            cmbJenis.SelectedValue = greenBean.IdJenisBijiKopiMentah;
            cmbMetodeProses.SelectedValue = greenBean.IdMetodeProses;
            cmbTingkatKualitas.Text = greenBean.TingkatKualitas;

            if (greenBean.TanggalPanen.HasValue)
                dtpTanggalPanen.Value = greenBean.TanggalPanen.Value;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                var greenBean = new GreenBean
                {
                    Id = _idBijiMentah ?? 0,
                    NamaBiji = txtNamaBiji.Text.Trim(),
                    AsalDaerah = txtAsalDaerah.Text.Trim(),
                    IdJenisBijiKopiMentah = Convert.ToInt32(cmbJenis.SelectedValue),
                    IdMetodeProses = Convert.ToInt32(cmbMetodeProses.SelectedValue),
                    TingkatKualitas = cmbTingkatKualitas.Text,
                    KetinggianMdpl = AmbilInteger(txtKetinggianMdpl.Text, "Ketinggian"),
                    StokKg = AmbilDecimal(txtStokKg.Text, "Stok"),
                    HargaPerKg = AmbilDecimal(txtHargaPerKg.Text, "Harga per kg"),
                    TanggalPanen = dtpTanggalPanen.Value.Date
                };

                if (_idBijiMentah.HasValue)
                {
                    _bahanBakuController.UbahGreenBean(greenBean);

                    MessageBox.Show(
                        "Data green bean berhasil diubah.",
                        "Berhasil",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    _bahanBakuController.TambahGreenBean(greenBean);

                    MessageBox.Show(
                        "Data green bean berhasil ditambahkan.",
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

        private int AmbilInteger(string teks, string namaField)
        {
            if (!int.TryParse(teks, out int nilai))
                throw new Exception($"{namaField} harus berupa angka.");

            if (nilai < 0)
                throw new Exception($"{namaField} tidak boleh minus.");

            return nilai;
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

            if (nilai < 0)
                throw new Exception($"{namaField} tidak boleh minus.");

            return nilai;
        }
    }
}