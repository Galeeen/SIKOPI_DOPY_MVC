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
            lblNamaProduk.Location = new Point(12, 9);
            lblNamaProduk.Name = "lblNamaProduk";
            lblNamaProduk.Size = new Size(68, 20);
            lblNamaProduk.TabIndex = 0;
            lblNamaProduk.Text = "Produk: -";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(12, 102);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(148, 20);
            lblHarga.TabIndex = 1;
            lblHarga.Text = "Harga per Gram (Rp)";
            // 
            // txtHargaPerGram
            // 
            txtHargaPerGram.Location = new Point(12, 125);
            txtHargaPerGram.Name = "txtHargaPerGram";
            txtHargaPerGram.Size = new Size(125, 27);
            txtHargaPerGram.TabIndex = 2;
            txtHargaPerGram.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 175);
            label1.Name = "label1";
            label1.Size = new Size(459, 20);
            label1.TabIndex = 3;
            label1.Text = "Setelah harga diinput, produk akan otomatis muncul di Etalase Toko";
            // 
            // btnBatal
            // 
            btnBatal.Cursor = Cursors.Hand;
            btnBatal.DialogResult = DialogResult.Cancel;
            btnBatal.Location = new Point(35, 263);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 4;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.Location = new Point(267, 263);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // FormDialogHargaRoastBean
            // 
            AcceptButton = btnBatal;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBatal;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(btnBatal);
            Controls.Add(label1);
            Controls.Add(txtHargaPerGram);
            Controls.Add(lblHarga);
            Controls.Add(lblNamaProduk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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