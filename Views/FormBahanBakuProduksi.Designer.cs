namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormBahanBakuProduksi
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
            tabBahanBaku = new TabControl();
            tabGreenBean = new TabPage();
            tabRoastBean = new TabPage();
            lblJudul = new Label();
            lblSubJudul = new Label();
            dgvGreenBean = new DataGridView();
            dgvRoastBean = new DataGridView();
            pnlHeader.SuspendLayout();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).BeginInit();
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
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Location = new Point(0, 90);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(982, 463);
            tabBahanBaku.TabIndex = 1;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(dgvGreenBean);
            tabGreenBean.Location = new Point(4, 29);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(10);
            tabGreenBean.Size = new Size(974, 430);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "Green Bean";
            tabGreenBean.UseVisualStyleBackColor = true;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 29);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(10);
            tabRoastBean.Size = new Size(974, 430);
            tabRoastBean.TabIndex = 1;
            tabRoastBean.Text = "Roast Bean";
            tabRoastBean.UseVisualStyleBackColor = true;
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
            lblSubJudul.Size = new Size(257, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Lihat data green bean dan roast bean";
            // 
            // dgvGreenBean
            // 
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGreenBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenBean.Dock = DockStyle.Fill;
            dgvGreenBean.Location = new Point(10, 10);
            dgvGreenBean.Name = "dgvGreenBean";
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.RowHeadersWidth = 51;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.Size = new Size(954, 410);
            dgvGreenBean.TabIndex = 0;
            // 
            // dgvRoastBean
            // 
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastBean.Dock = DockStyle.Fill;
            dgvRoastBean.Location = new Point(10, 10);
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(954, 410);
            dgvRoastBean.TabIndex = 1;
            // 
            // FormBahanBakuProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabBahanBaku);
            Controls.Add(pnlHeader);
            Name = "FormBahanBakuProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bahan Baku Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private TabControl tabBahanBaku;
        private TabPage tabGreenBean;
        private TabPage tabRoastBean;
        private Label lblSubJudul;
        private Label lblJudul;
        private DataGridView dgvGreenBean;
        private DataGridView dgvRoastBean;
    }
}