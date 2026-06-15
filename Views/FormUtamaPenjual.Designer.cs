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
            btnBahanBakuPenjual = new Button();
            btnKeluar = new Button();
            lblRole = new Label();
            lblNamaUser = new Label();
            btnRiwayatPenjualan = new Button();
            btnEtalase = new Button();
            btnDashboard = new Button();
            pnlKonten = new Panel();
            pictureBox1 = new PictureBox();
            pnlHeader = new Panel();
            pnlSidebar.SuspendLayout();
            pnlKonten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlSidebar.Margin = new Padding(4, 4, 4, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // btnBahanBakuPenjual
            // 
            btnBahanBakuPenjual.BackColor = Color.FromArgb(79, 70, 229);
            btnBahanBakuPenjual.FlatStyle = FlatStyle.Flat;
            btnBahanBakuPenjual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBahanBakuPenjual.ForeColor = SystemColors.ButtonHighlight;
            btnBahanBakuPenjual.Location = new Point(13, 201);
            btnBahanBakuPenjual.Margin = new Padding(4, 4, 4, 4);
            btnBahanBakuPenjual.Name = "btnBahanBakuPenjual";
            btnBahanBakuPenjual.Size = new Size(256, 36);
            btnBahanBakuPenjual.TabIndex = 7;
            btnBahanBakuPenjual.Text = "Bahan Baku";
            btnBahanBakuPenjual.UseVisualStyleBackColor = false;
            // 
            // btnKeluar
            // 
            btnKeluar.Location = new Point(25, 725);
            btnKeluar.Margin = new Padding(4, 4, 4, 4);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(200, 44);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(117, 63);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(147, 25);
            lblRole.TabIndex = 5;
            lblRole.Text = "Karyawan Penjual";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.White;
            lblNamaUser.Location = new Point(117, 38);
            lblNamaUser.Margin = new Padding(4, 0, 4, 0);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(105, 25);
            lblNamaUser.TabIndex = 4;
            lblNamaUser.Text = "Nama User";
            // 
            // btnRiwayatPenjualan
            // 
            btnRiwayatPenjualan.BackColor = Color.FromArgb(79, 70, 229);
            btnRiwayatPenjualan.FlatStyle = FlatStyle.Flat;
            btnRiwayatPenjualan.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatPenjualan.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayatPenjualan.Location = new Point(13, 313);
            btnRiwayatPenjualan.Margin = new Padding(4, 4, 4, 4);
            btnRiwayatPenjualan.Name = "btnRiwayatPenjualan";
            btnRiwayatPenjualan.Size = new Size(256, 36);
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
            btnEtalase.Location = new Point(13, 257);
            btnEtalase.Margin = new Padding(4, 4, 4, 4);
            btnEtalase.Name = "btnEtalase";
            btnEtalase.Size = new Size(256, 36);
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
            btnDashboard.Location = new Point(13, 146);
            btnDashboard.Margin = new Padding(4, 4, 4, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(256, 36);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlKonten
            // 
            pnlKonten.BackColor = Color.Gainsboro;
            pnlKonten.Controls.Add(pnlHeader);
            pnlKonten.Dock = DockStyle.Fill;
            pnlKonten.Location = new Point(300, 0);
            pnlKonten.Margin = new Padding(4, 4, 4, 4);
            pnlKonten.Name = "pnlKonten";
            pnlKonten.Size = new Size(980, 720);
            pnlKonten.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(25, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 68);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(980, 97);
            pnlHeader.TabIndex = 2;
            // 
            // FormUtamaPenjual
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlKonten);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormUtamaPenjual";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "SIKOPI DOPY - Penjual";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlKonten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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