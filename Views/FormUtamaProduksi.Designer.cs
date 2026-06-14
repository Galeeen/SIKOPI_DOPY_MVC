namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormUtamaProduksi
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
            lblNamaUser = new Label();
            btnKeluar = new Button();
            btnRiwayat = new Button();
            btnBatchRoasting = new Button();
            btnBahanBaku = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlKonten = new Panel();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(lblNamaUser);
            pnlSidebar.Controls.Add(btnKeluar);
            pnlSidebar.Controls.Add(btnRiwayat);
            pnlSidebar.Controls.Add(btnBatchRoasting);
            pnlSidebar.Controls.Add(btnBahanBaku);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 673);
            pnlSidebar.TabIndex = 0;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 535);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(133, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Karyawan Produksi";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Location = new Point(20, 510);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(82, 20);
            lblNamaUser.TabIndex = 6;
            lblNamaUser.Text = "Nama User";
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(24, 580);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(94, 29);
            btnKeluar.TabIndex = 5;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(20, 255);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(94, 29);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
          
            // 
            // btnBatchRoasting
            // 
            btnBatchRoasting.Location = new Point(20, 200);
            btnBatchRoasting.Name = "btnBatchRoasting";
            btnBatchRoasting.Size = new Size(94, 29);
            btnBatchRoasting.TabIndex = 3;
            btnBatchRoasting.Text = "Batch Roasting";
            btnBatchRoasting.UseVisualStyleBackColor = true;
            // 
            // btnBahanBaku
            // 
            btnBahanBaku.Location = new Point(20, 145);
            btnBahanBaku.Name = "btnBahanBaku";
            btnBahanBaku.Size = new Size(94, 29);
            btnBahanBaku.TabIndex = 2;
            btnBahanBaku.Text = "Bahan Baku";
            btnBahanBaku.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(20, 90);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(94, 29);
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
            pnlKonten.Size = new Size(962, 673);
            pnlKonten.TabIndex = 1;
            // 
            // FormUtamaProduksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 673);
            Controls.Add(pnlKonten);
            Controls.Add(pnlSidebar);
            Name = "FormUtamaProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - Produksi";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblRole;
        private Label lblNamaUser;
        private Button btnKeluar;
        private Button btnRiwayat;
        private Button btnBatchRoasting;
        private Button btnBahanBaku;
        private Button btnDashboard;
        private Label lblLogo;
        private Panel pnlKonten;
    }
}