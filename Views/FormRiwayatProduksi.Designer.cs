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
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 112);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(34, 59);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(291, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Riwayat stok dan aktivitas produksi";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(34, 21);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(121, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat";
            // 
            // pnlRingkasan
            // 
            pnlRingkasan.Controls.Add(lblTotalAktivitas);
            pnlRingkasan.Controls.Add(lblJumlahBatch);
            pnlRingkasan.Controls.Add(lblRoastBeanMasuk);
            pnlRingkasan.Controls.Add(lblGreenBeanKeluar);
            pnlRingkasan.Dock = DockStyle.Top;
            pnlRingkasan.Location = new Point(0, 112);
            pnlRingkasan.Margin = new Padding(4, 4, 4, 4);
            pnlRingkasan.Name = "pnlRingkasan";
            pnlRingkasan.Size = new Size(1280, 150);
            pnlRingkasan.TabIndex = 1;
            // 
            // lblTotalAktivitas
            // 
            lblTotalAktivitas.AutoSize = true;
            lblTotalAktivitas.BorderStyle = BorderStyle.FixedSingle;
            lblTotalAktivitas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAktivitas.Location = new Point(1000, 62);
            lblTotalAktivitas.Margin = new Padding(4, 0, 4, 0);
            lblTotalAktivitas.Name = "lblTotalAktivitas";
            lblTotalAktivitas.Size = new Size(133, 27);
            lblTotalAktivitas.TabIndex = 3;
            lblTotalAktivitas.Text = "Aktivitas\\r\\n0";
            lblTotalAktivitas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJumlahBatch
            // 
            lblJumlahBatch.AutoSize = true;
            lblJumlahBatch.BorderStyle = BorderStyle.FixedSingle;
            lblJumlahBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJumlahBatch.Location = new Point(738, 62);
            lblJumlahBatch.Margin = new Padding(4, 0, 4, 0);
            lblJumlahBatch.Name = "lblJumlahBatch";
            lblJumlahBatch.Size = new Size(107, 27);
            lblJumlahBatch.TabIndex = 2;
            lblJumlahBatch.Text = "Batch\\r\\n0";
            lblJumlahBatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoastBeanMasuk
            // 
            lblRoastBeanMasuk.AutoSize = true;
            lblRoastBeanMasuk.BorderStyle = BorderStyle.FixedSingle;
            lblRoastBeanMasuk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoastBeanMasuk.Location = new Point(402, 62);
            lblRoastBeanMasuk.Margin = new Padding(4, 0, 4, 0);
            lblRoastBeanMasuk.Name = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.Size = new Size(182, 27);
            lblRoastBeanMasuk.TabIndex = 1;
            lblRoastBeanMasuk.Text = "lblRoastBeanMasuk";
            lblRoastBeanMasuk.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGreenBeanKeluar
            // 
            lblGreenBeanKeluar.AutoSize = true;
            lblGreenBeanKeluar.BorderStyle = BorderStyle.FixedSingle;
            lblGreenBeanKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreenBeanKeluar.Location = new Point(94, 62);
            lblGreenBeanKeluar.Margin = new Padding(4, 0, 4, 0);
            lblGreenBeanKeluar.Name = "lblGreenBeanKeluar";
            lblGreenBeanKeluar.Size = new Size(171, 27);
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
            dgvRiwayatProduksi.Location = new Point(0, 262);
            dgvRiwayatProduksi.Margin = new Padding(4, 4, 4, 4);
            dgvRiwayatProduksi.MultiSelect = false;
            dgvRiwayatProduksi.Name = "dgvRiwayatProduksi";
            dgvRiwayatProduksi.ReadOnly = true;
            dgvRiwayatProduksi.RowHeadersVisible = false;
            dgvRiwayatProduksi.RowHeadersWidth = 51;
            dgvRiwayatProduksi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatProduksi.Size = new Size(1280, 458);
            dgvRiwayatProduksi.TabIndex = 2;
            // 
            // FormRiwayatProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(dgvRiwayatProduksi);
            Controls.Add(pnlRingkasan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormRiwayatProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRingkasan.ResumeLayout(false);
            pnlRingkasan.PerformLayout();
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