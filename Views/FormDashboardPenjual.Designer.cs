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
            lblJudul = new Label();
            lblSubJudul = new Label();
            pnlRingkasan = new Panel();
            lblTransaksiHariIni = new Label();
            lblOmzetHariIni = new Label();
            lblProdukTerjual = new Label();
            lblTotalTransaksi = new Label();
            pnlHeader.SuspendLayout();
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
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(133, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Penjual";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(269, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Ringkasan penjualan dan transaksi toko";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.Controls.Add(lblTotalTransaksi);
            pnlRingkasan.Controls.Add(lblProdukTerjual);
            pnlRingkasan.Controls.Add(lblOmzetHariIni);
            pnlRingkasan.Controls.Add(lblTransaksiHariIni);
            pnlRingkasan.Dock = DockStyle.Top;
            pnlRingkasan.Location = new Point(0, 90);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(982, 140);
            pnlRingkasan.TabIndex = 1;
            // 
            // lblTransaksiHariIni
            // 
            lblTransaksiHariIni.BorderStyle = BorderStyle.FixedSingle;
            lblTransaksiHariIni.Location = new Point(24, 25);
            lblTransaksiHariIni.Name = "lblTransaksiHariIni";
            lblTransaksiHariIni.Size = new Size(200, 80);
            lblTransaksiHariIni.TabIndex = 0;
            lblTransaksiHariIni.Text = "Transaksi Hari Ini\\r\\n0";
            lblTransaksiHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOmzetHariIni
            // 
            lblOmzetHariIni.BorderStyle = BorderStyle.FixedSingle;
            lblOmzetHariIni.Location = new Point(244, 25);
            lblOmzetHariIni.Name = "lblOmzetHariIni";
            lblOmzetHariIni.Size = new Size(200, 80);
            lblOmzetHariIni.TabIndex = 1;
            lblOmzetHariIni.Text = "Omzet Hari Ini\\r\\nRp 0";
            lblOmzetHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProdukTerjual
            // 
            lblProdukTerjual.BorderStyle = BorderStyle.FixedSingle;
            lblProdukTerjual.Location = new Point(464, 25);
            lblProdukTerjual.Name = "lblProdukTerjual";
            lblProdukTerjual.Size = new Size(200, 80);
            lblProdukTerjual.TabIndex = 2;
            lblProdukTerjual.Text = "Produk Terjual\\r\\n0 g";
            lblProdukTerjual.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalTransaksi
            // 
            lblTotalTransaksi.BorderStyle = BorderStyle.FixedSingle;
            lblTotalTransaksi.Location = new Point(684, 25);
            lblTotalTransaksi.Name = "lblTotalTransaksi";
            lblTotalTransaksi.Size = new Size(200, 80);
            lblTotalTransaksi.TabIndex = 3;
            lblTotalTransaksi.Text = "Total Transaksi\\r\\n0";
            lblTotalTransaksi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDashboardPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlRingkasan);
            Controls.Add(pnlHeader);
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