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
            lblJudul = new Label();
            lblSubJudul = new Label();
            btnTambahBatch = new Button();
            tabBatchProduksi = new TabControl();
            tabBatchRoasting = new TabPage();
            tabRoastBean = new TabPage();
            dgvBatchRoasting = new DataGridView();
            dgvRoastBean = new DataGridView();
            pnlHeader.SuspendLayout();
            tabBatchProduksi.SuspendLayout();
            tabBatchRoasting.SuspendLayout();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoastBean).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnTambahBatch);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(982, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(108, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Batch Roasting";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(312, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Input batch roasting dan lihat data roast bean";
            // 
            // btnTambahBatch
            // 
            btnTambahBatch.Location = new Point(800, 28);
            btnTambahBatch.Name = "btnTambahBatch";
            btnTambahBatch.Size = new Size(145, 29);
            btnTambahBatch.TabIndex = 2;
            btnTambahBatch.Text = "+ Tambah Batch";
            btnTambahBatch.UseVisualStyleBackColor = true;
                     // 
            // tabBatchProduksi
            // 
            tabBatchProduksi.Controls.Add(tabBatchRoasting);
            tabBatchProduksi.Controls.Add(tabRoastBean);
            tabBatchProduksi.Dock = DockStyle.Fill;
            tabBatchProduksi.Location = new Point(0, 100);
            tabBatchProduksi.Name = "tabBatchProduksi";
            tabBatchProduksi.SelectedIndex = 0;
            tabBatchProduksi.Size = new Size(982, 453);
            tabBatchProduksi.TabIndex = 1;
            // 
            // tabBatchRoasting
            // 
            tabBatchRoasting.Controls.Add(dgvBatchRoasting);
            tabBatchRoasting.Location = new Point(4, 29);
            tabBatchRoasting.Name = "tabBatchRoasting";
            tabBatchRoasting.Padding = new Padding(10);
            tabBatchRoasting.Size = new Size(974, 420);
            tabBatchRoasting.TabIndex = 0;
            tabBatchRoasting.Text = "Batch Roasting";
            tabBatchRoasting.UseVisualStyleBackColor = true;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvRoastBean);
            tabRoastBean.Location = new Point(4, 29);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(10);
            tabRoastBean.Size = new Size(974, 420);
            tabRoastBean.TabIndex = 1;
            tabRoastBean.Text = "Roast Bean";
            tabRoastBean.UseVisualStyleBackColor = true;
            // 
            // dgvBatchRoasting
            // 
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchRoasting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchRoasting.Dock = DockStyle.Fill;
            dgvBatchRoasting.Location = new Point(10, 10);
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.Name = "dgvBatchRoasting";
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.RowHeadersVisible = false;
            dgvBatchRoasting.RowHeadersWidth = 51;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.Size = new Size(954, 400);
            dgvBatchRoasting.TabIndex = 0;
            // 
            // dgvRoastBean
            // 
            dgvRoastBean.AllowUserToAddRows = false;
            dgvRoastBean.AllowUserToDeleteRows = false;
            dgvRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoastBean.Dock = DockStyle.Fill;
            dgvRoastBean.Location = new Point(10, 10);
            dgvRoastBean.MultiSelect = false;
            dgvRoastBean.Name = "dgvRoastBean";
            dgvRoastBean.ReadOnly = true;
            dgvRoastBean.RowHeadersVisible = false;
            dgvRoastBean.RowHeadersWidth = 51;
            dgvRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoastBean.Size = new Size(954, 400);
            dgvRoastBean.TabIndex = 1;
            // 
            // FormBatchRoastingProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(tabBatchProduksi);
            Controls.Add(pnlHeader);
            Name = "FormBatchRoastingProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Batch Roasting Produksi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tabBatchProduksi.ResumeLayout(false);
            tabBatchRoasting.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).EndInit();
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