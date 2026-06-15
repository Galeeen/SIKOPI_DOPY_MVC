namespace SIKOPI_DOPY_MVC.Views
{
    partial class FormEtalaseToko
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblSubJudul = new Label();
            lblJudul = new Label();
            flpProduk = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(79, 70, 229);
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 4, 4, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1125, 112);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.White;
            lblSubJudul.Location = new Point(39, 61);
            lblSubJudul.Margin = new Padding(4, 0, 4, 0);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(324, 25);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Produk roast bean yang sudah siap jual";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(30, 18);
            lblJudul.Margin = new Padding(4, 0, 4, 0);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(206, 45);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Etalase Toko";
            // 
            // flpProduk
            // 
            flpProduk.AutoScroll = true;
            flpProduk.BackColor = Color.WhiteSmoke;
            flpProduk.Dock = DockStyle.Fill;
            flpProduk.Location = new Point(0, 112);
            flpProduk.Margin = new Padding(4, 4, 4, 4);
            flpProduk.Name = "flpProduk";
            flpProduk.Padding = new Padding(25, 25, 25, 25);
            flpProduk.Size = new Size(1125, 638);
            flpProduk.TabIndex = 1;
            // 
            // FormEtalaseToko
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1125, 750);
            Controls.Add(flpProduk);
            Controls.Add(pnlHeader);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormEtalaseToko";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Etalase Toko";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblJudul;
        private Label lblSubJudul;
        private FlowLayoutPanel flpProduk;
    }
}