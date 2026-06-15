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
            pnlHeaderGreenBean = new Panel();
            tabRoastBean = new TabPage();
            dvgRoastBean = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).BeginInit();
            tabBahanBaku.SuspendLayout();
            tabGreenBean.SuspendLayout();
            pnlHeaderGreenBean.SuspendLayout();
            tabRoastBean.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgRoastBean).BeginInit();
            SuspendLayout();
            // 
            // btnTambahBatch
            // 
            btnTambahBatch.BackColor = Color.FromArgb(79, 70, 229);
            btnTambahBatch.Cursor = Cursors.Hand;
            btnTambahBatch.ForeColor = SystemColors.ButtonHighlight;
            btnTambahBatch.Location = new Point(1067, 18);
            btnTambahBatch.Margin = new Padding(4, 4, 4, 4);
            btnTambahBatch.Name = "btnTambahBatch";
            btnTambahBatch.Size = new Size(180, 36);
            btnTambahBatch.TabIndex = 0;
            btnTambahBatch.Text = "+ Tambah Batch";
            btnTambahBatch.UseVisualStyleBackColor = false;
            btnTambahBatch.Click += btnTambahBatch_Click_1;
            // 
            // dgvBatchRoasting
            // 
            dgvBatchRoasting.AllowUserToAddRows = false;
            dgvBatchRoasting.AllowUserToDeleteRows = false;
            dgvBatchRoasting.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBatchRoasting.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatchRoasting.Dock = DockStyle.Bottom;
            dgvBatchRoasting.Location = new Point(4, 228);
            dgvBatchRoasting.Margin = new Padding(4, 4, 4, 4);
            dgvBatchRoasting.MultiSelect = false;
            dgvBatchRoasting.Name = "dgvBatchRoasting";
            dgvBatchRoasting.ReadOnly = true;
            dgvBatchRoasting.RowHeadersWidth = 51;
            dgvBatchRoasting.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBatchRoasting.Size = new Size(1264, 450);
            dgvBatchRoasting.TabIndex = 1;
            // 
            // tabBahanBaku
            // 
            tabBahanBaku.Controls.Add(tabGreenBean);
            tabBahanBaku.Controls.Add(tabRoastBean);
            tabBahanBaku.Dock = DockStyle.Fill;
            tabBahanBaku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabBahanBaku.Location = new Point(0, 0);
            tabBahanBaku.Margin = new Padding(4, 4, 4, 4);
            tabBahanBaku.Name = "tabBahanBaku";
            tabBahanBaku.SelectedIndex = 0;
            tabBahanBaku.Size = new Size(1280, 720);
            tabBahanBaku.TabIndex = 2;
            // 
            // tabGreenBean
            // 
            tabGreenBean.Controls.Add(pnlHeaderGreenBean);
            tabGreenBean.Controls.Add(dgvBatchRoasting);
            tabGreenBean.Location = new Point(4, 34);
            tabGreenBean.Margin = new Padding(4, 4, 4, 4);
            tabGreenBean.Name = "tabGreenBean";
            tabGreenBean.Padding = new Padding(4, 4, 4, 4);
            tabGreenBean.Size = new Size(1272, 682);
            tabGreenBean.TabIndex = 0;
            tabGreenBean.Text = "GreenBean";
            tabGreenBean.UseVisualStyleBackColor = true;
            // 
            // pnlHeaderGreenBean
            // 
            pnlHeaderGreenBean.Controls.Add(btnTambahBatch);
            pnlHeaderGreenBean.Dock = DockStyle.Top;
            pnlHeaderGreenBean.Location = new Point(4, 4);
            pnlHeaderGreenBean.Margin = new Padding(4, 4, 4, 4);
            pnlHeaderGreenBean.Name = "pnlHeaderGreenBean";
            pnlHeaderGreenBean.Size = new Size(1264, 69);
            pnlHeaderGreenBean.TabIndex = 2;
            // 
            // tabRoastBean
            // 
            tabRoastBean.Controls.Add(dvgRoastBean);
            tabRoastBean.Location = new Point(4, 34);
            tabRoastBean.Margin = new Padding(4, 4, 4, 4);
            tabRoastBean.Name = "tabRoastBean";
            tabRoastBean.Padding = new Padding(4, 4, 4, 4);
            tabRoastBean.Size = new Size(1272, 682);
            tabRoastBean.TabIndex = 1;
            tabRoastBean.Text = "Roast Bean";
            tabRoastBean.UseVisualStyleBackColor = true;
            // 
            // dvgRoastBean
            // 
            dvgRoastBean.AllowUserToAddRows = false;
            dvgRoastBean.AllowUserToDeleteRows = false;
            dvgRoastBean.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgRoastBean.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRoastBean.Dock = DockStyle.Fill;
            dvgRoastBean.Location = new Point(4, 4);
            dvgRoastBean.Margin = new Padding(4, 4, 4, 4);
            dvgRoastBean.MultiSelect = false;
            dvgRoastBean.Name = "dvgRoastBean";
            dvgRoastBean.ReadOnly = true;
            dvgRoastBean.RowHeadersVisible = false;
            dvgRoastBean.RowHeadersWidth = 51;
            dvgRoastBean.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgRoastBean.Size = new Size(1264, 674);
            dvgRoastBean.TabIndex = 0;
            // 
            // FormBatchRoastingAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(tabBahanBaku);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormBatchRoastingAdmin";
            Text = "Batch Roasting";
            ((System.ComponentModel.ISupportInitialize)dgvBatchRoasting).EndInit();
            tabBahanBaku.ResumeLayout(false);
            tabGreenBean.ResumeLayout(false);
            pnlHeaderGreenBean.ResumeLayout(false);
            tabRoastBean.ResumeLayout(false);
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