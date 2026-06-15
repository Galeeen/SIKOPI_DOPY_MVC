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
            lblSubJudul = new Label();
            lblJudul = new Label();
            dgvRiwayatPenjualan = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPenjualan).BeginInit();
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
            pnlHeader.Size = new Size(1280, 156);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(34, 69);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(312, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Catatan pembelian produk roast bean";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(34, 31);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(257, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat Penjualan";
            // 
            // dgvRiwayatPenjualan
            // 
            dgvRiwayatPenjualan.AllowUserToAddRows = false;
            dgvRiwayatPenjualan.AllowUserToDeleteRows = false;
            dgvRiwayatPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRiwayatPenjualan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPenjualan.Dock = DockStyle.Fill;
            dgvRiwayatPenjualan.Location = new Point(0, 156);
            dgvRiwayatPenjualan.Margin = new Padding(4, 4, 4, 4);
            dgvRiwayatPenjualan.MultiSelect = false;
            dgvRiwayatPenjualan.Name = "dgvRiwayatPenjualan";
            dgvRiwayatPenjualan.ReadOnly = true;
            dgvRiwayatPenjualan.RowHeadersVisible = false;
            dgvRiwayatPenjualan.RowHeadersWidth = 51;
            dgvRiwayatPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRiwayatPenjualan.Size = new Size(1280, 564);
            dgvRiwayatPenjualan.TabIndex = 1;
            // 
            // FormRiwayatPenjualan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(dgvRiwayatPenjualan);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
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