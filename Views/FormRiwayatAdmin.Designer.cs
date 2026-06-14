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
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(321, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Pergerakan stok dan catatan pembelian produk";
            lblSubJudul.Click += label2_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(61, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat";
            // 
            // tabRiwayat
            // 
            tabRiwayat.Controls.Add(tabPergerakanStok);
            tabRiwayat.Controls.Add(tabTransaksiPenjualan);
            tabRiwayat.Dock = DockStyle.Fill;
            tabRiwayat.Location = new Point(0, 90);
            tabRiwayat.Margin = new Padding(10);
            tabRiwayat.Name = "tabRiwayat";
            tabRiwayat.SelectedIndex = 0;
            tabRiwayat.Size = new Size(982, 463);
            tabRiwayat.TabIndex = 2;
            // 
            // tabPergerakanStok
            // 
            tabPergerakanStok.Controls.Add(dgvRiwayatStok);
            tabPergerakanStok.Location = new Point(4, 29);
            tabPergerakanStok.Name = "tabPergerakanStok";
            tabPergerakanStok.Padding = new Padding(10);
            tabPergerakanStok.Size = new Size(974, 430);
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
            dgvRiwayatStok.Location = new Point(10, 10);
            dgvRiwayatStok.MultiSelect = false;
            dgvRiwayatStok.Name = "dgvRiwayatStok";
            dgvRiwayatStok.ReadOnly = true;
            dgvRiwayatStok.RowHeadersVisible = false;
            dgvRiwayatStok.RowHeadersWidth = 51;
            dgvRiwayatStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatStok.Size = new Size(954, 410);
            dgvRiwayatStok.TabIndex = 0;
            // 
            // tabTransaksiPenjualan
            // 
            tabTransaksiPenjualan.Controls.Add(dgvTransaksiPenjualan);
            tabTransaksiPenjualan.Location = new Point(4, 29);
            tabTransaksiPenjualan.Name = "tabTransaksiPenjualan";
            tabTransaksiPenjualan.Padding = new Padding(10);
            tabTransaksiPenjualan.Size = new Size(974, 430);
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
            dgvTransaksiPenjualan.Location = new Point(10, 10);
            dgvTransaksiPenjualan.MultiSelect = false;
            dgvTransaksiPenjualan.Name = "dgvTransaksiPenjualan";
            dgvTransaksiPenjualan.ReadOnly = true;
            dgvTransaksiPenjualan.RowHeadersVisible = false;
            dgvTransaksiPenjualan.RowHeadersWidth = 51;
            dgvTransaksiPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransaksiPenjualan.Size = new Size(954, 410);
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
            pnlRingkasan.Location = new Point(0, 433);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(982, 120);
            pnlRingkasan.TabIndex = 3;
            // 
            // lblGreenBeanMasuk
            // 
            lblGreenBeanMasuk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGreenBeanMasuk.AutoSize = true;
            lblGreenBeanMasuk.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanMasuk.Location = new Point(24, 20);
            lblGreenBeanMasuk.Name = "lblGreenBeanMasuk";
            lblGreenBeanMasuk.Size = new Size(121, 22);
            lblGreenBeanMasuk.TabIndex = 8;
            lblGreenBeanMasuk.Text = "RB Masuk\\r\\n0 g";
            lblGreenBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanKeluar
            // 
            lblGreenBeanKeluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGreenBeanKeluar.AutoSize = true;
            lblGreenBeanKeluar.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanKeluar.Location = new Point(184, 20);
            lblGreenBeanKeluar.Name = "lblGreenBeanKeluar";
            lblGreenBeanKeluar.Size = new Size(121, 22);
            lblGreenBeanKeluar.TabIndex = 9;
            lblGreenBeanKeluar.Text = "RB Keluar\\r\\n0 g";
            lblGreenBeanKeluar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanMasuk
            // 
            lblRoastBeanMasuk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRoastBeanMasuk.AutoSize = true;
            lblRoastBeanMasuk.BorderStyle = BorderStyle.FixedSingle;
            lblRoastBeanMasuk.Location = new Point(344, 20);
            lblRoastBeanMasuk.Name = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.Size = new Size(95, 22);
            lblRoastBeanMasuk.TabIndex = 10;
            lblRoastBeanMasuk.Text = "Catatan\\r\\n0";
            lblRoastBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanKeluar
            // 
            lblRoastBeanKeluar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblRoastBeanKeluar.AutoSize = true;
            lblRoastBeanKeluar.BorderStyle = BorderStyle.FixedSingle;
            lblRoastBeanKeluar.Location = new Point(504, 20);
            lblRoastBeanKeluar.Name = "lblRoastBeanKeluar";
            lblRoastBeanKeluar.Size = new Size(138, 22);
            lblRoastBeanKeluar.TabIndex = 11;
            lblRoastBeanKeluar.Text = "Total Catat\\r\\nRp 0";
            lblRoastBeanKeluar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJumlahTransaksi
            // 
            lblJumlahTransaksi.AutoSize = true;
            lblJumlahTransaksi.BorderStyle = BorderStyle.FixedSingle;
            lblJumlahTransaksi.Location = new Point(664, 20);
            lblJumlahTransaksi.Name = "lblJumlahTransaksi";
            lblJumlahTransaksi.Size = new Size(131, 22);
            lblJumlahTransaksi.TabIndex = 6;
            lblJumlahTransaksi.Text = "GB Masuk\\r\\n0 Kg";
            lblJumlahTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPenjualan
            // 
            lblTotalPenjualan.AutoSize = true;
            lblTotalPenjualan.BorderStyle = BorderStyle.FixedSingle;
            lblTotalPenjualan.Location = new Point(824, 20);
            lblTotalPenjualan.Name = "lblTotalPenjualan";
            lblTotalPenjualan.Size = new Size(131, 22);
            lblTotalPenjualan.TabIndex = 7;
            lblTotalPenjualan.Text = "GB Keluar\\r\\n0 Kg";
            lblTotalPenjualan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRiwayatAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlRingkasan);
            Controls.Add(tabRiwayat);
            Controls.Add(pnlHeader);
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