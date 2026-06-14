namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDialogBatchRoasting
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
            cmbGreenBean = new ComboBox();
            cmbLevelRoasting = new ComboBox();
            lblInfoGreenBean = new Label();
            txtJumlahBijiDipakaiKg = new TextBox();
            txtHasilRoastingGram = new TextBox();
            dtpTanggalBatch = new DateTimePicker();
            txtCatatan = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // cmbGreenBean
            // 
            cmbGreenBean.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGreenBean.FormattingEnabled = true;
            cmbGreenBean.Location = new Point(12, 31);
            cmbGreenBean.Name = "cmbGreenBean";
            cmbGreenBean.Size = new Size(151, 28);
            cmbGreenBean.TabIndex = 0;
            // 
            // cmbLevelRoasting
            // 
            cmbLevelRoasting.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLevelRoasting.FormattingEnabled = true;
            cmbLevelRoasting.Location = new Point(12, 179);
            cmbLevelRoasting.Name = "cmbLevelRoasting";
            cmbLevelRoasting.Size = new Size(151, 28);
            cmbLevelRoasting.TabIndex = 1;
            // 
            // lblInfoGreenBean
            // 
            lblInfoGreenBean.AutoSize = true;
            lblInfoGreenBean.Location = new Point(12, 62);
            lblInfoGreenBean.Name = "lblInfoGreenBean";
            lblInfoGreenBean.Size = new Size(77, 20);
            lblInfoGreenBean.TabIndex = 2;
            lblInfoGreenBean.Text = "Tersedia: -";
            // 
            // txtJumlahBijiDipakaiKg
            // 
            txtJumlahBijiDipakaiKg.Location = new Point(12, 95);
            txtJumlahBijiDipakaiKg.Name = "txtJumlahBijiDipakaiKg";
            txtJumlahBijiDipakaiKg.Size = new Size(125, 27);
            txtJumlahBijiDipakaiKg.TabIndex = 3;
            txtJumlahBijiDipakaiKg.Text = "0";
            // 
            // txtHasilRoastingGram
            // 
            txtHasilRoastingGram.Location = new Point(12, 146);
            txtHasilRoastingGram.Name = "txtHasilRoastingGram";
            txtHasilRoastingGram.Size = new Size(125, 27);
            txtHasilRoastingGram.TabIndex = 4;
            txtHasilRoastingGram.Text = "0";
            // 
            // dtpTanggalBatch
            // 
            dtpTanggalBatch.CustomFormat = "dd-MM-yyyy";
            dtpTanggalBatch.Format = DateTimePickerFormat.Custom;
            dtpTanggalBatch.Location = new Point(12, 227);
            dtpTanggalBatch.Name = "dtpTanggalBatch";
            dtpTanggalBatch.Size = new Size(250, 27);
            dtpTanggalBatch.TabIndex = 5;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(12, 288);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.PlaceholderText = "Profil rasa, durasi, suhu, dll.";
            txtCatatan.Size = new Size(373, 34);
            txtCatatan.TabIndex = 6;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(145, 364);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(319, 364);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // FormBatchRoasting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtCatatan);
            Controls.Add(dtpTanggalBatch);
            Controls.Add(txtHasilRoastingGram);
            Controls.Add(txtJumlahBijiDipakaiKg);
            Controls.Add(lblInfoGreenBean);
            Controls.Add(cmbLevelRoasting);
            Controls.Add(cmbGreenBean);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBatchRoasting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Batch Roasting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGreenBean;
        private ComboBox cmbLevelRoasting;
        private Label lblInfoGreenBean;
        private TextBox txtJumlahBijiDipakaiKg;
        private TextBox txtHasilRoastingGram;
        private DateTimePicker dtpTanggalBatch;
        private TextBox txtCatatan;
        private Button btnBatal;
        private Button btnSimpan;
    }
}