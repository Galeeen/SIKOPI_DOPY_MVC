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
            txtJumlahBijiDipakaiGram = new TextBox();
            txtHasilRoastingGram = new TextBox();
            dtpTanggalBatch = new DateTimePicker();
            txtCatatan = new TextBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            cmbLevelRoasting.Location = new Point(12, 250);
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
            // txtJumlahBijiDipakaiGram
            // 
            txtJumlahBijiDipakaiGram.Location = new Point(12, 124);
            txtJumlahBijiDipakaiGram.Name = "txtJumlahBijiDipakaiGram";
            txtJumlahBijiDipakaiGram.Size = new Size(125, 27);
            txtJumlahBijiDipakaiGram.TabIndex = 3;
            txtJumlahBijiDipakaiGram.Text = "0";
            // 
            // txtHasilRoastingGram
            // 
            txtHasilRoastingGram.Location = new Point(12, 190);
            txtHasilRoastingGram.Name = "txtHasilRoastingGram";
            txtHasilRoastingGram.Size = new Size(125, 27);
            txtHasilRoastingGram.TabIndex = 4;
            txtHasilRoastingGram.Text = "0";
            // 
            // dtpTanggalBatch
            // 
            dtpTanggalBatch.CustomFormat = "dd-MM-yyyy";
            dtpTanggalBatch.Format = DateTimePickerFormat.Custom;
            dtpTanggalBatch.Location = new Point(9, 314);
            dtpTanggalBatch.Name = "dtpTanggalBatch";
            dtpTanggalBatch.Size = new Size(250, 27);
            dtpTanggalBatch.TabIndex = 5;
            // 
            // txtCatatan
            // 
            txtCatatan.Location = new Point(9, 388);
            txtCatatan.Multiline = true;
            txtCatatan.Name = "txtCatatan";
            txtCatatan.PlaceholderText = "Profil rasa, durasi, suhu, dll.";
            txtCatatan.Size = new Size(373, 50);
            txtCatatan.TabIndex = 6;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(501, 350);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 7;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(675, 350);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 9;
            label1.Text = "Nama GreenBean";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 10;
            label2.Text = "Berat Masuk (gram)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 168);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 11;
            label3.Text = "Berat Keluar (gram)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 225);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 12;
            label4.Text = "Level Roasting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 291);
            label5.Name = "label5";
            label5.Size = new Size(112, 20);
            label5.TabIndex = 13;
            label5.Text = "Waktu Roasting";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 365);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 14;
            label6.Text = "Catatan Roasting";
            // 
            // FormDialogBatchRoasting
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(txtCatatan);
            Controls.Add(dtpTanggalBatch);
            Controls.Add(txtHasilRoastingGram);
            Controls.Add(txtJumlahBijiDipakaiGram);
            Controls.Add(lblInfoGreenBean);
            Controls.Add(cmbLevelRoasting);
            Controls.Add(cmbGreenBean);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogBatchRoasting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tambah Batch Roasting";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGreenBean;
        private ComboBox cmbLevelRoasting;
        private Label lblInfoGreenBean;
        private TextBox txtJumlahBijiDipakaiGram;
        private TextBox txtHasilRoastingGram;
        private DateTimePicker dtpTanggalBatch;
        private TextBox txtCatatan;
        private Button btnBatal;
        private Button btnSimpan;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}