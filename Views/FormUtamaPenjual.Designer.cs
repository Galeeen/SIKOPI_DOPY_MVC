namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormUtamaPenjual
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
            btnBahanBakuPenjual = new Button();
            btnKeluar = new Button();
            lblRole = new Label();
            lblNamaUser = new Label();
            btnRiwayatPenjualan = new Button();
            btnEtalase = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlKonten = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(btnBahanBakuPenjual);
            pnlSidebar.Controls.Add(btnKeluar);
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(lblNamaUser);
            pnlSidebar.Controls.Add(btnRiwayatPenjualan);
            pnlSidebar.Controls.Add(btnEtalase);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 626);
            pnlSidebar.TabIndex = 0;
            // 
            // btnBahanBakuPenjual
            // 
            btnBahanBakuPenjual.Location = new Point(20, 147);
            btnBahanBakuPenjual.Name = "btnBahanBakuPenjual";
            btnBahanBakuPenjual.Size = new Size(160, 35);
            btnBahanBakuPenjual.TabIndex = 7;
            btnBahanBakuPenjual.Text = "Bahan Baku";
            btnBahanBakuPenjual.UseVisualStyleBackColor = true;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(20, 580);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(160, 35);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 535);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(124, 20);
            lblRole.TabIndex = 5;
            lblRole.Text = "Karyawan Penjual";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Location = new Point(20, 510);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(82, 20);
            lblNamaUser.TabIndex = 4;
            lblNamaUser.Text = "Nama User";
            // 
            // btnRiwayatPenjualan
            // 
            btnRiwayatPenjualan.Location = new Point(20, 252);
            btnRiwayatPenjualan.Name = "btnRiwayatPenjualan";
            btnRiwayatPenjualan.Size = new Size(160, 35);
            btnRiwayatPenjualan.TabIndex = 3;
            btnRiwayatPenjualan.Text = "Riwayat Penjualan";
            btnRiwayatPenjualan.UseVisualStyleBackColor = true;
            // 
            // btnEtalase
            // 
            btnEtalase.Location = new Point(20, 202);
            btnEtalase.Name = "btnEtalase";
            btnEtalase.Size = new Size(160, 35);
            btnEtalase.TabIndex = 2;
            btnEtalase.Text = "Etalase Produk";
            btnEtalase.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(20, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 35);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(24, 24);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(94, 20);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "SIKOPI DOPY";
            // 
            // pnlKonten
            // 
            pnlKonten.Dock = DockStyle.Fill;
            pnlKonten.Location = new Point(220, 0);
            pnlKonten.Name = "pnlKonten";
            pnlKonten.Size = new Size(944, 626);
            pnlKonten.TabIndex = 1;
            // 
            // FormUtamaPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 626);
            Controls.Add(pnlKonten);
            Controls.Add(pnlSidebar);
            Name = "FormUtamaPenjual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - Penjual";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlKonten;
        private Label lblRole;
        private Label lblNamaUser;
        private Button btnRiwayatPenjualan;
        private Button btnEtalase;
        private Button btnDashboard;
        private Label lblLogo;
        private Button btnKeluar;
        private Button btnBahanBakuPenjual;
    }
}