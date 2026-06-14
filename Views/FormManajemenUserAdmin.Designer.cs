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
            lblJudul = new Label();
            lblSubJudul = new Label();
            btnTambahUser = new Button();
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
            pnlHeader.Controls.Add(btnTambahUser);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(24, 16, 24, 16);
            pnlHeader.Size = new Size(982, 120);
            pnlHeader.TabIndex = 1;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(24, 24);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(120, 20);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Manajemen User";
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(27, 64);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(237, 20);
            lblSubJudul.TabIndex = 2;
            lblSubJudul.Text = "Kelola akun pengguna sistem & role";
            lblSubJudul.Click += label1_Click;
            // 
            // btnTambahUser
            // 
            btnTambahUser.FlatStyle = FlatStyle.Flat;
            btnTambahUser.Location = new Point(790, 35);
            btnTambahUser.Name = "btnTambahUser";
            btnTambahUser.Size = new Size(170, 35);
            btnTambahUser.TabIndex = 3;
            btnTambahUser.Text = "+ Tambah User";
            btnTambahUser.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 120);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(24);
            flowLayoutPanel1.Size = new Size(982, 433);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // FormManajemenUserAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(982, 553);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(pnlHeader);
            Location = new Point(24, 24);
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