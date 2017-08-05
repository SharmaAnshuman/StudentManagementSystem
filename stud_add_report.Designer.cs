namespace Sis
{
    partial class stud_add_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stud_add_report));
            this.button2 = new System.Windows.Forms.Button();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmb_rep_srch = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(715, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_srch
            // 
            this.txt_srch.Location = new System.Drawing.Point(535, 4);
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(174, 20);
            this.txt_srch.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(796, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "ALL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmb_rep_srch
            // 
            this.cmb_rep_srch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_rep_srch.FormattingEnabled = true;
            this.cmb_rep_srch.Location = new System.Drawing.Point(355, 4);
            this.cmb_rep_srch.Name = "cmb_rep_srch";
            this.cmb_rep_srch.Size = new System.Drawing.Size(174, 21);
            this.cmb_rep_srch.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.DisplayGroupTree = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1276, 619);
            this.crystalReportViewer1.TabIndex = 4;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1152, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 173;
            this.button1.Text = "Close Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stud_add_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_rep_srch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_srch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "stud_add_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "All Student Report";
            this.Load += new System.EventHandler(this.stud_add_report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmb_rep_srch;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button button1;
    }
}