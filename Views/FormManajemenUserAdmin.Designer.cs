namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormManajemenUserAdmin
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlHeader = new Panel();
            btnTambahUser = new Button();
            lblSubJudul = new Label();
            lblJudul = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(btnTambahUser);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(30, 20, 30, 20);
            pnlHeader.Size = new Size(1280, 150);
            pnlHeader.TabIndex = 1;
            // 
            // btnTambahUser
            // 
            btnTambahUser.BackColor = Color.White;
            btnTambahUser.FlatStyle = FlatStyle.Flat;
            btnTambahUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahUser.Location = new Point(988, 44);
            btnTambahUser.Margin = new Padding(4, 4, 4, 4);
            btnTambahUser.Name = "btnTambahUser";
            btnTambahUser.Size = new Size(212, 44);
            btnTambahUser.TabIndex = 3;
            btnTambahUser.Text = "+ Tambah User";
            btnTambahUser.UseVisualStyleBackColor = false;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(34, 68);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(314, 25);
            lblSubJudul.TabIndex = 2;
            lblSubJudul.Text = "Kelola akun pengguna sistem dan role";
            lblSubJudul.Click += label1_Click;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 30);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(238, 38);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Manajemen User";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 150);
            flowLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 30, 30, 30);
            flowLayoutPanel1.Size = new Size(1280, 570);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // FormManajemenUserAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1280, 720);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(24, 24);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormManajemenUserAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manajemen User";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel pnlHeader;
        private Label lblSubJudul;
        private Label lblJudul;
        private Button btnTambahUser;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}