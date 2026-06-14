namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormBatchRoastingAdmin
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
            btnTambahBatch = new Button();
            dgvBatchRoasting = new DataGridView();
            tabBahanBaku = new TabControl();
            tabGreenBean = new TabPage();
            tabRoastBean = new TabPage();
            pnlHeaderGreenBean = new Panel();
            dvgRoastBean = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).BeginInit();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            tabRoastBean.SuspendLayout();
            pnlHeaderGreenBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRoastBean).BeginInit();
            SuspendLayout();
            // 
            // btnTambahBatch
            // 
            btnTambahBatch.Cursor = Cursors.Hand;
            btnTambahBatch.Location = new Point(647, 16);
            btnTambahBatch.Name = "btnTambahBatch";
            btnTambahBatch.Size = new Size(134, 29);
            btnTambahBatch.TabIndex = 0;
            btnTambahBatch.Text = "+ Tambah Batch";
            btnTambahBatch.UseVisualStyleBackColor = true;
            btnTambahBatch.Click += btnTambahBatch_Click_1;
            // 
            // dgvBatchRoasting
            // 
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchRoasting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchRoasting.Dock = DockStyle.Bottom;
            dgvBatchRoasting.Location = new Point(3, 54);
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.Name = "dgvBatchRoasting";
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.RowHeadersWidth = 51;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.Size = new Size(786, 360);
            dgvBatchRoasting.TabIndex = 1;
            // 
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Location = new Point(0, 0);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(800, 450);
            tabBahanBaku.TabIndex = 2;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(pnlHeaderGreenBean);
            tabGreenBean.Controls.Add(dgvBatchRoasting);
            tabGreenBean.Location = new Point(4, 29);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(3);
            tabGreenBean.Size = new Size(792, 417);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "GreenBean";
            tabGreenBean.UseVisualStyleBackColor = true;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dvgRoastBean);
            tabRoastBean.Location = new Point(4, 29);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(3);
            tabRoastBean.Size = new Size(792, 417);
            tabRoastBean.TabIndex = 1;
            tabRoastBean.Text = "Roast Bean";
            tabRoastBean.UseVisualStyleBackColor = true;
            // 
            // pnlHeaderGreenBean
            // 
            pnlHeaderGreenBean.Controls.Add(btnTambahBatch);
            pnlHeaderGreenBean.Dock = DockStyle.Top;
            pnlHeaderGreenBean.Location = new Point(3, 3);
            pnlHeaderGreenBean.Name = "pnlHeaderGreenBean";
            pnlHeaderGreenBean.Size = new Size(786, 55);
            pnlHeaderGreenBean.TabIndex = 2;
            // 
            // dvgRoastBean
            // 
            dvgRoastBean.AllowUserToAddRows = false;
            dvgRoastBean.AllowUserToDeleteRows = false;
            dvgRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRoastBean.Dock = DockStyle.Fill;
            dvgRoastBean.Location = new Point(3, 3);
            dvgRoastBean.MultiSelect = false;
            dvgRoastBean.Name = "dvgRoastBean";
            dvgRoastBean.ReadOnly = true;
            dvgRoastBean.RowHeadersVisible = false;
            dvgRoastBean.RowHeadersWidth = 51;
            dvgRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgRoastBean.Size = new Size(786, 411);
            dvgRoastBean.TabIndex = 0;
            // 
            // FormBatchRoastingAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabBahanBaku);
            Name = "FormBatchRoastingAdmin";
            Text = "Batch Roasting";
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).EndInit();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
            pnlHeaderGreenBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgRoastBean).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTambahBatch;
        private DataGridView dgvBatchRoasting;
        private TabControl tabBahanBaku;
        private TabPage tabGreenBean;
        private TabPage tabRoastBean;
        private Panel pnlHeaderGreenBean;
        private DataGridView dvgRoastBean;
    }
}