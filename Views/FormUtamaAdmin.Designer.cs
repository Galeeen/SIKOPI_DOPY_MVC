namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormUtamaAdmin
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
            pnlSidebar = new Panel();
            lblRole = new Label();
            btnKeluar = new Button();
            lblNamaUser = new Label();
            btnManajemenUser = new Button();
            btnRiwayat = new Button();
            btnEtalase = new Button();
            btnBatchRoasting = new Button();
            btnBahanBaku = new Button();
            btnDashboard = new Button();
            pnlHeader = new Panel();
            panelKontenAdmin = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(btnKeluar);
            pnlSidebar.Controls.Add(lblNamaUser);
            pnlSidebar.Controls.Add(btnManajemenUser);
            pnlSidebar.Controls.Add(btnRiwayat);
            pnlSidebar.Controls.Add(btnEtalase);
            pnlSidebar.Controls.Add(btnBatchRoasting);
            pnlSidebar.Controls.Add(btnBahanBaku);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 450);
            pnlSidebar.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(23, 401);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(53, 20);
            lblRole.TabIndex = 1;
            lblRole.Text = "Admin";
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(3, 214);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(157, 29);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Location = new Point(12, 421);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(114, 20);
            lblNamaUser.TabIndex = 0;
            lblNamaUser.Text = "Admin Roastery";
            // 
            // btnManajemenUser
            // 
            btnManajemenUser.Location = new Point(3, 179);
            btnManajemenUser.Name = "btnManajemenUser";
            btnManajemenUser.Size = new Size(157, 29);
            btnManajemenUser.TabIndex = 5;
            btnManajemenUser.Text = "Manajemen User";
            btnManajemenUser.UseVisualStyleBackColor = true;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(3, 144);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(157, 29);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnEtalase
            // 
            btnEtalase.Location = new Point(3, 108);
            btnEtalase.Name = "btnEtalase";
            btnEtalase.Size = new Size(157, 29);
            btnEtalase.TabIndex = 3;
            btnEtalase.Text = "Etalase Toko";
            btnEtalase.UseVisualStyleBackColor = true;
            btnEtalase.Click += btnEtalase_Click;
            // 
            // btnBatchRoasting
            // 
            btnBatchRoasting.Location = new Point(3, 73);
            btnBatchRoasting.Name = "btnBatchRoasting";
            btnBatchRoasting.Size = new Size(157, 29);
            btnBatchRoasting.TabIndex = 2;
            btnBatchRoasting.Text = "Batch Roasting";
            btnBatchRoasting.UseVisualStyleBackColor = true;
            // 
            // btnBahanBaku
            // 
            btnBahanBaku.Location = new Point(3, 38);
            btnBahanBaku.Name = "btnBahanBaku";
            btnBahanBaku.Size = new Size(157, 29);
            btnBahanBaku.TabIndex = 1;
            btnBahanBaku.Text = "Bahan Baku";
            btnBahanBaku.UseVisualStyleBackColor = true;
            btnBahanBaku.Click += btnBahanBaku_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(0, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 29);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dasboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(240, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(560, 60);
            pnlHeader.TabIndex = 1;
            // 
            // panelKontenAdmin
            // 
            panelKontenAdmin.Dock = DockStyle.Fill;
            panelKontenAdmin.Location = new Point(240, 60);
            panelKontenAdmin.Name = "panelKontenAdmin";
            panelKontenAdmin.Size = new Size(560, 390);
            panelKontenAdmin.TabIndex = 2;
            // 
            // FormUtamaAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelKontenAdmin);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            Name = "FormUtamaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - ADMIN";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnKeluar;
        private Button btnManajemenUser;
        private Button btnRiwayat;
        private Button btnEtalase;
        private Button btnBatchRoasting;
        private Button btnBahanBaku;
        private Button btnDashboard;
        private Panel pnlHeader;
        private Panel panelKontenAdmin;
        private Label lblRole;
        private Label lblNamaUser;
    }
}