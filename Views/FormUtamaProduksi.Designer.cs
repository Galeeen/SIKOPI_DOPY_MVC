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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtamaProduksi));
            pnlSidebar = new Panel();
            lblRole = new Label();
            lblNamaUser = new Label();
            btnKeluar = new Button();
            btnRiwayat = new Button();
            btnBatchRoasting = new Button();
            btnBahanBaku = new Button();
            btnDashboard = new Button();
            pnlKonten = new Panel();
            pictureBox1 = new PictureBox();
            pnlSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.Controls.Add(pictureBox1);
            pnlSidebar.Controls.Add(lblRole);
            pnlSidebar.Controls.Add(lblNamaUser);
            pnlSidebar.Controls.Add(btnKeluar);
            pnlSidebar.Controls.Add(btnRiwayat);
            pnlSidebar.Controls.Add(btnBatchRoasting);
            pnlSidebar.Controls.Add(btnBahanBaku);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(4, 4, 4, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(300, 720);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.ForeColor = Color.White;
            lblRole.Location = new Point(121, 56);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(161, 25);
            lblRole.TabIndex = 7;
            lblRole.Text = "Karyawan Produksi";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaUser.ForeColor = Color.White;
            lblNamaUser.Location = new Point(121, 31);
            lblNamaUser.Margin = new Padding(4, 0, 4, 0);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(105, 25);
            lblNamaUser.TabIndex = 6;
            lblNamaUser.Text = "Nama User";
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(79, 70, 229);
            btnKeluar.FlatStyle = FlatStyle.Flat;
            btnKeluar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = SystemColors.ButtonHighlight;
            btnKeluar.Location = new Point(25, 647);
            btnKeluar.Margin = new Padding(4, 4, 4, 4);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(166, 36);
            btnKeluar.TabIndex = 5;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            // 
            // btnRiwayat
            // 
            btnRiwayat.BackColor = Color.FromArgb(79, 70, 229);
            btnRiwayat.FlatStyle = FlatStyle.Flat;
            btnRiwayat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = SystemColors.ButtonHighlight;
            btnRiwayat.Location = new Point(25, 281);
            btnRiwayat.Margin = new Padding(4, 4, 4, 4);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(256, 36);
            btnRiwayat.TabIndex = 4;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = false;
            // 
            // btnBatchRoasting
            // 
            btnBatchRoasting.BackColor = Color.FromArgb(79, 70, 229);
            btnBatchRoasting.FlatStyle = FlatStyle.Flat;
            btnBatchRoasting.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBatchRoasting.ForeColor = SystemColors.ButtonHighlight;
            btnBatchRoasting.Location = new Point(25, 228);
            btnBatchRoasting.Margin = new Padding(4, 4, 4, 4);
            btnBatchRoasting.Name = "btnBatchRoasting";
            btnBatchRoasting.Size = new Size(256, 36);
            btnBatchRoasting.TabIndex = 3;
            btnBatchRoasting.Text = "Batch Roasting";
            btnBatchRoasting.UseVisualStyleBackColor = false;
            // 
            // btnBahanBaku
            // 
            btnBahanBaku.BackColor = Color.FromArgb(79, 70, 229);
            btnBahanBaku.FlatStyle = FlatStyle.Flat;
            btnBahanBaku.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBahanBaku.ForeColor = SystemColors.ButtonHighlight;
            btnBahanBaku.Location = new Point(25, 170);
            btnBahanBaku.Margin = new Padding(4, 4, 4, 4);
            btnBahanBaku.Name = "btnBahanBaku";
            btnBahanBaku.Size = new Size(256, 36);
            btnBahanBaku.TabIndex = 2;
            btnBahanBaku.Text = "Bahan Baku";
            btnBahanBaku.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(79, 70, 229);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ButtonHighlight;
            btnDashboard.Location = new Point(25, 112);
            btnDashboard.Margin = new Padding(4, 4, 4, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(256, 36);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pnlKonten
            // 
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
            pictureBox1.Location = new Point(25, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 68);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // FormUtamaProduksi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(pnlKonten);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormUtamaProduksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SIKOPI DOPY - Produksi";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel pnlKonten;
        private PictureBox pictureBox1;
    }
}