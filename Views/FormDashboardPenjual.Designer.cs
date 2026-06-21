namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDashboardPenjual
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
            pnlRingkasan = new Panel();
            lblTotalTransaksi = new Label();
            lblProdukTerjual = new Label();
            lblOmzetHariIni = new Label();
            lblTransaksiHariIni = new Label();
            pnlHeader.SuspendLayout();
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
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1024, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(26, 45);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(269, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Ringkasan penjualan dan transaksi toko";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(229, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Penjual";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.BackColor = Color.Gainsboro;
            pnlRingkasan.Controls.Add(lblTotalTransaksi);
            pnlRingkasan.Controls.Add(lblProdukTerjual);
            pnlRingkasan.Controls.Add(lblOmzetHariIni);
            pnlRingkasan.Controls.Add(lblTransaksiHariIni);
            pnlRingkasan.Dock = DockStyle.Top;
            pnlRingkasan.Location = new Point(0, 90);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(1024, 140);
            pnlRingkasan.TabIndex = 1;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.BackColor = Color.White;
            lblTotalTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransaksi.Location = new Point(781, 25);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(200, 80);
            lblTotalTransaksi.TabIndex = 3;
            lblTotalTransaksi.Text = "Total Transaksi\\r\\n0";
            lblTotalTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProdukTerjual
            // 
            lblProdukTerjual.BackColor = Color.White;
            lblProdukTerjual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProdukTerjual.Location = new Point(533, 25);
            lblProdukTerjual.Name = "lblProdukTerjual";
            lblProdukTerjual.Size = new Size(200, 80);
            lblProdukTerjual.TabIndex = 2;
            lblProdukTerjual.Text = "Produk Terjual\\r\\n0 g";
            lblProdukTerjual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOmzetHariIni
            // 
            lblOmzetHariIni.BackColor = Color.White;
            lblOmzetHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOmzetHariIni.Location = new Point(286, 25);
            lblOmzetHariIni.Name = "lblOmzetHariIni";
            lblOmzetHariIni.Size = new Size(200, 80);
            lblOmzetHariIni.TabIndex = 1;
            lblOmzetHariIni.Text = "Omzet Hari Ini\\r\\nRp 0";
            lblOmzetHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTransaksiHariIni
            // 
            lblTransaksiHariIni.BackColor = Color.White;
            lblTransaksiHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransaksiHariIni.Location = new Point(43, 25);
            lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            lblTransaksiHariIni.Size = new Size(200, 80);
            lblTransaksiHariIni.TabIndex = 0;
            lblTransaksiHariIni.Text = "Transaksi Hari Ini\\r\\n0";
            lblTransaksiHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDashboardPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 576);
            Controls.Add(pnlRingkasan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboardPenjual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Penjual";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRingkasan.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private Panel pnlRingkasan;
        private Label lblTotalTransaksi;
        private Label lblProdukTerjual;
        private Label lblOmzetHariIni;
        private Label lblTransaksiHariIni;
    }
}