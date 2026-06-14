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
            panel1.Controls.Add(lblSubJudul);
            panel1.Controls.Add(lblJudul);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 0;

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblJudul.Location = new Point(16, 12);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(141, 32);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Bahan Baku";

            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(18, 51);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(291, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Kelola Stok Green Bean & Harga Roast Bean";

            // 
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Location = new Point(0, 90);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(800, 360);
            tabBahanBaku.TabIndex = 1;

            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(dgvGreenBean);
            tabGreenBean.Controls.Add(pnlHeaderGreenBean);
            tabGreenBean.Location = new Point(4, 29);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(8);
            tabGreenBean.Size = new Size(792, 327);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "Green Bean";
            tabGreenBean.UseVisualStyleBackColor = true;

            // 
            // pnlHeaderGreenBean
            // 
            pnlHeaderGreenBean.Controls.Add(btnTambahGreenBean);
            pnlHeaderGreenBean.Dock = DockStyle.Top;
            pnlHeaderGreenBean.Location = new Point(8, 8);
            pnlHeaderGreenBean.Name = "pnlHeaderGreenBean";
            pnlHeaderGreenBean.Size = new Size(776, 50);
            pnlHeaderGreenBean.TabIndex = 0;

            // 
            // btnTambahGreenBean
            // 
            btnTambahGreenBean.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambahGreenBean.Location = new Point(590, 10);
            btnTambahGreenBean.Name = "btnTambahGreenBean";
            btnTambahGreenBean.Size = new Size(172, 32);
            btnTambahGreenBean.TabIndex = 0;
            btnTambahGreenBean.Text = "+ Tambah Green Bean";
            btnTambahGreenBean.UseVisualStyleBackColor = true;

            // 
            // dgvGreenBean
            // 
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGreenBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenBean.Dock = DockStyle.Fill;
            dgvGreenBean.Location = new Point(8, 58);
            dgvGreenBean.MultiSelect = false;
            dgvGreenBean.Name = "dgvGreenBean";
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.RowHeadersVisible = false;
            dgvGreenBean.RowHeadersWidth = 51;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.Size = new Size(776, 261);
            dgvGreenBean.TabIndex = 1;

            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 29);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(8);
            tabRoastBean.Size = new Size(792, 327);
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
            dgvRoastBean.Location = new Point(8, 8);
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(776, 311);
            dgvRoastBean.TabIndex = 0;

            // 
            // FormBahanBakuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabBahanBaku);
            Controls.Add(panel1);
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