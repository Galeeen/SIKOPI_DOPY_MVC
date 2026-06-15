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
            lblSubJudul = new Label();
            lblJudul = new Label();
            tabBahanBaku = new TabControl();
            tabGreenBean = new TabPage();
            dgvGreenBean = new DataGridView();
            tabRoastBean = new TabPage();
            dgvRoastBean = new DataGridView();
            pnlHeader.SuspendLayout();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).BeginInit();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).BeginInit();
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
            lblSubJudul.Location = new Point(32, 56);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(307, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Lihat data green bean dan roast bean";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 18);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(173, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Bahan Baku";
            // 
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabBahanBaku.Location = new Point(0, 112);
            tabBahanBaku.Margin = new Padding(4, 4, 4, 4);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(1280, 608);
            tabBahanBaku.TabIndex = 1;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(dgvGreenBean);
            tabGreenBean.Location = new Point(4, 34);
            tabGreenBean.Margin = new Padding(4, 4, 4, 4);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(12, 12, 12, 12);
            tabGreenBean.Size = new Size(1272, 570);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "Green Bean";
            tabGreenBean.UseVisualStyleBackColor = true;
            // 
            // dgvGreenBean
            // 
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGreenBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenBean.Dock = DockStyle.Fill;
            dgvGreenBean.Location = new Point(12, 12);
            dgvGreenBean.Margin = new Padding(4, 4, 4, 4);
            dgvGreenBean.Name = "dgvGreenBean";
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.RowHeadersWidth = 51;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.Size = new Size(1248, 546);
            dgvGreenBean.TabIndex = 0;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 34);
            tabRoastBean.Margin = new Padding(4, 4, 4, 4);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(12, 12, 12, 12);
            tabRoastBean.Size = new Size(1220, 541);
            tabRoastBean.TabIndex = 1;
            tabRoastBean.Text = "Roast Bean";
            tabRoastBean.UseVisualStyleBackColor = true;
            // 
            // dgvRoastBean
            // 
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastBean.Dock = DockStyle.Fill;
            dgvRoastBean.Location = new Point(12, 12);
            dgvRoastBean.Margin = new Padding(4, 4, 4, 4);
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(1196, 517);
            dgvRoastBean.TabIndex = 1;
            // 
            // FormBahanBakuProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(tabBahanBaku);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBahanBakuProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bahan Baku Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).EndInit();
            tabRoastBean.ResumeLayout(false);
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