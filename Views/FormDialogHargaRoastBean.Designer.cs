namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDialogHargaRoastBean
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
            lblNamaProduk = new Label();
            lblHarga = new Label();
            txtHargaPerGram = new TextBox();
            label1 = new Label();
            btnBatal = new Button();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // lblNamaProduk
            // 
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaProduk.Location = new Point(15, 11);
            lblNamaProduk.Margin = new Padding(4, 0, 4, 0);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(91, 25);
            lblNamaProduk.TabIndex = 0;
            lblNamaProduk.Text = "Produk: -";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(15, 74);
            lblHarga.Margin = new Padding(4, 0, 4, 0);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(190, 25);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Harga per Gram (Rp)";
            // 
            // txtHargaPerGram
            // 
            txtHargaPerGram.Location = new Point(15, 114);
            txtHargaPerGram.Margin = new Padding(4, 4, 4, 4);
            txtHargaPerGram.Name = "txtHargaPerGram";
            txtHargaPerGram.Size = new Size(155, 31);
            txtHargaPerGram.TabIndex = 2;
            txtHargaPerGram.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(592, 25);
            label1.TabIndex = 3;
            label1.Text = "Setelah harga diinput, produk akan otomatis muncul di Etalase Toko";
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.FromArgb(79, 70, 229);
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.DialogResult = DialogResult.Cancel;
            btnBatal.FlatStyle = FlatStyle.Flat;
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.ForeColor = SystemColors.ButtonHighlight;
            btnBatal.Location = new Point(28, 212);
            btnBatal.Margin = new Padding(4, 4, 4, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(118, 36);
            btnBatal.TabIndex = 4;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(79, 70, 229);
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.ForeColor = SystemColors.ButtonHighlight;
            btnSimpan.Location = new Point(178, 212);
            btnSimpan.Margin = new Padding(4, 4, 4, 4);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(118, 36);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            // 
            // FormDialogHargaRoastBean
            // 
            AcceptButton = btnBatal;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBatal;
            ClientSize = new Size(818, 499);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label1);
            Controls.Add(txtHargaPerGram);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaProduk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogHargaRoastBean";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Input Harga Roast Bean";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNamaProduk;
        private Label lblHarga;
        private TextBox txtHargaPerGram;
        private Label label1;
        private Button btnBatal;
        private Button btnSimpan;
    }
}