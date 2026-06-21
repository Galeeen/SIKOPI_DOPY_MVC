namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDashboardAdmin
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
            lblJudul = new Label();
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            pnlRingkasan = new Panel();
            lblOmzetHariIni = new Label();
            lblTransaksiHariIni = new Label();
            lblMenungguHarga = new Label();
            lblProdukSiapJual = new Label();
            lblBatchHariIni = new Label();
            lblTotalBatch = new Label();
            lblTotalRoastBean = new Label();
            lblTotalGreenBean = new Label();
            tabDashboard = new TabControl();
            tabRiwayatStok = new TabPage();
            dgvRiwayatStokTerbaru = new DataGridView();
            tabPenjualanTerbaru = new TabPage();
            dgvPenjualanTerbaru = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlRingkasan.SuspendLayout();
            tabDashboard.SuspendLayout();
            tabRiwayatStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatStokTerbaru).BeginInit();
            tabPenjualanTerbaru.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanTerbaru).BeginInit();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(221, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Admin";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1024, 90);
            pnlHeader.TabIndex = 1;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(31, 45);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(361, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Ringkasan stok, produksi, dan penjualan SIKOPI DOPY";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.BackColor = Color.Gainsboro;
            pnlRingkasan.Controls.Add(lblOmzetHariIni);
            pnlRingkasan.Controls.Add(lblTransaksiHariIni);
            pnlRingkasan.Controls.Add(lblMenungguHarga);
            pnlRingkasan.Controls.Add(lblProdukSiapJual);
            pnlRingkasan.Controls.Add(lblBatchHariIni);
            pnlRingkasan.Controls.Add(lblTotalBatch);
            pnlRingkasan.Controls.Add(lblTotalRoastBean);
            pnlRingkasan.Controls.Add(lblTotalGreenBean);
            pnlRingkasan.Dock = DockStyle.Top;
            pnlRingkasan.Location = new Point(0, 90);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(1024, 200);
            pnlRingkasan.TabIndex = 2;
            // 
            // lblOmzetHariIni
            // 
            lblOmzetHariIni.BackColor = Color.White;
            lblOmzetHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOmzetHariIni.Location = new Point(775, 105);
            lblOmzetHariIni.Name = "lblOmzetHariIni";
            lblOmzetHariIni.Size = new Size(210, 70);
            lblOmzetHariIni.TabIndex = 7;
            lblOmzetHariIni.Text = "Omzet Hari Ini\\r\\nRp 0";
            lblOmzetHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransaksiHariIni
            // 
            lblTransaksiHariIni.BackColor = Color.White;
            lblTransaksiHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransaksiHariIni.ForeColor = Color.Black;
            lblTransaksiHariIni.Location = new Point(524, 105);
            lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            lblTransaksiHariIni.Size = new Size(210, 70);
            lblTransaksiHariIni.TabIndex = 6;
            lblTransaksiHariIni.Text = "Transaksi Hari Ini\\r\\n0";
            lblTransaksiHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMenungguHarga
            // 
            lblMenungguHarga.BackColor = Color.White;
            lblMenungguHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenungguHarga.Location = new Point(286, 105);
            lblMenungguHarga.Name = "lblMenungguHarga";
            lblMenungguHarga.Size = new Size(210, 70);
            lblMenungguHarga.TabIndex = 5;
            lblMenungguHarga.Text = "Menunggu Harga\\r\\n0";
            lblMenungguHarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProdukSiapJual
            // 
            lblProdukSiapJual.BackColor = Color.White;
            lblProdukSiapJual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdukSiapJual.Location = new Point(35, 105);
            lblProdukSiapJual.Name = "lblProdukSiapJual";
            lblProdukSiapJual.Size = new Size(210, 70);
            lblProdukSiapJual.TabIndex = 4;
            lblProdukSiapJual.Text = "Produk Siap Jual\\r\\n0";
            lblProdukSiapJual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBatchHariIni
            // 
            lblBatchHariIni.BackColor = Color.White;
            lblBatchHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchHariIni.Location = new Point(775, 20);
            lblBatchHariIni.Name = "lblBatchHariIni";
            lblBatchHariIni.Size = new Size(210, 70);
            lblBatchHariIni.TabIndex = 3;
            lblBatchHariIni.Text = "Batch Hari Ini\\r\\n0";
            lblBatchHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalBatch
            // 
            lblTotalBatch.BackColor = Color.White;
            lblTotalBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBatch.Location = new Point(524, 20);
            lblTotalBatch.Name = "lblTotalBatch";
            lblTotalBatch.Size = new Size(210, 70);
            lblTotalBatch.TabIndex = 2;
            lblTotalBatch.Text = "Total Batch\\r\\n0";
            lblTotalBatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRoastBean
            // 
            lblTotalRoastBean.BackColor = Color.White;
            lblTotalRoastBean.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRoastBean.Location = new Point(286, 20);
            lblTotalRoastBean.Name = "lblTotalRoastBean";
            lblTotalRoastBean.Size = new Size(210, 70);
            lblTotalRoastBean.TabIndex = 1;
            lblTotalRoastBean.Text = "Total Roast Bean\\r\\n0 g";
            lblTotalRoastBean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalGreenBean
            // 
            lblTotalGreenBean.BackColor = Color.White;
            lblTotalGreenBean.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalGreenBean.Location = new Point(35, 20);
            lblTotalGreenBean.Name = "lblTotalGreenBean";
            lblTotalGreenBean.Size = new Size(210, 70);
            lblTotalGreenBean.TabIndex = 0;
            lblTotalGreenBean.Text = "Total Green Bean\\r\\n0 Kg";
            lblTotalGreenBean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(tabRiwayatStok);
            tabDashboard.Controls.Add(tabPenjualanTerbaru);
            tabDashboard.Dock = DockStyle.Fill;
            tabDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabDashboard.Location = new Point(0, 290);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.SelectedIndex = 0;
            tabDashboard.Size = new Size(1024, 286);
            tabDashboard.TabIndex = 3;
            // 
            // tabRiwayatStok
            // 
            tabRiwayatStok.Controls.Add(dgvRiwayatStokTerbaru);
            tabRiwayatStok.Location = new Point(4, 29);
            tabRiwayatStok.Name = "tabRiwayatStok";
            tabRiwayatStok.Padding = new Padding(10, 10, 10, 10);
            tabRiwayatStok.Size = new Size(1016, 253);
            tabRiwayatStok.TabIndex = 0;
            tabRiwayatStok.Text = "Riwayat Stok Terbaru";
            tabRiwayatStok.UseVisualStyleBackColor = true;
            // 
            // dgvRiwayatStokTerbaru
            // 
            dgvRiwayatStokTerbaru.AllowUserToAddRows = false;
            dgvRiwayatStokTerbaru.AllowUserToDeleteRows = false;
            dgvRiwayatStokTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatStokTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatStokTerbaru.Dock = DockStyle.Fill;
            dgvRiwayatStokTerbaru.Location = new Point(10, 10);
            dgvRiwayatStokTerbaru.MultiSelect = false;
            dgvRiwayatStokTerbaru.Name = "dgvRiwayatStokTerbaru";
            dgvRiwayatStokTerbaru.ReadOnly = true;
            dgvRiwayatStokTerbaru.RowHeadersWidth = 51;
            dgvRiwayatStokTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatStokTerbaru.Size = new Size(996, 233);
            dgvRiwayatStokTerbaru.TabIndex = 0;
            // 
            // tabPenjualanTerbaru
            // 
            tabPenjualanTerbaru.Controls.Add(dgvPenjualanTerbaru);
            tabPenjualanTerbaru.Location = new Point(4, 29);
            tabPenjualanTerbaru.Name = "tabPenjualanTerbaru";
            tabPenjualanTerbaru.Padding = new Padding(10, 10, 10, 10);
            tabPenjualanTerbaru.Size = new Size(1016, 253);
            tabPenjualanTerbaru.TabIndex = 1;
            tabPenjualanTerbaru.Text = "Penjualan Terbaru";
            tabPenjualanTerbaru.UseVisualStyleBackColor = true;
            // 
            // dgvPenjualanTerbaru
            // 
            dgvPenjualanTerbaru.AllowUserToAddRows = false;
            dgvPenjualanTerbaru.AllowUserToDeleteRows = false;
            dgvPenjualanTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenjualanTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenjualanTerbaru.Dock = DockStyle.Fill;
            dgvPenjualanTerbaru.Location = new Point(10, 10);
            dgvPenjualanTerbaru.MultiSelect = false;
            dgvPenjualanTerbaru.Name = "dgvPenjualanTerbaru";
            dgvPenjualanTerbaru.ReadOnly = true;
            dgvPenjualanTerbaru.RowHeadersWidth = 51;
            dgvPenjualanTerbaru.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenjualanTerbaru.Size = new Size(996, 233);
            dgvPenjualanTerbaru.TabIndex = 1;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 576);
            Controls.Add(tabDashboard);
            Controls.Add(pnlRingkasan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Admin";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRingkasan.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabRiwayatStok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatStokTerbaru).EndInit();
            tabPenjualanTerbaru.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPenjualanTerbaru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblJudul;
        private Panel pnlHeader;
        private Label lblSubJudul;
        private Panel pnlRingkasan;
        private Label lblOmzetHariIni;
        private Label lblTransaksiHariIni;
        private Label lblMenungguHarga;
        private Label lblProdukSiapJual;
        private Label lblBatchHariIni;
        private Label lblTotalBatch;
        private Label lblTotalRoastBean;
        private Label lblTotalGreenBean;
        private TabControl tabDashboard;
        private TabPage tabRiwayatStok;
        private DataGridView dgvRiwayatStokTerbaru;
        private TabPage tabPenjualanTerbaru;
        private DataGridView dgvPenjualanTerbaru;
    }
}