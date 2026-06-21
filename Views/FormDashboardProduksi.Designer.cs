namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormDashboardProduksi
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
            lblSubJudu = new Label();
            lblJudul = new Label();
            panel1 = new Panel();
            lblMenungguHarga = new Label();
            lblTotalRoastBean = new Label();
            lblHasilRoastingHariIni = new Label();
            lblGreenBeanHariIni = new Label();
            lblBatchHariIni = new Label();
            lblTotalBatch = new Label();
            panel2 = new Panel();
            dgvBatchTerbaru = new DataGridView();
            lblBatchTerbaru = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatchTerbaru).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblSubJudu);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(901, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudu
            // 
            lblSubJudu.AutoSize = true;
            lblSubJudu.ForeColor = Color.White;
            lblSubJudu.Location = new Point(24, 45);
            lblSubJudu.Name = "lblSubJudu";
            lblSubJudu.Size = new Size(357, 20);
            lblSubJudu.TabIndex = 1;
            lblSubJudu.Text = "Ringkasan aktivitas batch roasting dan hasil produksi";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(246, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Produksi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(lblMenungguHarga);
            panel1.Controls.Add(lblTotalRoastBean);
            panel1.Controls.Add(lblHasilRoastingHariIni);
            panel1.Controls.Add(lblGreenBeanHariIni);
            panel1.Controls.Add(lblBatchHariIni);
            panel1.Controls.Add(lblTotalBatch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(901, 180);
            panel1.TabIndex = 1;
            // 
            // lblMenungguHarga
            // 
            lblMenungguHarga.BackColor = Color.White;
            lblMenungguHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenungguHarga.Location = new Point(649, 100);
            lblMenungguHarga.Name = "lblMenungguHarga";
            lblMenungguHarga.Size = new Size(200, 60);
            lblMenungguHarga.TabIndex = 6;
            lblMenungguHarga.Text = "Produk Menunggu Harga\\r\\n0";
            lblMenungguHarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRoastBean
            // 
            lblTotalRoastBean.BackColor = Color.White;
            lblTotalRoastBean.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRoastBean.Location = new Point(343, 100);
            lblTotalRoastBean.Name = "lblTotalRoastBean";
            lblTotalRoastBean.Size = new Size(200, 60);
            lblTotalRoastBean.TabIndex = 5;
            lblTotalRoastBean.Text = "Total Stok Roast Bean\\r\\n0 g";
            lblTotalRoastBean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHasilRoastingHariIni
            // 
            lblHasilRoastingHariIni.BackColor = Color.White;
            lblHasilRoastingHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHasilRoastingHariIni.Location = new Point(41, 100);
            lblHasilRoastingHariIni.Name = "lblHasilRoastingHariIni";
            lblHasilRoastingHariIni.Size = new Size(200, 60);
            lblHasilRoastingHariIni.TabIndex = 4;
            lblHasilRoastingHariIni.Text = "Hasil Roasting Hari Ini\\r\\n0 g";
            lblHasilRoastingHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanHariIni
            // 
            lblGreenBeanHariIni.BackColor = Color.White;
            lblGreenBeanHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanHariIni.Location = new Point(649, 15);
            lblGreenBeanHariIni.Name = "lblGreenBeanHariIni";
            lblGreenBeanHariIni.Size = new Size(200, 60);
            lblGreenBeanHariIni.TabIndex = 2;
            lblGreenBeanHariIni.Text = "Green Bean Dipakai Hari Ini\\r\\n0 g";
            lblGreenBeanHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBatchHariIni
            // 
            lblBatchHariIni.BackColor = Color.White;
            lblBatchHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchHariIni.ForeColor = Color.Black;
            lblBatchHariIni.Location = new Point(343, 15);
            lblBatchHariIni.Name = "lblBatchHariIni";
            lblBatchHariIni.Size = new Size(200, 60);
            lblBatchHariIni.TabIndex = 1;
            lblBatchHariIni.Text = "Batch Hari Ini\\r\\n0";
            lblBatchHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalBatch
            // 
            lblTotalBatch.BackColor = Color.White;
            lblTotalBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBatch.Location = new Point(41, 15);
            lblTotalBatch.Name = "lblTotalBatch";
            lblTotalBatch.Size = new Size(200, 60);
            lblTotalBatch.TabIndex = 0;
            lblTotalBatch.Text = "Total Batch\\r\\n0";
            lblTotalBatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBatchTerbaru);
            panel2.Controls.Add(lblBatchTerbaru);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 270);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(24, 10, 24, 10);
            panel2.Size = new Size(901, 180);
            panel2.TabIndex = 2;
            // 
            // dgvBatchTerbaru
            // 
            dgvBatchTerbaru.AllowUserToAddRows = false;
            dgvBatchTerbaru.AllowUserToDeleteRows = false;
            dgvBatchTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchTerbaru.Dock = DockStyle.Fill;
            dgvBatchTerbaru.Location = new Point(24, 30);
            dgvBatchTerbaru.MultiSelect = false;
            dgvBatchTerbaru.Name = "dgvBatchTerbaru";
            dgvBatchTerbaru.ReadOnly = true;
            dgvBatchTerbaru.RowHeadersVisible = false;
            dgvBatchTerbaru.RowHeadersWidth = 51;
            dgvBatchTerbaru.Size = new Size(853, 140);
            dgvBatchTerbaru.TabIndex = 1;
            // 
            // lblBatchTerbaru
            // 
            lblBatchTerbaru.AutoSize = true;
            lblBatchTerbaru.Dock = DockStyle.Top;
            lblBatchTerbaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchTerbaru.Location = new Point(24, 10);
            lblBatchTerbaru.Name = "lblBatchTerbaru";
            lblBatchTerbaru.Size = new Size(173, 20);
            lblBatchTerbaru.TabIndex = 0;
            lblBatchTerbaru.Text = "Batch Roasting Terbaru";
            lblBatchTerbaru.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormDashboardProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Name = "FormDashboardProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatchTerbaru).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudu;
        private Label lblJudul;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblBatchTerbaru;
        private Label lblBatchHariIni;
        private Label lblTotalBatch;
        private Label lblMenungguHarga;
        private Label lblTotalRoastBean;
        private Label lblHasilRoastingHariIni;
        private Label lblGreenBeanHariIni;
        private Panel panel2;
        private DataGridView dgvBatchTerbaru;
    }
}