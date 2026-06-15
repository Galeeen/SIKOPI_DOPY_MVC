namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDialogGreenBean
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBox cmbJenis;
            ComboBox cmbTingkatKualitas;
            txtNamaBiji = new TextBox();
            txtAsalDaerah = new TextBox();
            txtKetinggianMdpl = new TextBox();
            txtStokKg = new TextBox();
            btnSimpan = new Button();
            cmbMetodeProses = new ComboBox();
            txtHargaPerKg = new TextBox();
            lblNamaBiji = new Label();
            lblAsalDaerah = new Label();
            lblJenis = new Label();
            lblKetinggianMdpl = new Label();
            lblMetodeProses = new Label();
            lblTingkatKualitas = new Label();
            lblStokKg = new Label();
            lblHargaPerKg = new Label();
            lblTanggalPanen = new Label();
            dtpTanggalPanen = new DateTimePicker();
            btnBatal = new Button();
            cmbJenis = new ComboBox();
            cmbTingkatKualitas = new ComboBox();
            SuspendLayout();
            // 
            // txtNamaBiji
            // 
            txtNamaBiji.Location = new Point(15, 48);
            txtNamaBiji.Margin = new Padding(4, 4, 4, 4);
            txtNamaBiji.Name = "txtNamaBiji";
            txtNamaBiji.Size = new Size(155, 31);
            txtNamaBiji.TabIndex = 0;
            // 
            // txtAsalDaerah
            // 
            txtAsalDaerah.Location = new Point(15, 149);
            txtAsalDaerah.Margin = new Padding(4, 4, 4, 4);
            txtAsalDaerah.Name = "txtAsalDaerah";
            txtAsalDaerah.Size = new Size(155, 31);
            txtAsalDaerah.TabIndex = 1;
            // 
            // txtKetinggianMdpl
            // 
            txtKetinggianMdpl.Location = new Point(15, 368);
            txtKetinggianMdpl.Margin = new Padding(4, 4, 4, 4);
            txtKetinggianMdpl.Name = "txtKetinggianMdpl";
            txtKetinggianMdpl.Size = new Size(155, 31);
            txtKetinggianMdpl.TabIndex = 2;
            // 
            // txtStokKg
            // 
            txtStokKg.Location = new Point(398, 149);
            txtStokKg.Margin = new Padding(4, 4, 4, 4);
            txtStokKg.Name = "txtStokKg";
            txtStokKg.Size = new Size(155, 31);
            txtStokKg.TabIndex = 3;
            txtStokKg.Text = "0";
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(79, 70, 229);
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(536, 480);
            btnSimpan.Margin = new Padding(4, 4, 4, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(118, 36);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbMetodeProses
            // 
            cmbMetodeProses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodeProses.FormattingEnabled = true;
            cmbMetodeProses.Location = new Point(15, 480);
            cmbMetodeProses.Margin = new Padding(4, 4, 4, 4);
            cmbMetodeProses.Name = "cmbMetodeProses";
            cmbMetodeProses.Size = new Size(155, 33);
            cmbMetodeProses.TabIndex = 10;
            // 
            // txtHargaPerKg
            // 
            txtHargaPerKg.Location = new Point(398, 258);
            txtHargaPerKg.Margin = new Padding(4, 4, 4, 4);
            txtHargaPerKg.Name = "txtHargaPerKg";
            txtHargaPerKg.Size = new Size(155, 31);
            txtHargaPerKg.TabIndex = 12;
            txtHargaPerKg.Text = "0";
            // 
            // lblNamaBiji
            // 
            lblNamaBiji.AutoSize = true;
            lblNamaBiji.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaBiji.Location = new Point(15, 19);
            lblNamaBiji.Margin = new Padding(4, 0, 4, 0);
            lblNamaBiji.Name = "lblNamaBiji";
            lblNamaBiji.Size = new Size(94, 25);
            lblNamaBiji.TabIndex = 13;
            lblNamaBiji.Text = "Nama Biji";
            // 
            // lblAsalDaerah
            // 
            lblAsalDaerah.AutoSize = true;
            lblAsalDaerah.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsalDaerah.Location = new Point(15, 120);
            lblAsalDaerah.Margin = new Padding(4, 0, 4, 0);
            lblAsalDaerah.Name = "lblAsalDaerah";
            lblAsalDaerah.Size = new Size(114, 25);
            lblAsalDaerah.TabIndex = 14;
            lblAsalDaerah.Text = "Asal Daerah";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJenis.Location = new Point(15, 229);
            lblJenis.Margin = new Padding(4, 0, 4, 0);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(54, 25);
            lblJenis.TabIndex = 15;
            lblJenis.Text = "Jenis";
            // 
            // lblKetinggianMdpl
            // 
            lblKetinggianMdpl.AutoSize = true;
            lblKetinggianMdpl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKetinggianMdpl.Location = new Point(15, 339);
            lblKetinggianMdpl.Margin = new Padding(4, 0, 4, 0);
            lblKetinggianMdpl.Name = "lblKetinggianMdpl";
            lblKetinggianMdpl.Size = new Size(168, 25);
            lblKetinggianMdpl.TabIndex = 16;
            lblKetinggianMdpl.Text = "Ketinggian (Mdpl)";
            // 
            // lblMetodeProses
            // 
            lblMetodeProses.AutoSize = true;
            lblMetodeProses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMetodeProses.Location = new Point(15, 451);
            lblMetodeProses.Margin = new Padding(4, 0, 4, 0);
            lblMetodeProses.Name = "lblMetodeProses";
            lblMetodeProses.Size = new Size(138, 25);
            lblMetodeProses.TabIndex = 17;
            lblMetodeProses.Text = "Metode Proses";
            // 
            // lblTingkatKualitas
            // 
            lblTingkatKualitas.AutoSize = true;
            lblTingkatKualitas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTingkatKualitas.Location = new Point(398, 11);
            lblTingkatKualitas.Margin = new Padding(4, 0, 4, 0);
            lblTingkatKualitas.Name = "lblTingkatKualitas";
            lblTingkatKualitas.Size = new Size(80, 25);
            lblTingkatKualitas.TabIndex = 18;
            lblTingkatKualitas.Text = "Kualitas";
            // 
            // lblStokKg
            // 
            lblStokKg.AutoSize = true;
            lblStokKg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStokKg.Location = new Point(398, 120);
            lblStokKg.Margin = new Padding(4, 0, 4, 0);
            lblStokKg.Name = "lblStokKg";
            lblStokKg.Size = new Size(92, 25);
            lblStokKg.TabIndex = 19;
            lblStokKg.Text = "Stok (Kg)";
            // 
            // lblHargaPerKg
            // 
            lblHargaPerKg.AutoSize = true;
            lblHargaPerKg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHargaPerKg.Location = new Point(398, 229);
            lblHargaPerKg.Margin = new Padding(4, 0, 4, 0);
            lblHargaPerKg.Name = "lblHargaPerKg";
            lblHargaPerKg.Size = new Size(125, 25);
            lblHargaPerKg.TabIndex = 20;
            lblHargaPerKg.Text = "Harga per Kg";
            // 
            // lblTanggalPanen
            // 
            lblTanggalPanen.AutoSize = true;
            lblTanggalPanen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggalPanen.Location = new Point(398, 339);
            lblTanggalPanen.Margin = new Padding(4, 0, 4, 0);
            lblTanggalPanen.Name = "lblTanggalPanen";
            lblTanggalPanen.Size = new Size(137, 25);
            lblTanggalPanen.TabIndex = 23;
            lblTanggalPanen.Text = "Tanggal Panen";
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Location = new Point(400, 368);
            dtpTanggalPanen.Margin = new Padding(4, 4, 4, 4);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(312, 31);
            dtpTanggalPanen.TabIndex = 24;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(79, 70, 229);
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(380, 479);
            btnBatal.Margin = new Padding(4, 4, 4, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(118, 36);
            btnBatal.TabIndex = 25;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(15, 258);
            cmbJenis.Margin = new Padding(4, 4, 4, 4);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(155, 33);
            cmbJenis.TabIndex = 9;
            // 
            // cmbTingkatKualitas
            // 
            cmbTingkatKualitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTingkatKualitas.FormattingEnabled = true;
            cmbTingkatKualitas.Location = new Point(398, 40);
            cmbTingkatKualitas.Margin = new Padding(4, 4, 4, 4);
            cmbTingkatKualitas.Name = "cmbTingkatKualitas";
            cmbTingkatKualitas.Size = new Size(155, 33);
            cmbTingkatKualitas.TabIndex = 11;
            // 
            // FormDialogGreenBean
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 591);
            Controls.Add(btnBatal);
            Controls.Add(dtpTanggalPanen);
            Controls.Add(lblTanggalPanen);
            Controls.Add(lblHargaPerKg);
            Controls.Add(lblStokKg);
            Controls.Add(lblTingkatKualitas);
            Controls.Add(lblMetodeProses);
            Controls.Add(lblKetinggianMdpl);
            Controls.Add(lblJenis);
            Controls.Add(lblAsalDaerah);
            Controls.Add(lblNamaBiji);
            Controls.Add(txtHargaPerKg);
            Controls.Add(cmbTingkatKualitas);
            Controls.Add(cmbMetodeProses);
            Controls.Add(cmbJenis);
            Controls.Add(btnSimpan);
            Controls.Add(txtStokKg);
            Controls.Add(txtKetinggianMdpl);
            Controls.Add(txtAsalDaerah);
            Controls.Add(txtNamaBiji);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogGreenBean";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Green Bean";
            Load += FormDialogGreenBean_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNamaBiji;
        private TextBox txtAsalDaerah;
        private TextBox txtKetinggianMdpl;
        private TextBox txtStokKg;
        private TextBox textBox6;
        private DateTimePicker dtpTanggalPanen;
        private Button btnBatal;
        private Button btnSimpan;
        private ComboBox cmbJenis;
        private ComboBox cmbMetodeProses;
        private ComboBox cmbTingkatKualitas;
        private TextBox txtHargaPerKg;
        private Label lblNamaBiji;
        private Label lblAsalDaerah;
        private Label lblJenis;
        private Label lblKetinggianMdpl;
        private Label lblMetodeProses;
        private Label lblTingkatKualitas;
        private Label lblStokKg;
        private Label lblHargaPerKg;
        private Label label9;
        private Label label10;
        private Label lblTanggalPanen;
    }
}