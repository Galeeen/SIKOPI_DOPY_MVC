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
            dgvGreenBean = new DataGridView();
            tabBahanBaku = new TabControl();
            tabGreenBean = new TabPage();
            tabRoastBean = new TabPage();
            dgvBatchRoasting = new DataGridView();
            pnlHeaderGreenBean = new Panel();
            btnTambahBatch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).BeginInit();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).BeginInit();
            pnlHeaderGreenBean.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGreenBean
            // 
            dgvGreenBean.AllowUserToAddRows = false;
            dgvGreenBean.AllowUserToDeleteRows = false;
            dgvGreenBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGreenBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGreenBean.Dock = DockStyle.Fill;
            dgvGreenBean.Location = new Point(3, 3);
            dgvGreenBean.MultiSelect = false;
            dgvGreenBean.Name = "dgvGreenBean";
            dgvGreenBean.ReadOnly = true;
            dgvGreenBean.RowHeadersWidth = 51;
            dgvGreenBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGreenBean.Size = new Size(1010, 537);
            dgvGreenBean.TabIndex = 1;
            dgvGreenBean.CellContentClick += dgvBatchRoasting_CellContentClick;
            // 
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabBahanBaku.Location = new Point(0, 0);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(1024, 576);
            tabBahanBaku.TabIndex = 2;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(dgvGreenBean);
            tabGreenBean.Location = new Point(4, 29);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(3);
            tabGreenBean.Size = new Size(1016, 543);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "GreenBean";
            tabGreenBean.UseVisualStyleBackColor = true;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dgvBatchRoasting);
            tabRoastBean.Controls.Add(pnlHeaderGreenBean);
            tabRoastBean.Location = new Point(4, 29);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(3);
            tabRoastBean.Size = new Size(1016, 543);
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
            dgvBatchRoasting.Location = new Point(3, 63);
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.Name = "dgvBatchRoasting";
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.RowHeadersVisible = false;
            dgvBatchRoasting.RowHeadersWidth = 51;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.Size = new Size(1010, 477);
            dgvBatchRoasting.TabIndex = 0;
            dgvBatchRoasting.CellContentClick += dvgRoastBean_CellContentClick;
            // 
            // pnlHeaderGreenBean
            // 
            pnlHeaderGreenBean.Controls.Add(btnTambahBatch);
            pnlHeaderGreenBean.Dock = DockStyle.Top;
            pnlHeaderGreenBean.Location = new Point(3, 3);
            pnlHeaderGreenBean.Name = "pnlHeaderGreenBean";
            pnlHeaderGreenBean.Size = new Size(1010, 60);
            pnlHeaderGreenBean.TabIndex = 3;
            // 
            // btnTambahBatch
            // 
            btnTambahBatch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTambahBatch.BackColor = Color.FromArgb(79, 70, 229);
            btnTambahBatch.Cursor = Cursors.Hand;
            btnTambahBatch.ForeColor = SystemColors.ButtonHighlight;
            btnTambahBatch.Location = new Point(854, 14);
            btnTambahBatch.Name = "btnTambahBatch";
            btnTambahBatch.Size = new Size(144, 29);
            btnTambahBatch.TabIndex = 0;
            btnTambahBatch.Text = "+ Tambah Batch";
            btnTambahBatch.UseVisualStyleBackColor = false;
            // 
            // FormBatchRoastingAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 576);
            Controls.Add(tabBahanBaku);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBatchRoastingAdmin";
            Text = "Batch Roasting";
            ((System.ComponentModel.ISupportInitialize)dgvGreenBean).EndInit();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).EndInit();
            pnlHeaderGreenBean.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvGreenBean;
        private TabControl tabBahanBaku;
        private TabPage tabGreenBean;
        private TabPage tabRoastBean;
        private Panel pnlHeaderGreenBean;
        private Button btnTambahBatch;
        private DataGridView dgvBatchRoasting;
    }
}