namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormBahanBakuPenjual
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
            dgvRoastBean = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).BeginInit();
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
            lblJudul.Size = new Size(86, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Bahan Baku";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(344, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Lihat data roast bean, stok, harga, dan status harga";
            // 
            // dgvRoastBean
            // 
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastBean.Dock = DockStyle.Fill;
            dgvRoastBean.Location = new Point(0, 90);
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(982, 463);
            dgvRoastBean.TabIndex = 1;
            // 
            // FormBahanBakuPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(dgvRoastBean);
            Controls.Add(pnlHeader);
            Name = "FormBahanBakuPenjual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bahan Baku Penjual";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private DataGridView dgvRoastBean;
    }
}