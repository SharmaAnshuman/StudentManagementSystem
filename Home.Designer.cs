namespace Sis
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Edit_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Close_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_toolStripMenuItem,
            this.Close_ToolStripMenuItem,
            this.Setting_toolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.examToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1084, 62);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // Edit_toolStripMenuItem
            // 
            this.Edit_toolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentDetailUpdateToolStripMenuItem,
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.printToolStripMenuItem});
            this.Edit_toolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.Edit_toolStripMenuItem.Image = global::Sis.Properties.Resources.student;
            this.Edit_toolStripMenuItem.Name = "Edit_toolStripMenuItem";
            this.Edit_toolStripMenuItem.Size = new System.Drawing.Size(160, 62);
            this.Edit_toolStripMenuItem.Text = "Student Management";
            this.Edit_toolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Edit_toolStripMenuItem.ToolTipText = "Student Management";
            this.Edit_toolStripMenuItem.Click += new System.EventHandler(this.Edit_toolStripMenuItem_Click);
            // 
            // studentDetailUpdateToolStripMenuItem
            // 
            this.studentDetailUpdateToolStripMenuItem.Name = "studentDetailUpdateToolStripMenuItem";
            this.studentDetailUpdateToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.studentDetailUpdateToolStripMenuItem.Text = "Update Details";
            this.studentDetailUpdateToolStripMenuItem.Click += new System.EventHandler(this.studentDetailUpdateToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.addToolStripMenuItem.Text = "New Admission";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.viewToolStripMenuItem.Text = "Pay Semester Fee";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.printToolStripMenuItem.Text = "Print/Search";
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
            this.Setting_toolStripMenuItem.Image = global::Sis.Properties.Resources.dialog_question;
            this.Setting_toolStripMenuItem.Name = "Setting_toolStripMenuItem";
            this.Setting_toolStripMenuItem.Size = new System.Drawing.Size(52, 62);
            this.Setting_toolStripMenuItem.Text = "Help";
            this.Setting_toolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Setting_toolStripMenuItem.Click += new System.EventHandler(this.Setting_toolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem3.Image = global::Sis.Properties.Resources.setting;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(164, 62);
            this.toolStripMenuItem3.Text = "Account Management";
            this.toolStripMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.updateCourseToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 62);
            this.toolStripMenuItem1.Text = "Course Management";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.addCourseToolStripMenuItem.Text = "Add New";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // updateCourseToolStripMenuItem
            // 
            this.updateCourseToolStripMenuItem.Name = "updateCourseToolStripMenuItem";
            this.updateCourseToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.updateCourseToolStripMenuItem.Text = "Course Update/Delete";
            this.updateCourseToolStripMenuItem.Click += new System.EventHandler(this.updateCourseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.DimGray;
            this.toolStripMenuItem2.Image = global::Sis.Properties.Resources.clipboard;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 62);
            this.toolStripMenuItem2.Text = "Exam Management";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.examToolStripMenuItem.Image = global::Sis.Properties.Resources.search;
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(67, 62);
            this.examToolStripMenuItem.Text = "Search";
            this.examToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.examToolStripMenuItem.Click += new System.EventHandler(this.examToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 576);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Home";
            this.Text = " Admin Control Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Home_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Edit_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Close_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Setting_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem studentDetailUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

