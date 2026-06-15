namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormBatchRoastingProduksi
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
            btnTambahBatch = new Button();
            lblSubJudul = new Label();
            lblJudul = new Label();
            tabBatchProduksi = new TabControl();
            tabBatchRoasting = new TabPage();
            dgvBatchRoasting = new DataGridView();
            tabRoastBean = new TabPage();
            dgvRoastBean = new DataGridView();
            pnlHeader.SuspendLayout();
            tabBatchProduksi.SuspendLayout();
            tabBatchRoasting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).BeginInit();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(btnTambahBatch);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1280, 125);
            pnlHeader.TabIndex = 0;
            // 
            // btnTambahBatch
            // 
            btnTambahBatch.BackColor = Color.White;
            btnTambahBatch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahBatch.Location = new Point(1065, 45);
            btnTambahBatch.Margin = new Padding(4, 4, 4, 4);
            btnTambahBatch.Name = "btnTambahBatch";
            btnTambahBatch.Size = new Size(199, 36);
            btnTambahBatch.TabIndex = 2;
            btnTambahBatch.Text = "+ Tambah Batch";
            btnTambahBatch.UseVisualStyleBackColor = false;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(32, 56);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(375, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Input batch roasting dan lihat data roast bean";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.BackColor = Color.FromArgb(79, 70, 229);
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 18);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(213, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Batch Roasting";
            // 
            // tabBatchProduksi
            // 
            tabBatchProduksi.Controls.Add(tabBatchRoasting);
            tabBatchProduksi.Controls.Add(tabRoastBean);
            tabBatchProduksi.Dock = DockStyle.Fill;
            tabBatchProduksi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabBatchProduksi.Location = new Point(0, 125);
            tabBatchProduksi.Margin = new Padding(4, 4, 4, 4);
            tabBatchProduksi.Name = "tabBatchProduksi";
            tabBatchProduksi.SelectedIndex = 0;
            tabBatchProduksi.Size = new Size(1280, 595);
            tabBatchProduksi.TabIndex = 1;
            // 
            // tabBatchRoasting
            // 
            tabBatchRoasting.Controls.Add(dgvBatchRoasting);
            tabBatchRoasting.Location = new Point(4, 34);
            tabBatchRoasting.Margin = new Padding(4, 4, 4, 4);
            tabBatchRoasting.Name = "tabBatchRoasting";
            tabBatchRoasting.Padding = new Padding(12, 12, 12, 12);
            tabBatchRoasting.Size = new Size(1272, 557);
            tabBatchRoasting.TabIndex = 0;
            tabBatchRoasting.Text = "Batch Roasting";
            tabBatchRoasting.UseVisualStyleBackColor = true;
            // 
            // dgvBatchRoasting
            // 
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchRoasting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchRoasting.Dock = DockStyle.Fill;
            dgvBatchRoasting.Location = new Point(12, 12);
            dgvBatchRoasting.Margin = new Padding(4, 4, 4, 4);
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.Name = "dgvBatchRoasting";
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.RowHeadersVisible = false;
            dgvBatchRoasting.RowHeadersWidth = 51;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.Size = new Size(1248, 533);
            dgvBatchRoasting.TabIndex = 0;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 34);
            tabRoastBean.Margin = new Padding(4, 4, 4, 4);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(12, 12, 12, 12);
            tabRoastBean.Size = new Size(1220, 528);
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
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(1196, 504);
            dgvRoastBean.TabIndex = 1;
            // 
            // FormBatchRoastingProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(tabBatchProduksi);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBatchRoastingProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Roasting Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabBatchProduksi.ResumeLayout(false);
            tabBatchRoasting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).EndInit();
            tabRoastBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnTambahBatch;
        private Label lblSubJudul;
        private Label lblJudul;
        private TabControl tabBatchProduksi;
        private TabPage tabBatchRoasting;
        private TabPage tabRoastBean;
        private DataGridView dgvBatchRoasting;
        private DataGridView dgvRoastBean;
    }
}