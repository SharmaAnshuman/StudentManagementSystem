namespace Sis
{
    partial class F_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Edit_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_toolStripMenuItem,
            this.Close_ToolStripMenuItem,
            this.Setting_toolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1243, 62);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Edit_toolStripMenuItem
            // 
            this.Edit_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.Edit_toolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.Edit_toolStripMenuItem.Image = global::Sis.Properties.Resources.student;
            this.Edit_toolStripMenuItem.Name = "Edit_toolStripMenuItem";
            this.Edit_toolStripMenuItem.Size = new System.Drawing.Size(70, 62);
            this.Edit_toolStripMenuItem.Text = "Student";
            this.Edit_toolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Edit_toolStripMenuItem.Click += new System.EventHandler(this.Edit_toolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addToolStripMenuItem.Text = "Student Details";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewToolStripMenuItem.Text = "Student Result";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.printToolStripMenuItem.Text = "Print MarkSheet";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // Close_ToolStripMenuItem
            // 
            this.Close_ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Close_ToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.Close_ToolStripMenuItem.Image = global::Sis.Properties.Resources.close;
            this.Close_ToolStripMenuItem.Name = "Close_ToolStripMenuItem";
            this.Close_ToolStripMenuItem.Size = new System.Drawing.Size(52, 62);
            this.Close_ToolStripMenuItem.Text = "Exit";
            this.Close_ToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Close_ToolStripMenuItem.Click += new System.EventHandler(this.Close_ToolStripMenuItem_Click);
            // 
            // Setting_toolStripMenuItem
            // 
            this.Setting_toolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Setting_toolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.Setting_toolStripMenuItem.Image = global::Sis.Properties.Resources.setting;
            this.Setting_toolStripMenuItem.Name = "Setting_toolStripMenuItem";
            this.Setting_toolStripMenuItem.Size = new System.Drawing.Size(131, 62);
            this.Setting_toolStripMenuItem.Text = "Account Settings";
            this.Setting_toolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Setting_toolStripMenuItem.Click += new System.EventHandler(this.Setting_toolStripMenuItem_Click);
            // 
            // F_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 592);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "F_Home";
            this.Text = "Faculty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Home_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.F_Home_KeyPress);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Home_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Setting_toolStripMenuItem;

    }
}



