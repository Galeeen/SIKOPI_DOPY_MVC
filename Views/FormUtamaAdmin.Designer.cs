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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtamaAdmin));
            pnlSidebar = new Panel();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.Controls.Add(pictureBox1);
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
            pnlSidebar.Margin = new Padding(4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 720);
            pnlSidebar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(19, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 68);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(111, 23);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(74, 28);
            lblRole.TabIndex = 1;
            lblRole.Text = "Admin";
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(79, 70, 229);
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = SystemColors.ButtonHighlight;
            btnKeluar.Location = new Point(19, 645);
            btnKeluar.Margin = new Padding(4);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(166, 36);
            btnKeluar.TabIndex = 6;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.White;
            lblNamaUser.Location = new Point(111, 51);
            lblNamaUser.Margin = new Padding(4, 0, 4, 0);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(132, 25);
            lblNamaUser.TabIndex = 0;
            lblNamaUser.Text = "Admin Roastery";
            lblNamaUser.Click += lblNamaUser_Click;
            // 
            // btnManajemenUser
            // 
            btnManajemenUser.BackColor = Color.FromArgb(79, 70, 229);
            btnManajemenUser.FlatStyle = FlatStyle.Flat;
            btnManajemenUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManajemenUser.ForeColor = SystemColors.ButtonHighlight;
            btnManajemenUser.Location = new Point(19, 409);
            btnManajemenUser.Margin = new Padding(4);
            btnManajemenUser.Name = "btnManajemenUser";
            btnManajemenUser.Size = new Size(256, 36);
            btnManajemenUser.TabIndex = 5;
            btnManajemenUser.Text = "Manajemen User";
            btnManajemenUser.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(79, 70, 229);
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayat.Location = new Point(19, 354);
            btnRiwayat.Margin = new Padding(4);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(256, 36);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = false;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnEtalase
            // 
            btnEtalase.BackColor = Color.FromArgb(79, 70, 229);
            btnEtalase.FlatStyle = FlatStyle.Flat;
            btnEtalase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEtalase.ForeColor = SystemColors.ButtonHighlight;
            btnEtalase.Location = new Point(19, 299);
            btnEtalase.Margin = new Padding(4);
            btnEtalase.Name = "btnEtalase";
            btnEtalase.Size = new Size(256, 36);
            btnEtalase.TabIndex = 3;
            btnEtalase.Text = "Etalase Toko";
            btnEtalase.UseVisualStyleBackColor = false;
            btnEtalase.Click += btnEtalase_Click;
            // 
            // btnBatchRoasting
            // 
            btnBatchRoasting.BackColor = Color.FromArgb(79, 70, 229);
            btnBatchRoasting.FlatStyle = FlatStyle.Flat;
            btnBatchRoasting.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatchRoasting.ForeColor = SystemColors.ButtonHighlight;
            btnBatchRoasting.Location = new Point(19, 239);
            btnBatchRoasting.Margin = new Padding(4);
            btnBatchRoasting.Name = "btnBatchRoasting";
            btnBatchRoasting.Size = new Size(256, 36);
            btnBatchRoasting.TabIndex = 2;
            btnBatchRoasting.Text = "Batch Roasting";
            btnBatchRoasting.UseVisualStyleBackColor = false;
            // 
            // btnBahanBaku
            // 
            btnBahanBaku.BackColor = Color.FromArgb(79, 70, 229);
            btnBahanBaku.FlatStyle = FlatStyle.Flat;
            btnBahanBaku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBahanBaku.ForeColor = SystemColors.ButtonHighlight;
            btnBahanBaku.Location = new Point(19, 182);
            btnBahanBaku.Margin = new Padding(4);
            btnBahanBaku.Name = "btnBahanBaku";
            btnBahanBaku.Size = new Size(256, 36);
            btnBahanBaku.TabIndex = 1;
            btnBahanBaku.Text = "Bahan Baku";
            btnBahanBaku.UseVisualStyleBackColor = false;
            btnBahanBaku.Click += btnBahanBaku_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(79, 70, 229);
            btnDashboard.BackgroundImageLayout = ImageLayout.Zoom;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(19, 127);
            btnDashboard.Margin = new Padding(4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(256, 36);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(300, 0);
            pnlHeader.Margin = new Padding(4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(980, 75);
            pnlHeader.TabIndex = 1;
            // 
            // panelKontenAdmin
            // 
            panelKontenAdmin.BackColor = Color.Gainsboro;
            panelKontenAdmin.Dock = DockStyle.Fill;
            panelKontenAdmin.Location = new Point(300, 75);
            panelKontenAdmin.Margin = new Padding(4);
            panelKontenAdmin.Name = "panelKontenAdmin";
            panelKontenAdmin.Size = new Size(980, 645);
            panelKontenAdmin.TabIndex = 2;
            // 
            // FormUtamaAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelKontenAdmin);
            Controls.Add(pnlHeader);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormUtamaAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - ADMIN";
            WindowState = FormWindowState.Maximized;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}