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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtamaPenjual));
            pnlSidebar = new Panel();
            pictureBox1 = new PictureBox();
            btnBahanBakuPenjual = new Button();
            btnKeluar = new Button();
            lblRole = new Label();
            lblNamaUser = new Label();
            btnRiwayatPenjualan = new Button();
            btnEtalase = new Button();
            btnDashboard = new Button();
            pnlKonten = new Panel();
            pnlHeader = new Panel();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlKonten.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(btnBahanBakuPenjual);
            pnlSidebar.Controls.Add(btnKeluar);
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(lblNamaUser);
            pnlSidebar.Controls.Add(btnRiwayatPenjualan);
            pnlSidebar.Controls.Add(btnEtalase);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(240, 732);
            pnlSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(20, 23);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 54);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnBahanBakuPenjual
            // 
            btnBahanBakuPenjual.BackColor = Color.FromArgb(79, 70, 229);
            btnBahanBakuPenjual.FlatStyle = FlatStyle.Flat;
            btnBahanBakuPenjual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBahanBakuPenjual.ForeColor = SystemColors.ButtonHighlight;
            btnBahanBakuPenjual.Location = new Point(10, 161);
            btnBahanBakuPenjual.Name = "btnBahanBakuPenjual";
            btnBahanBakuPenjual.Size = new Size(205, 29);
            btnBahanBakuPenjual.TabIndex = 7;
            btnBahanBakuPenjual.Text = "Bahan Baku";
            btnBahanBakuPenjual.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(79, 70, 229);
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = SystemColors.ButtonHighlight;
            btnKeluar.Location = new Point(20, 580);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(133, 29);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(94, 50);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(124, 20);
            lblRole.TabIndex = 5;
            lblRole.Text = "Karyawan Penjual";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.White;
            lblNamaUser.Location = new Point(94, 30);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(87, 20);
            lblNamaUser.TabIndex = 4;
            lblNamaUser.Text = "Nama User";
            // 
            // btnRiwayatPenjualan
            // 
            btnRiwayatPenjualan.BackColor = Color.FromArgb(79, 70, 229);
            btnRiwayatPenjualan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatPenjualan.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatPenjualan.Location = new Point(10, 250);
            btnRiwayatPenjualan.Name = "btnRiwayatPenjualan";
            btnRiwayatPenjualan.Size = new Size(205, 29);
            btnRiwayatPenjualan.TabIndex = 3;
            btnRiwayatPenjualan.Text = "Riwayat Penjualan";
            btnRiwayatPenjualan.UseVisualStyleBackColor = false;
            // 
            // btnEtalase
            // 
            btnEtalase.BackColor = Color.FromArgb(79, 70, 229);
            btnEtalase.FlatStyle = FlatStyle.Flat;
            btnEtalase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEtalase.ForeColor = SystemColors.ButtonHighlight;
            btnEtalase.Location = new Point(10, 206);
            btnEtalase.Name = "btnEtalase";
            btnEtalase.Size = new Size(205, 29);
            btnEtalase.TabIndex = 2;
            btnEtalase.Text = "Etalase Produk";
            btnEtalase.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(79, 70, 229);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 117);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(205, 29);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlKonten
            // 
            pnlKonten.BackColor = Color.Gainsboro;
            pnlKonten.Controls.Add(pnlHeader);
            pnlKonten.Dock = DockStyle.Fill;
            pnlKonten.Location = new Point(240, 0);
            pnlKonten.Name = "pnlKonten";
            pnlKonten.Size = new Size(1012, 732);
            pnlKonten.TabIndex = 1;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1012, 78);
            pnlHeader.TabIndex = 2;
            // 
            // FormUtamaPenjual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 732);
            Controls.Add(pnlKonten);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUtamaPenjual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - Penjual";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlKonten.ResumeLayout(false);
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
        private Button btnKeluar;
        private Button btnBahanBakuPenjual;
        private PictureBox pictureBox1;
        private Panel pnlHeader;
    }
}