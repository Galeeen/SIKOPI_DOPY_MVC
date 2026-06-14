namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormLogin
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
            pnlKiri = new Panel();
            lblSubJudul = new Label();
            lblJudulApp = new Label();
            pnlLogin = new Panel();
            lblPesan = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblLogin = new Label();
            pnlKiri.SuspendLayout();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlKiri
            // 
            pnlKiri.Controls.Add(pnlLogin);
            pnlKiri.Controls.Add(lblSubJudul);
            pnlKiri.Controls.Add(lblJudulApp);
            pnlKiri.Location = new Point(220, 12);
            pnlKiri.Name = "pnlKiri";
            pnlKiri.Size = new Size(402, 503);
            pnlKiri.TabIndex = 0;
            pnlKiri.Paint += pnlKiri_Paint;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.Location = new Point(97, 43);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(117, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Roastery System";
            // 
            // lblJudulApp
            // 
            lblJudulApp.AutoSize = true;
            lblJudulApp.Location = new Point(109, 23);
            lblJudulApp.Name = "lblJudulApp";
            lblJudulApp.Size = new Size(94, 20);
            lblJudulApp.TabIndex = 0;
            lblJudulApp.Text = "SIKOPI DOPY";
            // 
            // pnlLogin
            // 
            pnlLogin.Controls.Add(lblPesan);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUsername);
            pnlLogin.Controls.Add(lblUsername);
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Location = new Point(3, 179);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(396, 300);
            pnlLogin.TabIndex = 2;
            // 
            // lblPesan
            // 
            lblPesan.AutoSize = true;
            lblPesan.ForeColor = Color.Red;
            lblPesan.Location = new Point(226, 264);
            lblPesan.Name = "lblPesan";
            lblPesan.Size = new Size(0, 20);
            lblPesan.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(154, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(3, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(3, 112);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 89);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(188, 25);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 20);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // FormLogin
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 503);
            Controls.Add(pnlKiri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            pnlKiri.ResumeLayout(false);
            pnlKiri.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlKiri;
        private Label lblJudulApp;
        private Label lblSubJudul;
        private Panel pnlLogin;
        private Label lblPesan;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsername;
        private Label lblUsername;
        private Label lblLogin;
    }
}