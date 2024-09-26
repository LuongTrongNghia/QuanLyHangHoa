namespace MDI
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýThôngTinĐạiLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýThôngTinHàngHoáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnMuaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHoáĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýThôngTinĐạiLýToolStripMenuItem,
            this.quảnLýThôngTinHàngHoáToolStripMenuItem,
            this.hoáĐơnMuaHàngToolStripMenuItem,
            this.lậpHoáĐơnBánToolStripMenuItem,
            this.thốngKêDoanhThuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýThôngTinĐạiLýToolStripMenuItem
            // 
            this.quảnLýThôngTinĐạiLýToolStripMenuItem.Name = "quảnLýThôngTinĐạiLýToolStripMenuItem";
            this.quảnLýThôngTinĐạiLýToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.quảnLýThôngTinĐạiLýToolStripMenuItem.Text = " Thông tin đại lý";
            this.quảnLýThôngTinĐạiLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThôngTinĐạiLýToolStripMenuItem_Click);
            // 
            // quảnLýThôngTinHàngHoáToolStripMenuItem
            // 
            this.quảnLýThôngTinHàngHoáToolStripMenuItem.Name = "quảnLýThôngTinHàngHoáToolStripMenuItem";
            this.quảnLýThôngTinHàngHoáToolStripMenuItem.Size = new System.Drawing.Size(164, 25);
            this.quảnLýThôngTinHàngHoáToolStripMenuItem.Text = "Thông Tin Hàng Hoá";
            this.quảnLýThôngTinHàngHoáToolStripMenuItem.Click += new System.EventHandler(this.quảnLýThôngTinHàngHoáToolStripMenuItem_Click);
            // 
            // hoáĐơnMuaHàngToolStripMenuItem
            // 
            this.hoáĐơnMuaHàngToolStripMenuItem.Name = "hoáĐơnMuaHàngToolStripMenuItem";
            this.hoáĐơnMuaHàngToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.hoáĐơnMuaHàngToolStripMenuItem.Text = "Hoá đơn mua hàng";
            this.hoáĐơnMuaHàngToolStripMenuItem.Click += new System.EventHandler(this.hoáĐơnMuaHàngToolStripMenuItem_Click);
            // 
            // lậpHoáĐơnBánToolStripMenuItem
            // 
            this.lậpHoáĐơnBánToolStripMenuItem.Name = "lậpHoáĐơnBánToolStripMenuItem";
            this.lậpHoáĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.lậpHoáĐơnBánToolStripMenuItem.Text = "Lập hoá đơn bán";
            this.lậpHoáĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.lậpHoáĐơnBánToolStripMenuItem_Click);
            // 
            // thốngKêDoanhThuToolStripMenuItem
            // 
            this.thốngKêDoanhThuToolStripMenuItem.Name = "thốngKêDoanhThuToolStripMenuItem";
            this.thốngKêDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(161, 25);
            this.thốngKêDoanhThuToolStripMenuItem.Text = "Thống kê doanh thu";
            this.thốngKêDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.thốngKêDoanhThuToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 128);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản Lý Kho Hàng";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrom";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem quảnLýThôngTinĐạiLýToolStripMenuItem;
        private ToolStripMenuItem quảnLýThôngTinHàngHoáToolStripMenuItem;
        private ToolStripMenuItem hoáĐơnMuaHàngToolStripMenuItem;
        private ToolStripMenuItem lậpHoáĐơnBánToolStripMenuItem;
        private ToolStripMenuItem thốngKêDoanhThuToolStripMenuItem;
        private Label label1;
    }
}