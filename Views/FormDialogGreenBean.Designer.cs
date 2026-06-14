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
            // cmbJenis
            // 
            cmbJenis.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenis.FormattingEnabled = true;
            cmbJenis.Location = new Point(12, 206);
            cmbJenis.Name = "cmbJenis";
            cmbJenis.Size = new Size(125, 28);
            cmbJenis.TabIndex = 9;
            // 
            // cmbTingkatKualitas
            // 
            cmbTingkatKualitas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTingkatKualitas.FormattingEnabled = true;
            cmbTingkatKualitas.Location = new Point(318, 32);
            cmbTingkatKualitas.Name = "cmbTingkatKualitas";
            cmbTingkatKualitas.Size = new Size(125, 28);
            cmbTingkatKualitas.TabIndex = 11;
            // 
            // txtNamaBiji
            // 
            txtNamaBiji.Location = new Point(12, 38);
            txtNamaBiji.Name = "txtNamaBiji";
            txtNamaBiji.Size = new Size(125, 27);
            txtNamaBiji.TabIndex = 0;
            // 
            // txtAsalDaerah
            // 
            txtAsalDaerah.Location = new Point(12, 119);
            txtAsalDaerah.Name = "txtAsalDaerah";
            txtAsalDaerah.Size = new Size(125, 27);
            txtAsalDaerah.TabIndex = 1;
            // 
            // txtKetinggianMdpl
            // 
            txtKetinggianMdpl.Location = new Point(12, 294);
            txtKetinggianMdpl.Name = "txtKetinggianMdpl";
            txtKetinggianMdpl.Size = new Size(125, 27);
            txtKetinggianMdpl.TabIndex = 2;
            // 
            // txtStokKg
            // 
            txtStokKg.Location = new Point(318, 119);
            txtStokKg.Name = "txtStokKg";
            txtStokKg.Size = new Size(125, 27);
            txtStokKg.TabIndex = 3;
            txtStokKg.Text = "0";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(429, 384);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbMetodeProses
            // 
            cmbMetodeProses.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodeProses.FormattingEnabled = true;
            cmbMetodeProses.Location = new Point(12, 384);
            cmbMetodeProses.Name = "cmbMetodeProses";
            cmbMetodeProses.Size = new Size(125, 28);
            cmbMetodeProses.TabIndex = 10;
            // 
            // txtHargaPerKg
            // 
            txtHargaPerKg.Location = new Point(318, 206);
            txtHargaPerKg.Name = "txtHargaPerKg";
            txtHargaPerKg.Size = new Size(125, 27);
            txtHargaPerKg.TabIndex = 12;
            txtHargaPerKg.Text = "0";
            // 
            // lblNamaBiji
            // 
            lblNamaBiji.AutoSize = true;
            lblNamaBiji.Location = new Point(12, 15);
            lblNamaBiji.Name = "lblNamaBiji";
            lblNamaBiji.Size = new Size(74, 20);
            lblNamaBiji.TabIndex = 13;
            lblNamaBiji.Text = "Nama Biji";
            // 
            // lblAsalDaerah
            // 
            lblAsalDaerah.AutoSize = true;
            lblAsalDaerah.Location = new Point(12, 96);
            lblAsalDaerah.Name = "lblAsalDaerah";
            lblAsalDaerah.Size = new Size(89, 20);
            lblAsalDaerah.TabIndex = 14;
            lblAsalDaerah.Text = "Asal Daerah";
            // 
            // lblJenis
            // 
            lblJenis.AutoSize = true;
            lblJenis.Location = new Point(12, 183);
            lblJenis.Name = "lblJenis";
            lblJenis.Size = new Size(40, 20);
            lblJenis.TabIndex = 15;
            lblJenis.Text = "Jenis";
            // 
            // lblKetinggianMdpl
            // 
            lblKetinggianMdpl.AutoSize = true;
            lblKetinggianMdpl.Location = new Point(12, 271);
            lblKetinggianMdpl.Name = "lblKetinggianMdpl";
            lblKetinggianMdpl.Size = new Size(130, 20);
            lblKetinggianMdpl.TabIndex = 16;
            lblKetinggianMdpl.Text = "Ketinggian (Mdpl)";
            // 
            // lblMetodeProses
            // 
            lblMetodeProses.AutoSize = true;
            lblMetodeProses.Location = new Point(12, 361);
            lblMetodeProses.Name = "lblMetodeProses";
            lblMetodeProses.Size = new Size(107, 20);
            lblMetodeProses.TabIndex = 17;
            lblMetodeProses.Text = "Metode Proses";
            // 
            // lblTingkatKualitas
            // 
            lblTingkatKualitas.AutoSize = true;
            lblTingkatKualitas.Location = new Point(318, 9);
            lblTingkatKualitas.Name = "lblTingkatKualitas";
            lblTingkatKualitas.Size = new Size(61, 20);
            lblTingkatKualitas.TabIndex = 18;
            lblTingkatKualitas.Text = "Kualitas";
            // 
            // lblStokKg
            // 
            lblStokKg.AutoSize = true;
            lblStokKg.Location = new Point(318, 96);
            lblStokKg.Name = "lblStokKg";
            lblStokKg.Size = new Size(70, 20);
            lblStokKg.TabIndex = 19;
            lblStokKg.Text = "Stok (Kg)";
            // 
            // lblHargaPerKg
            // 
            lblHargaPerKg.AutoSize = true;
            lblHargaPerKg.Location = new Point(318, 183);
            lblHargaPerKg.Name = "lblHargaPerKg";
            lblHargaPerKg.Size = new Size(98, 20);
            lblHargaPerKg.TabIndex = 20;
            lblHargaPerKg.Text = "Harga per Kg";
            // 
            // lblTanggalPanen
            // 
            lblTanggalPanen.AutoSize = true;
            lblTanggalPanen.Location = new Point(318, 271);
            lblTanggalPanen.Name = "lblTanggalPanen";
            lblTanggalPanen.Size = new Size(104, 20);
            lblTanggalPanen.TabIndex = 23;
            lblTanggalPanen.Text = "Tanggal Panen";
            // 
            // dtpTanggalPanen
            // 
            dtpTanggalPanen.Location = new Point(320, 294);
            dtpTanggalPanen.Name = "dtpTanggalPanen";
            dtpTanggalPanen.Size = new Size(250, 27);
            dtpTanggalPanen.TabIndex = 24;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(304, 383);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 25;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormDialogGreenBean
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 473);
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
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogGreenBean";
            StartPosition = FormStartPosition.CenterParent;
            Load += FormDialogGreenBean_Load;
            Text = "Tambah Green Bean";
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