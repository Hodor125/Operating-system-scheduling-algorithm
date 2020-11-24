namespace Process_scheduling_algorithm
{
    partial class choose_agrithm
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
            this.panel_show_agrithm = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.多级轮转调度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.短作业优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高响应比优先ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show_agrithm
            // 
            this.panel_show_agrithm.Location = new System.Drawing.Point(0, 53);
            this.panel_show_agrithm.Name = "panel_show_agrithm";
            this.panel_show_agrithm.Size = new System.Drawing.Size(2100, 1250);
            this.panel_show_agrithm.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.多级轮转调度ToolStripMenuItem,
            this.短作业优先ToolStripMenuItem,
            this.高响应比优先ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2534, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 多级轮转调度ToolStripMenuItem
            // 
            this.多级轮转调度ToolStripMenuItem.Name = "多级轮转调度ToolStripMenuItem";
            this.多级轮转调度ToolStripMenuItem.Size = new System.Drawing.Size(178, 35);
            this.多级轮转调度ToolStripMenuItem.Text = "多级轮转调度";
            this.多级轮转调度ToolStripMenuItem.Click += new System.EventHandler(this.多级轮转调度ToolStripMenuItem_Click);
            // 
            // 短作业优先ToolStripMenuItem
            // 
            this.短作业优先ToolStripMenuItem.Name = "短作业优先ToolStripMenuItem";
            this.短作业优先ToolStripMenuItem.Size = new System.Drawing.Size(154, 38);
            this.短作业优先ToolStripMenuItem.Text = "短作业优先";
            this.短作业优先ToolStripMenuItem.Click += new System.EventHandler(this.短作业优先ToolStripMenuItem_Click);
            // 
            // 高响应比优先ToolStripMenuItem
            // 
            this.高响应比优先ToolStripMenuItem.Name = "高响应比优先ToolStripMenuItem";
            this.高响应比优先ToolStripMenuItem.Size = new System.Drawing.Size(178, 38);
            this.高响应比优先ToolStripMenuItem.Text = "高响应比优先";
            this.高响应比优先ToolStripMenuItem.Click += new System.EventHandler(this.高响应比优先ToolStripMenuItem_Click);
            // 
            // choose_agrithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2534, 1329);
            this.Controls.Add(this.panel_show_agrithm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "choose_agrithm";
            this.Text = "choose_agrithm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_show_agrithm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 多级轮转调度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 短作业优先ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高响应比优先ToolStripMenuItem;
    }
}