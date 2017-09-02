namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchTrìnhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phânCôngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.lịchTrìnhToolStripMenuItem,
            this.lịchTrìnhToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // lịchTrìnhToolStripMenuItem
            // 
            this.lịchTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngToolStripMenuItem});
            this.lịchTrìnhToolStripMenuItem.Name = "lịchTrìnhToolStripMenuItem";
            this.lịchTrìnhToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.lịchTrìnhToolStripMenuItem.Text = "Quản trị";
            // 
            // phânCôngToolStripMenuItem
            // 
            this.phânCôngToolStripMenuItem.Name = "phânCôngToolStripMenuItem";
            this.phânCôngToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.phânCôngToolStripMenuItem.Text = "Phân công";
            // 
            // lịchTrìnhToolStripMenuItem1
            // 
            this.lịchTrìnhToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phânCôngToolStripMenuItem1});
            this.lịchTrìnhToolStripMenuItem1.Name = "lịchTrìnhToolStripMenuItem1";
            this.lịchTrìnhToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.lịchTrìnhToolStripMenuItem1.Text = "Lịch trình";
            // 
            // phânCôngToolStripMenuItem1
            // 
            this.phânCôngToolStripMenuItem1.Name = "phânCôngToolStripMenuItem1";
            this.phânCôngToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.phânCôngToolStripMenuItem1.Text = "Phân công";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 328);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý lịch trình Xe khách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânCôngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchTrìnhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phânCôngToolStripMenuItem1;
    }
}