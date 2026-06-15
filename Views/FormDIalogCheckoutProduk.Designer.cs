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
            lblJudul.Location = new Point(30, 25);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(334, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Catat Pembelian Produk";
            // 
            // lblProduk
            // 
            lblProduk.AutoSize = true;
            lblProduk.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProduk.Location = new Point(34, 95);
            lblProduk.Margin = new Padding(4, 0, 4, 0);
            lblProduk.Name = "lblProduk";
            lblProduk.Size = new Size(99, 28);
            lblProduk.TabIndex = 1;
            lblProduk.Text = "Produk: -";
            // 
            // lblInfoProduk
            // 
            lblInfoProduk.AutoSize = true;
            lblInfoProduk.ForeColor = Color.DimGray;
            lblInfoProduk.Location = new Point(35, 129);
            lblInfoProduk.Margin = new Padding(4, 0, 4, 0);
            lblInfoProduk.Name = "lblInfoProduk";
            lblInfoProduk.Size = new Size(144, 25);
            lblInfoProduk.TabIndex = 2;
            lblInfoProduk.Text = "Harga: - / Stok: -";
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(35, 188);
            lblJumlah.Margin = new Padding(4, 0, 4, 0);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(156, 25);
            lblJumlah.TabIndex = 3;
            lblJumlah.Text = "Jumlah Beli (gram)";
            // 
            // numJumlahGram
            // 
            numJumlahGram.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numJumlahGram.Location = new Point(35, 220);
            numJumlahGram.Margin = new Padding(4, 4, 4, 4);
            numJumlahGram.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numJumlahGram.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            numJumlahGram.Name = "numJumlahGram";
            numJumlahGram.Size = new Size(300, 31);
            numJumlahGram.TabIndex = 4;
            numJumlahGram.ThousandsSeparator = true;
            numJumlahGram.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNamaPembeli
            // 
            lblNamaPembeli.AutoSize = true;
            lblNamaPembeli.Location = new Point(35, 278);
            lblNamaPembeli.Margin = new Padding(4, 0, 4, 0);
            lblNamaPembeli.Name = "lblNamaPembeli";
            lblNamaPembeli.Size = new Size(126, 25);
            lblNamaPembeli.TabIndex = 5;
            lblNamaPembeli.Text = "Nama Pembeli";
            // 
            // txtNamaPembeli
            // 
            txtNamaPembeli.Location = new Point(35, 310);
            txtNamaPembeli.Margin = new Padding(4, 4, 4, 4);
            txtNamaPembeli.Name = "txtNamaPembeli";
            txtNamaPembeli.PlaceholderText = "Nama pembeli...";
            txtNamaPembeli.Size = new Size(724, 31);
            txtNamaPembeli.TabIndex = 6;
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalTitle.Location = new Point(35, 381);
            lblTotalTitle.Margin = new Padding(4, 0, 4, 0);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(59, 28);
            lblTotalTitle.TabIndex = 7;
            lblTotalTitle.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(79, 70, 229);
            lblTotal.Location = new Point(525, 372);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(76, 38);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Rp 0";
            // 
            // btnBatal
            // 
            btnBatal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatal.Location = new Point(35, 456);
            btnBatal.Margin = new Padding(4, 4, 4, 4);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(225, 52);
            btnBatal.TabIndex = 9;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(79, 70, 229);
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.White;
            btnBayar.Location = new Point(285, 456);
            btnBayar.Margin = new Padding(4, 4, 4, 4);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(475, 52);
            btnBayar.TabIndex = 10;
            btnBayar.Text = "Catat Pembelian";
            btnBayar.UseVisualStyleBackColor = false;
            // 
            // FormDialogCheckoutProduk
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 544);
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
            Margin = new Padding(4, 4, 4, 4);
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