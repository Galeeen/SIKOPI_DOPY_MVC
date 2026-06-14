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
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblSubJudul);
            pnlHeader.Controls.Add(lblJudul);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 90);
            pnlHeader.TabIndex = 0;

            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblJudul.Location = new Point(24, 14);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(178, 37);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Etalase Toko";

            // 
            // lblSubJudul
            // 
            lblSubJudul.AutoSize = true;
            lblSubJudul.ForeColor = Color.DimGray;
            lblSubJudul.Location = new Point(27, 55);
            lblSubJudul.Name = "lblSubJudul";
            lblSubJudul.Size = new Size(286, 20);
            lblSubJudul.TabIndex = 1;
            lblSubJudul.Text = "Produk roast bean yang sudah siap jual";

            // 
            // flpProduk
            // 
            flpProduk.AutoScroll = true;
            flpProduk.BackColor = Color.WhiteSmoke;
            flpProduk.Dock = DockStyle.Fill;
            flpProduk.FlowDirection = FlowDirection.LeftToRight;
            flpProduk.Location = new Point(0, 90);
            flpProduk.Name = "flpProduk";
            flpProduk.Padding = new Padding(20);
            flpProduk.Size = new Size(900, 510);
            flpProduk.TabIndex = 1;
            flpProduk.WrapContents = true;

            // 
            // FormEtalaseToko
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 600);
            Controls.Add(flpProduk);
            Controls.Add(pnlHeader);
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