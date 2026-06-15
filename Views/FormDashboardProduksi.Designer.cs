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
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1126, 112);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudu
            // 
            lblSubJudu.AutoSize = true;
            lblSubJudu.ForeColor = Color.White;
            lblSubJudu.Location = new Point(30, 56);
            lblSubJudu.Margin = new Padding(4, 0, 4, 0);
            lblSubJudu.Name = "lblSubJudu";
            lblSubJudu.Size = new Size(431, 25);
            lblSubJudu.TabIndex = 1;
            lblSubJudu.Text = "Ringkasan aktivitas batch roasting dan hasil produksi";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 18);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(282, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Dashboard Produksi";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMenungguHarga);
            panel1.Controls.Add(lblTotalRoastBean);
            panel1.Controls.Add(lblHasilRoastingHariIni);
            panel1.Controls.Add(lblGreenBeanHariIni);
            panel1.Controls.Add(lblBatchHariIni);
            panel1.Controls.Add(lblTotalBatch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 112);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 225);
            panel1.TabIndex = 1;
            // 
            // lblMenungguHarga
            // 
            lblMenungguHarga.AutoSize = true;
            lblMenungguHarga.BorderStyle = BorderStyle.FixedSingle;
            lblMenungguHarga.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenungguHarga.Location = new Point(780, 119);
            lblMenungguHarga.Margin = new Padding(4, 0, 4, 0);
            lblMenungguHarga.Name = "lblMenungguHarga";
            lblMenungguHarga.Size = new Size(274, 27);
            lblMenungguHarga.TabIndex = 6;
            lblMenungguHarga.Text = "Produk Menunggu Harga\\r\\n0";
            lblMenungguHarga.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalRoastBean
            // 
            lblTotalRoastBean.AutoSize = true;
            lblTotalRoastBean.BorderStyle = BorderStyle.FixedSingle;
            lblTotalRoastBean.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRoastBean.Location = new Point(410, 119);
            lblTotalRoastBean.Margin = new Padding(4, 0, 4, 0);
            lblTotalRoastBean.Name = "lblTotalRoastBean";
            lblTotalRoastBean.Size = new Size(260, 27);
            lblTotalRoastBean.TabIndex = 5;
            lblTotalRoastBean.Text = "Total Stok Roast Bean\\r\\n0 g";
            lblTotalRoastBean.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHasilRoastingHariIni
            // 
            lblHasilRoastingHariIni.AutoSize = true;
            lblHasilRoastingHariIni.BorderStyle = BorderStyle.FixedSingle;
            lblHasilRoastingHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHasilRoastingHariIni.Location = new Point(30, 119);
            lblHasilRoastingHariIni.Margin = new Padding(4, 0, 4, 0);
            lblHasilRoastingHariIni.Name = "lblHasilRoastingHariIni";
            lblHasilRoastingHariIni.Size = new Size(264, 27);
            lblHasilRoastingHariIni.TabIndex = 4;
            lblHasilRoastingHariIni.Text = "Hasil Roasting Hari Ini\\r\\n0 g";
            lblHasilRoastingHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanHariIni
            // 
            lblGreenBeanHariIni.AutoSize = true;
            lblGreenBeanHariIni.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanHariIni.Location = new Point(780, 40);
            lblGreenBeanHariIni.Margin = new Padding(4, 0, 4, 0);
            lblGreenBeanHariIni.Name = "lblGreenBeanHariIni";
            lblGreenBeanHariIni.Size = new Size(310, 27);
            lblGreenBeanHariIni.TabIndex = 2;
            lblGreenBeanHariIni.Text = "Green Bean Dipakai Hari Ini\\r\\n0 g";
            lblGreenBeanHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBatchHariIni
            // 
            lblBatchHariIni.AutoSize = true;
            lblBatchHariIni.BorderStyle = BorderStyle.FixedSingle;
            lblBatchHariIni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchHariIni.ForeColor = Color.Black;
            lblBatchHariIni.Location = new Point(447, 40);
            lblBatchHariIni.Margin = new Padding(4, 0, 4, 0);
            lblBatchHariIni.Name = "lblBatchHariIni";
            lblBatchHariIni.Size = new Size(175, 27);
            lblBatchHariIni.TabIndex = 1;
            lblBatchHariIni.Text = "Batch Hari Ini\\r\\n0";
            lblBatchHariIni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalBatch
            // 
            lblTotalBatch.AutoSize = true;
            lblTotalBatch.BorderStyle = BorderStyle.FixedSingle;
            lblTotalBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBatch.Location = new Point(68, 40);
            lblTotalBatch.Margin = new Padding(4, 0, 4, 0);
            lblTotalBatch.Name = "lblTotalBatch";
            lblTotalBatch.Size = new Size(154, 27);
            lblTotalBatch.TabIndex = 0;
            lblTotalBatch.Text = "Total Batch\\r\\n0";
            lblTotalBatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBatchTerbaru);
            panel2.Controls.Add(lblBatchTerbaru);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 337);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30, 12, 30, 12);
            panel2.Size = new Size(1126, 225);
            panel2.TabIndex = 2;
            // 
            // dgvBatchTerbaru
            // 
            dgvBatchTerbaru.AllowUserToAddRows = false;
            dgvBatchTerbaru.AllowUserToDeleteRows = false;
            dgvBatchTerbaru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchTerbaru.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchTerbaru.Dock = DockStyle.Fill;
            dgvBatchTerbaru.Location = new Point(30, 37);
            dgvBatchTerbaru.Margin = new Padding(4, 4, 4, 4);
            dgvBatchTerbaru.MultiSelect = false;
            dgvBatchTerbaru.Name = "dgvBatchTerbaru";
            dgvBatchTerbaru.ReadOnly = true;
            dgvBatchTerbaru.RowHeadersVisible = false;
            dgvBatchTerbaru.RowHeadersWidth = 51;
            dgvBatchTerbaru.Size = new Size(1066, 176);
            dgvBatchTerbaru.TabIndex = 1;
            // 
            // lblBatchTerbaru
            // 
            lblBatchTerbaru.AutoSize = true;
            lblBatchTerbaru.Dock = DockStyle.Top;
            lblBatchTerbaru.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBatchTerbaru.Location = new Point(30, 12);
            lblBatchTerbaru.Margin = new Padding(4, 0, 4, 0);
            lblBatchTerbaru.Name = "lblBatchTerbaru";
            lblBatchTerbaru.Size = new Size(211, 25);
            lblBatchTerbaru.TabIndex = 0;
            lblBatchTerbaru.Text = "Batch Roasting Terbaru";
            lblBatchTerbaru.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormDashboardProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 562);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDashboardProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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