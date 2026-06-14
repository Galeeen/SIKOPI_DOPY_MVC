namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormRiwayatPenjualan
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
            dgvRiwayatPenjualan = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPenjualan).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 125);
            pnlHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(128, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat Penjualan";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(260, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Catatan pembelian produk roast bean";
            // 
            // dgvRiwayatPenjualan
            // 
            dgvRiwayatPenjualan.AllowUserToAddRows = false;
            dgvRiwayatPenjualan.AllowUserToDeleteRows = false;
            dgvRiwayatPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPenjualan.Dock = DockStyle.Fill;
            dgvRiwayatPenjualan.Location = new Point(0, 125);
            dgvRiwayatPenjualan.MultiSelect = false;
            dgvRiwayatPenjualan.Name = "dgvRiwayatPenjualan";
            dgvRiwayatPenjualan.ReadOnly = true;
            dgvRiwayatPenjualan.RowHeadersVisible = false;
            dgvRiwayatPenjualan.RowHeadersWidth = 51;
            dgvRiwayatPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatPenjualan.Size = new Size(982, 428);
            dgvRiwayatPenjualan.TabIndex = 1;
            // 
            // FormRiwayatPenjualan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(dgvRiwayatPenjualan);
            Controls.Add(pnlHeader);
            Name = "FormRiwayatPenjualan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat Penjualan";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPenjualan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private DataGridView dgvRiwayatPenjualan;
    }
}