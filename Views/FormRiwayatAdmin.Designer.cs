namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormRiwayatAdmin
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
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            tabRiwayat = new TabControl();
            tabPergerakanStok = new TabPage();
            dgvRiwayatStok = new DataGridView();
            tabTransaksiPenjualan = new TabPage();
            dgvTransaksiPenjualan = new DataGridView();
            pnlRingkasan = new Panel();
            lblGreenBeanMasuk = new Label();
            lblGreenBeanKeluar = new Label();
            lblRoastBeanMasuk = new Label();
            lblRoastBeanKeluar = new Label();
            lblJumlahTransaksi = new Label();
            lblTotalPenjualan = new Label();
            pnlHeader.SuspendLayout();
            tabRiwayat.SuspendLayout();
            tabPergerakanStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatStok).BeginInit();
            tabTransaksiPenjualan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiPenjualan).BeginInit();
            pnlRingkasan.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 112);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(30, 56);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(386, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Pergerakan stok dan catatan pembelian produk";
            lblSubJudul.Click += label2_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 18);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(121, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat";
            // 
            // tabRiwayat
            // 
            tabRiwayat.Controls.Add(tabPergerakanStok);
            tabRiwayat.Controls.Add(tabTransaksiPenjualan);
            tabRiwayat.Dock = DockStyle.Fill;
            tabRiwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabRiwayat.Location = new Point(0, 112);
            tabRiwayat.Margin = new Padding(12, 12, 12, 12);
            tabRiwayat.Name = "tabRiwayat";
            tabRiwayat.SelectedIndex = 0;
            tabRiwayat.Size = new Size(1280, 608);
            tabRiwayat.TabIndex = 2;
            // 
            // tabPergerakanStok
            // 
            tabPergerakanStok.Controls.Add(dgvRiwayatStok);
            tabPergerakanStok.Location = new Point(4, 34);
            tabPergerakanStok.Margin = new Padding(4, 4, 4, 4);
            tabPergerakanStok.Name = "tabPergerakanStok";
            tabPergerakanStok.Padding = new Padding(12, 12, 12, 12);
            tabPergerakanStok.Size = new Size(1272, 570);
            tabPergerakanStok.TabIndex = 0;
            tabPergerakanStok.Text = "Pergerakan Stok";
            tabPergerakanStok.UseVisualStyleBackColor = true;
            // 
            // dgvRiwayatStok
            // 
            dgvRiwayatStok.AllowUserToAddRows = false;
            dgvRiwayatStok.AllowUserToDeleteRows = false;
            dgvRiwayatStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatStok.Dock = DockStyle.Fill;
            dgvRiwayatStok.Location = new Point(12, 12);
            dgvRiwayatStok.Margin = new Padding(4, 4, 4, 4);
            dgvRiwayatStok.MultiSelect = false;
            dgvRiwayatStok.Name = "dgvRiwayatStok";
            dgvRiwayatStok.ReadOnly = true;
            dgvRiwayatStok.RowHeadersVisible = false;
            dgvRiwayatStok.RowHeadersWidth = 51;
            dgvRiwayatStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatStok.Size = new Size(1248, 546);
            dgvRiwayatStok.TabIndex = 0;
            // 
            // tabTransaksiPenjualan
            // 
            tabTransaksiPenjualan.Controls.Add(dgvTransaksiPenjualan);
            tabTransaksiPenjualan.Location = new Point(4, 34);
            tabTransaksiPenjualan.Margin = new Padding(4, 4, 4, 4);
            tabTransaksiPenjualan.Name = "tabTransaksiPenjualan";
            tabTransaksiPenjualan.Padding = new Padding(12, 12, 12, 12);
            tabTransaksiPenjualan.Size = new Size(1220, 541);
            tabTransaksiPenjualan.TabIndex = 1;
            tabTransaksiPenjualan.Text = "tabTransaksiPenjualan";
            tabTransaksiPenjualan.UseVisualStyleBackColor = true;
            // 
            // dgvTransaksiPenjualan
            // 
            dgvTransaksiPenjualan.AllowUserToAddRows = false;
            dgvTransaksiPenjualan.AllowUserToDeleteRows = false;
            dgvTransaksiPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaksiPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksiPenjualan.Dock = DockStyle.Fill;
            dgvTransaksiPenjualan.Location = new Point(12, 12);
            dgvTransaksiPenjualan.Margin = new Padding(4, 4, 4, 4);
            dgvTransaksiPenjualan.MultiSelect = false;
            dgvTransaksiPenjualan.Name = "dgvTransaksiPenjualan";
            dgvTransaksiPenjualan.ReadOnly = true;
            dgvTransaksiPenjualan.RowHeadersVisible = false;
            dgvTransaksiPenjualan.RowHeadersWidth = 51;
            dgvTransaksiPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksiPenjualan.Size = new Size(1196, 517);
            dgvTransaksiPenjualan.TabIndex = 1;
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.Controls.Add(lblGreenBeanMasuk);
            pnlRingkasan.Controls.Add(lblGreenBeanKeluar);
            pnlRingkasan.Controls.Add(lblRoastBeanMasuk);
            pnlRingkasan.Controls.Add(lblRoastBeanKeluar);
            pnlRingkasan.Controls.Add(lblJumlahTransaksi);
            pnlRingkasan.Controls.Add(lblTotalPenjualan);
            pnlRingkasan.Dock = DockStyle.Bottom;
            pnlRingkasan.Location = new Point(0, 570);
            pnlRingkasan.Margin = new Padding(4, 4, 4, 4);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(1280, 150);
            pnlRingkasan.TabIndex = 3;
            // 
            // lblGreenBeanMasuk
            // 
            lblGreenBeanMasuk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGreenBeanMasuk.AutoSize = true;
            lblGreenBeanMasuk.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanMasuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanMasuk.Location = new Point(30, 56);
            lblGreenBeanMasuk.Margin = new Padding(4, 0, 4, 0);
            lblGreenBeanMasuk.Name = "lblGreenBeanMasuk";
            lblGreenBeanMasuk.Size = new Size(159, 27);
            lblGreenBeanMasuk.TabIndex = 8;
            lblGreenBeanMasuk.Text = "RB Masuk\\r\\n0 g";
            lblGreenBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanKeluar
            // 
            lblGreenBeanKeluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGreenBeanKeluar.AutoSize = true;
            lblGreenBeanKeluar.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanKeluar.Location = new Point(239, 56);
            lblGreenBeanKeluar.Margin = new Padding(4, 0, 4, 0);
            lblGreenBeanKeluar.Name = "lblGreenBeanKeluar";
            lblGreenBeanKeluar.Size = new Size(158, 27);
            lblGreenBeanKeluar.TabIndex = 9;
            lblGreenBeanKeluar.Text = "RB Keluar\\r\\n0 g";
            lblGreenBeanKeluar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanMasuk
            // 
            lblRoastBeanMasuk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRoastBeanMasuk.AutoSize = true;
            lblRoastBeanMasuk.BorderStyle = BorderStyle.FixedSingle;
            lblRoastBeanMasuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoastBeanMasuk.Location = new Point(456, 56);
            lblRoastBeanMasuk.Margin = new Padding(4, 0, 4, 0);
            lblRoastBeanMasuk.Name = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.Size = new Size(124, 27);
            lblRoastBeanMasuk.TabIndex = 10;
            lblRoastBeanMasuk.Text = "Catatan\\r\\n0";
            lblRoastBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanKeluar
            // 
            lblRoastBeanKeluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRoastBeanKeluar.AutoSize = true;
            lblRoastBeanKeluar.BorderStyle = BorderStyle.FixedSingle;
            lblRoastBeanKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoastBeanKeluar.Location = new Point(646, 56);
            lblRoastBeanKeluar.Margin = new Padding(4, 0, 4, 0);
            lblRoastBeanKeluar.Name = "lblRoastBeanKeluar";
            lblRoastBeanKeluar.Size = new Size(178, 27);
            lblRoastBeanKeluar.TabIndex = 11;
            lblRoastBeanKeluar.Text = "Total Catat\\r\\nRp 0";
            lblRoastBeanKeluar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.BorderStyle = BorderStyle.FixedSingle;
            lblJumlahTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahTransaksi.Location = new Point(858, 56);
            lblJumlahTransaksi.Margin = new Padding(4, 0, 4, 0);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(172, 27);
            lblJumlahTransaksi.TabIndex = 6;
            lblJumlahTransaksi.Text = "GB Masuk\\r\\n0 Kg";
            lblJumlahTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPenjualan
            // 
            lblTotalPenjualan.AutoSize = true;
            lblTotalPenjualan.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPenjualan.Location = new Point(1068, 56);
            lblTotalPenjualan.Margin = new Padding(4, 0, 4, 0);
            lblTotalPenjualan.Name = "lblTotalPenjualan";
            lblTotalPenjualan.Size = new Size(171, 27);
            lblTotalPenjualan.TabIndex = 7;
            lblTotalPenjualan.Text = "GB Keluar\\r\\n0 Kg";
            lblTotalPenjualan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRiwayatAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlRingkasan);
            Controls.Add(tabRiwayat);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRiwayatAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabRiwayat.ResumeLayout(false);
            tabPergerakanStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatStok).EndInit();
            tabTransaksiPenjualan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaksiPenjualan).EndInit();
            pnlRingkasan.ResumeLayout(false);
            pnlRingkasan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private TabControl tabRiwayat;
        private TabPage tabPergerakanStok;
        private TabPage tabTransaksiPenjualan;
        private DataGridView dgvRiwayatStok;
        private Panel pnlRingkasan;
        private Label lblGreenBeanMasuk;
        private Label lblGreenBeanKeluar;
        private Label lblRoastBeanMasuk;
        private Label lblRoastBeanKeluar;
        private Label lblJumlahTransaksi;
        private Label lblTotalPenjualan;
        private DataGridView dgvTransaksiPenjualan;
    }
}