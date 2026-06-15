namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormBahanBakuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            tabBahanBaku = new TabControl();
            tabGreenBean = new TabPage();
            dgvGreenBean = new DataGridView();
            pnlHeaderGreenBean = new Panel();
            btnTambahGreenBean = new Button();
            tabRoastBean = new TabPage();
            dgvRoastBean = new DataGridView();
            panel1.SuspendLayout();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).BeginInit();
            pnlHeaderGreenBean.SuspendLayout();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(79, 70, 229);
            panel1.Controls.Add(lblSubJudul);
            panel1.Controls.Add(lblJudul);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 112);
            panel1.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(22, 64);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(373, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Kelola Stok Green Bean dan Harga Roast Bean";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(20, 15);
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
            tabBahanBaku.Margin = new Padding(4);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(1280, 608);
            tabBahanBaku.TabIndex = 1;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(dgvGreenBean);
            tabGreenBean.Controls.Add(pnlHeaderGreenBean);
            tabGreenBean.Location = new Point(4, 34);
            tabGreenBean.Margin = new Padding(4);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(10);
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
            dgvGreenBean.Location = new Point(10, 72);
            dgvGreenBean.Margin = new Padding(4);
            dgvGreenBean.MultiSelect = false;
            dgvGreenBean.Name = "dgvGreenBean";
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.RowHeadersWidth = 51;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.Size = new Size(1252, 488);
            dgvGreenBean.TabIndex = 1;
            // 
            // pnlHeaderGreenBean
            // 
            pnlHeaderGreenBean.Controls.Add(btnTambahGreenBean);
            pnlHeaderGreenBean.Dock = DockStyle.Top;
            pnlHeaderGreenBean.Location = new Point(10, 10);
            pnlHeaderGreenBean.Margin = new Padding(4);
            pnlHeaderGreenBean.Name = "pnlHeaderGreenBean";
            pnlHeaderGreenBean.Size = new Size(1252, 62);
            pnlHeaderGreenBean.TabIndex = 0;
            // 
            // btnTambahGreenBean
            // 
            btnTambahGreenBean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambahGreenBean.BackColor = Color.FromArgb(79, 70, 229);
            btnTambahGreenBean.ForeColor = SystemColors.ButtonHighlight;
            btnTambahGreenBean.Location = new Point(1020, 12);
            btnTambahGreenBean.Margin = new Padding(4);
            btnTambahGreenBean.Name = "btnTambahGreenBean";
            btnTambahGreenBean.Size = new Size(215, 40);
            btnTambahGreenBean.TabIndex = 0;
            btnTambahGreenBean.Text = "+ Tambah Green Bean";
            btnTambahGreenBean.UseVisualStyleBackColor = false;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 34);
            tabRoastBean.Margin = new Padding(4);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(10);
            tabRoastBean.Size = new Size(1272, 570);
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
            dgvRoastBean.Location = new Point(10, 10);
            dgvRoastBean.Margin = new Padding(4);
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(1252, 550);
            dgvRoastBean.TabIndex = 0;
            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(tabBahanBaku);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormBahanBakuAdmin";
            Text = "Bahan Baku";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).EndInit();
            pnlHeaderGreenBean.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblSubJudul;
        private Label lblJudul;

        private TabControl tabBahanBaku;
        private TabPage tabGreenBean;
        private TabPage tabRoastBean;

        private Panel pnlHeaderGreenBean;
        private Button btnTambahGreenBean;

        private DataGridView dgvGreenBean;
        private DataGridView dgvRoastBean;
    }
}