namespace Sis
{
    partial class F_student_marks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_student_marks));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_grno = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_std_nm = new System.Windows.Forms.TextBox();
            this.cmb_exam = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_subject_update = new System.Windows.Forms.ComboBox();
            this.txt_update_mark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_ShowMarks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_grno_update = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stdname_update = new System.Windows.Forms.TextBox();
            this.cmb_exam_update = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 124;
            this.label1.Text = "Exam";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 126;
            this.label2.Text = "G.R. No.";
            // 
            // cmb_grno
            // 
            this.cmb_grno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grno.FormattingEnabled = true;
            this.cmb_grno.Location = new System.Drawing.Point(167, 56);
            this.cmb_grno.Name = "cmb_grno";
            this.cmb_grno.Size = new System.Drawing.Size(207, 26);
            this.cmb_grno.TabIndex = 127;
            this.cmb_grno.SelectedIndexChanged += new System.EventHandler(this.cmb_grno_SelectedIndexChanged);
            this.cmb_grno.TextChanged += new System.EventHandler(this.cmb_grno_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label15.Location = new System.Drawing.Point(37, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 18);
            this.label15.TabIndex = 152;
            this.label15.Text = "Student Name";
            // 
            // txt_std_nm
            // 
            this.txt_std_nm.Enabled = false;
            this.txt_std_nm.Location = new System.Drawing.Point(167, 84);
            this.txt_std_nm.Name = "txt_std_nm";
            this.txt_std_nm.Size = new System.Drawing.Size(207, 24);
            this.txt_std_nm.TabIndex = 153;
            // 
            // cmb_exam
            // 
            this.cmb_exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_exam.FormattingEnabled = true;
            this.cmb_exam.Location = new System.Drawing.Point(167, 25);
            this.cmb_exam.Name = "cmb_exam";
            this.cmb_exam.Size = new System.Drawing.Size(207, 26);
            this.cmb_exam.TabIndex = 154;
            this.cmb_exam.SelectedIndexChanged += new System.EventHandler(this.cmb_exam_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb_grno);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txt_std_nm);
            this.panel1.Controls.Add(this.cmb_exam);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.panel1.Location = new System.Drawing.Point(27, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 494);
            this.panel1.TabIndex = 177;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(116, 122);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(258, 320);
            this.flowLayoutPanel1.TabIndex = 179;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 177;
            this.button2.Text = "Submit Marks";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sis.Properties.Resources.delete;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1235, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 100009;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmb_subject_update);
            this.panel2.Controls.Add(this.txt_update_mark);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridView_ShowMarks);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmb_grno_update);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_stdname_update);
            this.panel2.Controls.Add(this.cmb_exam_update);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.panel2.Location = new System.Drawing.Point(459, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 494);
            this.panel2.TabIndex = 180;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 23);
            this.button3.TabIndex = 179;
            this.button3.Text = "Show Student Marks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 178;
            this.button1.Text = "Update Mark";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_subject_update
            // 
            this.cmb_subject_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subject_update.FormattingEnabled = true;
            this.cmb_subject_update.Location = new System.Drawing.Point(270, 107);
            this.cmb_subject_update.Name = "cmb_subject_update";
            this.cmb_subject_update.Size = new System.Drawing.Size(191, 26);
            this.cmb_subject_update.TabIndex = 166;
            // 
            // txt_update_mark
            // 
            this.txt_update_mark.Location = new System.Drawing.Point(544, 110);
            this.txt_update_mark.Name = "txt_update_mark";
            this.txt_update_mark.Size = new System.Drawing.Size(149, 24);
            this.txt_update_mark.TabIndex = 165;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(482, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 18);
            this.label7.TabIndex = 163;
            this.label7.Text = "Mark";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(130, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 162;
            this.label6.Text = "Subject Name";
            // 
            // dataGridView_ShowMarks
            // 
            this.dataGridView_ShowMarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView_ShowMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ShowMarks.Location = new System.Drawing.Point(134, 172);
            this.dataGridView_ShowMarks.Name = "dataGridView_ShowMarks";
            this.dataGridView_ShowMarks.Size = new System.Drawing.Size(559, 270);
            this.dataGridView_ShowMarks.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(130, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 155;
            this.label3.Text = "Exam";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(402, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 156;
            this.label4.Text = "G.R. No.";
            // 
            // cmb_grno_update
            // 
            this.cmb_grno_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_grno_update.FormattingEnabled = true;
            this.cmb_grno_update.Location = new System.Drawing.Point(486, 26);
            this.cmb_grno_update.Name = "cmb_grno_update";
            this.cmb_grno_update.Size = new System.Drawing.Size(207, 26);
            this.cmb_grno_update.TabIndex = 157;
            this.cmb_grno_update.SelectedIndexChanged += new System.EventHandler(this.cmb_grno_update_SelectedIndexChanged);
            this.cmb_grno_update.TextChanged += new System.EventHandler(this.cmb_grno_update_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(130, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 158;
            this.label5.Text = "Student Name";
            // 
            // txt_stdname_update
            // 
            this.txt_stdname_update.Enabled = false;
            this.txt_stdname_update.Location = new System.Drawing.Point(270, 63);
            this.txt_stdname_update.Name = "txt_stdname_update";
            this.txt_stdname_update.Size = new System.Drawing.Size(423, 24);
            this.txt_stdname_update.TabIndex = 159;
            // 
            // cmb_exam_update
            // 
            this.cmb_exam_update.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_exam_update.FormattingEnabled = true;
            this.cmb_exam_update.Location = new System.Drawing.Point(189, 25);
            this.cmb_exam_update.Name = "cmb_exam_update";
            this.cmb_exam_update.Size = new System.Drawing.Size(207, 26);
            this.cmb_exam_update.TabIndex = 160;
            this.cmb_exam_update.SelectedIndexChanged += new System.EventHandler(this.cmb_exam_update_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(24, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 180;
            this.label8.Text = "Add  Marks";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label9.Location = new System.Drawing.Point(456, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 100010;
            this.label9.Text = "Update Marks";
            // 
            // F_student_marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1271, 613);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_student_marks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Student Marks";
            this.Load += new System.EventHandler(this.F_student_marks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ShowMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_grno;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_std_nm;
        private System.Windows.Forms.ComboBox cmb_exam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_grno_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stdname_update;
        private System.Windows.Forms.ComboBox cmb_exam_update;
        private System.Windows.Forms.TextBox txt_update_mark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_ShowMarks;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_subject_update;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}