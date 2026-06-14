namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDialogCheckoutProduk
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblJudul = new Label();
            lblProduk = new Label();
            lblInfoProduk = new Label();
            lblJumlah = new Label();
            numJumlahGram = new NumericUpDown();
            lblNamaPembeli = new Label();
            txtNamaPembeli = new TextBox();
            lblTotalTitle = new Label();
            lblTotal = new Label();
            btnBatal = new Button();
            btnBayar = new Button();
            ((System.ComponentModel.ISupportInitialize)numJumlahGram).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJudul.Location = new Point(24, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(289, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Catat Pembelian Produk";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProduk.Location = new Point(27, 76);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(86, 23);
            lblProduk.TabIndex = 1;
            lblProduk.Text = "Produk: -";
            // 
            // lblInfoProduk
            // 
            lblInfoProduk.AutoSize = true;
            lblInfoProduk.ForeColor = Color.DimGray;
            lblInfoProduk.Location = new Point(28, 103);
            lblInfoProduk.Name = "lblInfoProduk";
            lblInfoProduk.Size = new Size(119, 20);
            lblInfoProduk.TabIndex = 2;
            lblInfoProduk.Text = "Harga: - / Stok: -";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(28, 150);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(133, 20);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "Jumlah Beli (gram)";
            // 
            // numJumlahGram
            // 
            numJumlahGram.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numJumlahGram.Location = new Point(28, 176);
            numJumlahGram.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numJumlahGram.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numJumlahGram.Name = "numJumlahGram";
            numJumlahGram.Size = new Size(240, 27);
            numJumlahGram.TabIndex = 4;
            numJumlahGram.ThousandsSeparator = true;
            numJumlahGram.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNamaPembeli
            // 
            lblNamaPembeli.AutoSize = true;
            lblNamaPembeli.Location = new Point(28, 222);
            lblNamaPembeli.Name = "lblNamaPembeli";
            lblNamaPembeli.Size = new Size(106, 20);
            lblNamaPembeli.TabIndex = 5;
            lblNamaPembeli.Text = "Nama Pembeli";
            // 
            // txtNamaPembeli
            // 
            txtNamaPembeli.Location = new Point(28, 248);
            txtNamaPembeli.Name = "txtNamaPembeli";
            txtNamaPembeli.PlaceholderText = "Nama pembeli...";
            txtNamaPembeli.Size = new Size(580, 27);
            txtNamaPembeli.TabIndex = 6;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalTitle.Location = new Point(28, 305);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(49, 23);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(79, 70, 229);
            lblTotal.Location = new Point(420, 298);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(66, 32);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Rp 0";
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(28, 365);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(180, 42);
            btnBatal.TabIndex = 9;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(79, 70, 229);
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(228, 365);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(380, 42);
            btnBayar.TabIndex = 10;
            btnBayar.Text = "Catat Pembelian";
            btnBayar.UseVisualStyleBackColor = false;
            // 
            // FormDialogCheckoutProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(640, 435);
            Controls.Add(btnBayar);
            Controls.Add(btnBatal);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTitle);
            Controls.Add(txtNamaPembeli);
            Controls.Add(lblNamaPembeli);
            Controls.Add(numJumlahGram);
            Controls.Add(lblJumlah);
            Controls.Add(lblInfoProduk);
            Controls.Add(lblProduk);
            Controls.Add(lblJudul);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDialogCheckoutProduk";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Catat Pembelian Produk";
            ((System.ComponentModel.ISupportInitialize)numJumlahGram).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblProduk;
        private Label lblInfoProduk;
        private Label lblJumlah;
        private NumericUpDown numJumlahGram;
        private Label lblNamaPembeli;
        private TextBox txtNamaPembeli;
        private Label lblTotalTitle;
        private Label lblTotal;
        private Button btnBatal;
        private Button btnBayar;
    }
}