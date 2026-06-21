namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormRiwayatProduksi
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
            lblTotalAktivitas = new Label();
            lblJumlahBatch = new Label();
            lblRoastBeanMasuk = new Label();
            lblGreenBeanKeluar = new Label();
            dgvRiwayatProduksi = new DataGridView();
            pnlHeader.SuspendLayout();
            pnlRingkasan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatProduksi).BeginInit();
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
            lblSubJudul.Location = new Point(27, 47);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(240, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Riwayat stok dan aktivitas produksi";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(27, 17);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(104, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.BackColor = Color.Gainsboro;
            pnlRingkasan.Controls.Add(lblTotalAktivitas);
            pnlRingkasan.Controls.Add(lblJumlahBatch);
            pnlRingkasan.Controls.Add(lblRoastBeanMasuk);
            pnlRingkasan.Controls.Add(lblGreenBeanKeluar);
            pnlRingkasan.Dock = DockStyle.Top;
            pnlRingkasan.Location = new Point(0, 90);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(1024, 120);
            pnlRingkasan.TabIndex = 1;
            // 
            // lblTotalAktivitas
            // 
            lblTotalAktivitas.BackColor = Color.White;
            lblTotalAktivitas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAktivitas.Location = new Point(783, 30);
            lblTotalAktivitas.Name = "lblTotalAktivitas";
            lblTotalAktivitas.Size = new Size(200, 60);
            lblTotalAktivitas.TabIndex = 3;
            lblTotalAktivitas.Text = "Aktivitas\\r\\n0";
            lblTotalAktivitas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJumlahBatch
            // 
            lblJumlahBatch.BackColor = Color.White;
            lblJumlahBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahBatch.Location = new Point(527, 30);
            lblJumlahBatch.Name = "lblJumlahBatch";
            lblJumlahBatch.Size = new Size(200, 60);
            lblJumlahBatch.TabIndex = 2;
            lblJumlahBatch.Text = "Batch\\r\\n0";
            lblJumlahBatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanMasuk
            // 
            lblRoastBeanMasuk.BackColor = Color.White;
            lblRoastBeanMasuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoastBeanMasuk.Location = new Point(278, 30);
            lblRoastBeanMasuk.Name = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.Size = new Size(200, 60);
            lblRoastBeanMasuk.TabIndex = 1;
            lblRoastBeanMasuk.Text = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanKeluar
            // 
            lblGreenBeanKeluar.BackColor = Color.White;
            lblGreenBeanKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanKeluar.Location = new Point(27, 30);
            lblGreenBeanKeluar.Name = "lblGreenBeanKeluar";
            lblGreenBeanKeluar.Size = new Size(200, 60);
            lblGreenBeanKeluar.TabIndex = 0;
            lblGreenBeanKeluar.Text = "GB Keluar\\r\\n0 Kg";
            lblGreenBeanKeluar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvRiwayatProduksi
            // 
            dgvRiwayatProduksi.AllowUserToAddRows = false;
            dgvRiwayatProduksi.AllowUserToDeleteRows = false;
            dgvRiwayatProduksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatProduksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatProduksi.Dock = DockStyle.Fill;
            dgvRiwayatProduksi.Location = new Point(0, 210);
            dgvRiwayatProduksi.MultiSelect = false;
            dgvRiwayatProduksi.Name = "dgvRiwayatProduksi";
            dgvRiwayatProduksi.ReadOnly = true;
            dgvRiwayatProduksi.RowHeadersVisible = false;
            dgvRiwayatProduksi.RowHeadersWidth = 51;
            dgvRiwayatProduksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatProduksi.Size = new Size(1024, 366);
            dgvRiwayatProduksi.TabIndex = 2;
            // 
            // FormRiwayatProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 576);
            Controls.Add(dgvRiwayatProduksi);
            Controls.Add(pnlRingkasan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRiwayatProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRingkasan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatProduksi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private Panel pnlRingkasan;
        private Label lblTotalAktivitas;
        private Label lblJumlahBatch;
        private Label lblRoastBeanMasuk;
        private Label lblGreenBeanKeluar;
        private DataGridView dgvRiwayatProduksi;
    }
}