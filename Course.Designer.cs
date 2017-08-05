namespace Sis
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.new_label3 = new System.Windows.Forms.Label();
            this.btn_add_course = new System.Windows.Forms.Button();
            this.new_label1 = new System.Windows.Forms.Label();
            this.cmb_course_sem = new System.Windows.Forms.ComboBox();
            this.txt_course_name = new System.Windows.Forms.TextBox();
            this.txt_course_decs = new System.Windows.Forms.TextBox();
            this.new_label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_subject_update = new System.Windows.Forms.Button();
            this.txt_subName = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_sub_course = new System.Windows.Forms.ComboBox();
            this.cmb_subFaclty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_sub_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_sub_sem = new System.Windows.Forms.ComboBox();
            this.pnl_sem = new System.Windows.Forms.Panel();
            this.txt_fee_for = new System.Windows.Forms.ComboBox();
            this.btn_show_datagrid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_fee_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_fee_course = new System.Windows.Forms.ComboBox();
            this.cmb_fee_sem = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_fee = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_fee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_sem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.new_label3);
            this.panel3.Controls.Add(this.btn_add_course);
            this.panel3.Controls.Add(this.new_label1);
            this.panel3.Controls.Add(this.cmb_course_sem);
            this.panel3.Controls.Add(this.txt_course_name);
            this.panel3.Controls.Add(this.txt_course_decs);
            this.panel3.Controls.Add(this.new_label4);
            this.panel3.Location = new System.Drawing.Point(43, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 269);
            this.panel3.TabIndex = 61;
            this.panel3.MouseHover += new System.EventHandler(this.pnl_sem_MouseHover);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Show All Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // new_label3
            // 
            this.new_label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.new_label3.AutoSize = true;
            this.new_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.new_label3.Location = new System.Drawing.Point(6, 132);
            this.new_label3.Name = "new_label3";
            this.new_label3.Size = new System.Drawing.Size(125, 18);
            this.new_label3.TabIndex = 50;
            this.new_label3.Text = "Course Semester";
            // 
            // btn_add_course
            // 
            this.btn_add_course.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add_course.Location = new System.Drawing.Point(219, 197);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(115, 34);
            this.btn_add_course.TabIndex = 3;
            this.btn_add_course.Text = "Add";
            this.btn_add_course.UseVisualStyleBackColor = true;
            this.btn_add_course.Click += new System.EventHandler(this.button1_Click);
            // 
            // new_label1
            // 
            this.new_label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.new_label1.AutoSize = true;
            this.new_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.new_label1.Location = new System.Drawing.Point(6, 32);
            this.new_label1.Name = "new_label1";
            this.new_label1.Size = new System.Drawing.Size(101, 18);
            this.new_label1.TabIndex = 46;
            this.new_label1.Text = "Course Name";
            // 
            // cmb_course_sem
            // 
            this.cmb_course_sem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_course_sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_course_sem.FormattingEnabled = true;
            this.cmb_course_sem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmb_course_sem.Location = new System.Drawing.Point(143, 132);
            this.cmb_course_sem.Name = "cmb_course_sem";
            this.cmb_course_sem.Size = new System.Drawing.Size(191, 21);
            this.cmb_course_sem.TabIndex = 2;
            // 
            // txt_course_name
            // 
            this.txt_course_name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_course_name.Location = new System.Drawing.Point(143, 32);
            this.txt_course_name.Name = "txt_course_name";
            this.txt_course_name.Size = new System.Drawing.Size(191, 20);
            this.txt_course_name.TabIndex = 0;
            // 
            // txt_course_decs
            // 
            this.txt_course_decs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_course_decs.Location = new System.Drawing.Point(143, 56);
            this.txt_course_decs.Multiline = true;
            this.txt_course_decs.Name = "txt_course_decs";
            this.txt_course_decs.Size = new System.Drawing.Size(191, 70);
            this.txt_course_decs.TabIndex = 1;
            // 
            // new_label4
            // 
            this.new_label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.new_label4.AutoSize = true;
            this.new_label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.new_label4.Location = new System.Drawing.Point(6, 50);
            this.new_label4.Name = "new_label4";
            this.new_label4.Size = new System.Drawing.Size(136, 18);
            this.new_label4.TabIndex = 54;
            this.new_label4.Text = "Course Description";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.btn_subject_update);
            this.panel4.Controls.Add(this.txt_subName);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.cmb_sub_course);
            this.panel4.Controls.Add(this.cmb_subFaclty);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_sub_save);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmb_sub_sem);
            this.panel4.Location = new System.Drawing.Point(780, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 269);
            this.panel4.TabIndex = 100004;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 146);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Add Faculty";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_subject_update
            // 
            this.btn_subject_update.Location = new System.Drawing.Point(13, 199);
            this.btn_subject_update.Name = "btn_subject_update";
            this.btn_subject_update.Size = new System.Drawing.Size(117, 40);
            this.btn_subject_update.TabIndex = 17;
            this.btn_subject_update.Text = "Update Subject";
            this.btn_subject_update.UseVisualStyleBackColor = true;
            this.btn_subject_update.Click += new System.EventHandler(this.btn_subject_update_Click);
            // 
            // txt_subName
            // 
            this.txt_subName.FormattingEnabled = true;
            this.txt_subName.Location = new System.Drawing.Point(22, 119);
            this.txt_subName.Name = "txt_subName";
            this.txt_subName.Size = new System.Drawing.Size(128, 21);
            this.txt_subName.TabIndex = 14;
            this.txt_subName.SelectedIndexChanged += new System.EventHandler(this.txt_subName_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Show All Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // cmb_sub_course
            // 
            this.cmb_sub_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sub_course.FormattingEnabled = true;
            this.cmb_sub_course.Location = new System.Drawing.Point(173, 35);
            this.cmb_sub_course.Name = "cmb_sub_course";
            this.cmb_sub_course.Size = new System.Drawing.Size(135, 21);
            this.cmb_sub_course.TabIndex = 12;
            this.cmb_sub_course.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_sub_course_MouseClick);
            this.cmb_sub_course.SelectedIndexChanged += new System.EventHandler(this.cmb_sub_course_SelectedIndexChanged);
            // 
            // cmb_subFaclty
            // 
            this.cmb_subFaclty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_subFaclty.FormattingEnabled = true;
            this.cmb_subFaclty.Location = new System.Drawing.Point(173, 119);
            this.cmb_subFaclty.Name = "cmb_subFaclty";
            this.cmb_subFaclty.Size = new System.Drawing.Size(135, 21);
            this.cmb_subFaclty.TabIndex = 15;
            this.cmb_subFaclty.MouseHover += new System.EventHandler(this.cmb_subFaclty_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(19, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Selecte Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(170, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Faculty Name";
            // 
            // btn_sub_save
            // 
            this.btn_sub_save.Location = new System.Drawing.Point(192, 199);
            this.btn_sub_save.Name = "btn_sub_save";
            this.btn_sub_save.Size = new System.Drawing.Size(118, 40);
            this.btn_sub_save.TabIndex = 18;
            this.btn_sub_save.Text = "Save Subject";
            this.btn_sub_save.UseVisualStyleBackColor = true;
            this.btn_sub_save.Click += new System.EventHandler(this.btn_sub_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(19, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Selecte Semester";
            // 
            // cmb_sub_sem
            // 
            this.cmb_sub_sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sub_sem.FormattingEnabled = true;
            this.cmb_sub_sem.Location = new System.Drawing.Point(173, 60);
            this.cmb_sub_sem.Name = "cmb_sub_sem";
            this.cmb_sub_sem.Size = new System.Drawing.Size(135, 21);
            this.cmb_sub_sem.TabIndex = 13;
            this.cmb_sub_sem.SelectedIndexChanged += new System.EventHandler(this.cmb_sub_sem_SelectedIndexChanged);
            // 
            // pnl_sem
            // 
            this.pnl_sem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_sem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnl_sem.Controls.Add(this.txt_fee_for);
            this.pnl_sem.Controls.Add(this.btn_show_datagrid);
            this.pnl_sem.Controls.Add(this.label2);
            this.pnl_sem.Controls.Add(this.button1);
            this.pnl_sem.Controls.Add(this.btn_fee_save);
            this.pnl_sem.Controls.Add(this.label6);
            this.pnl_sem.Controls.Add(this.label12);
            this.pnl_sem.Controls.Add(this.cmb_fee_course);
            this.pnl_sem.Controls.Add(this.cmb_fee_sem);
            this.pnl_sem.Controls.Add(this.label16);
            this.pnl_sem.Controls.Add(this.txt_fee);
            this.pnl_sem.Location = new System.Drawing.Point(409, 61);
            this.pnl_sem.Name = "pnl_sem";
            this.pnl_sem.Size = new System.Drawing.Size(356, 269);
            this.pnl_sem.TabIndex = 100003;
            this.pnl_sem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_sem_MouseClick);
            this.pnl_sem.MouseHover += new System.EventHandler(this.pnl_sem_MouseHover);
            // 
            // txt_fee_for
            // 
            this.txt_fee_for.FormattingEnabled = true;
            this.txt_fee_for.Location = new System.Drawing.Point(95, 101);
            this.txt_fee_for.Name = "txt_fee_for";
            this.txt_fee_for.Size = new System.Drawing.Size(240, 21);
            this.txt_fee_for.TabIndex = 7;
            this.txt_fee_for.SelectedIndexChanged += new System.EventHandler(this.txt_fee_for_SelectedIndexChanged);
            // 
            // btn_show_datagrid
            // 
            this.btn_show_datagrid.Location = new System.Drawing.Point(35, 243);
            this.btn_show_datagrid.Name = "btn_show_datagrid";
            this.btn_show_datagrid.Size = new System.Drawing.Size(300, 23);
            this.btn_show_datagrid.TabIndex = 11;
            this.btn_show_datagrid.Text = "Show All Data";
            this.btn_show_datagrid.UseVisualStyleBackColor = true;
            this.btn_show_datagrid.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(15, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fee Info.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Update Sem. Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_fee_save
            // 
            this.btn_fee_save.Location = new System.Drawing.Point(217, 191);
            this.btn_fee_save.Name = "btn_fee_save";
            this.btn_fee_save.Size = new System.Drawing.Size(118, 40);
            this.btn_fee_save.TabIndex = 9;
            this.btn_fee_save.Text = "Save Sem. Info";
            this.btn_fee_save.UseVisualStyleBackColor = true;
            this.btn_fee_save.Click += new System.EventHandler(this.btn_fee_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Selecte Course";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label12.Location = new System.Drawing.Point(214, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "Selecte Semester";
            // 
            // cmb_fee_course
            // 
            this.cmb_fee_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fee_course.FormattingEnabled = true;
            this.cmb_fee_course.Location = new System.Drawing.Point(18, 31);
            this.cmb_fee_course.Name = "cmb_fee_course";
            this.cmb_fee_course.Size = new System.Drawing.Size(170, 21);
            this.cmb_fee_course.TabIndex = 5;
            this.cmb_fee_course.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmb_fee_course_MouseClick);
            this.cmb_fee_course.SelectedIndexChanged += new System.EventHandler(this.cmb_fee_course_SelectedIndexChanged);
            // 
            // cmb_fee_sem
            // 
            this.cmb_fee_sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fee_sem.FormattingEnabled = true;
            this.cmb_fee_sem.Location = new System.Drawing.Point(217, 31);
            this.cmb_fee_sem.Name = "cmb_fee_sem";
            this.cmb_fee_sem.Size = new System.Drawing.Size(118, 21);
            this.cmb_fee_sem.TabIndex = 6;
            this.cmb_fee_sem.SelectedIndexChanged += new System.EventHandler(this.cmb_fee_sem_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label16.Location = new System.Drawing.Point(15, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 18);
            this.label16.TabIndex = 10;
            this.label16.Text = "Fee Rs.";
            // 
            // txt_fee
            // 
            this.txt_fee.Location = new System.Drawing.Point(95, 131);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(240, 20);
            this.txt_fee.TabIndex = 8;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Lucida Console", 12.11215F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(409, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 17);
            this.label17.TabIndex = 100005;
            this.label17.Text = "SEMESTER FEE";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Lucida Console", 12.11215F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(780, 43);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 17);
            this.label18.TabIndex = 100006;
            this.label18.Text = "ADD SUBJECT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sis.Properties.Resources.delete;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1225, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 36);
            this.pictureBox1.TabIndex = 100007;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView_fee
            // 
            this.dataGridView_fee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_fee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_fee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_fee.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView_fee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_fee.ColumnHeadersHeight = 20;
            this.dataGridView_fee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_fee.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_fee.Location = new System.Drawing.Point(312, 336);
            this.dataGridView_fee.Name = "dataGridView_fee";
            this.dataGridView_fee.ReadOnly = true;
            this.dataGridView_fee.RowHeadersWidth = 50;
            this.dataGridView_fee.Size = new System.Drawing.Size(533, 243);
            this.dataGridView_fee.TabIndex = 100008;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12.11215F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(39, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 100000;
            this.label1.Text = "ADD COURSE";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 628);
            this.Controls.Add(this.dataGridView_fee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_sem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.Course_Load);
            this.MouseHover += new System.EventHandler(this.pnl_sem_MouseHover);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_sem.ResumeLayout(false);
            this.pnl_sem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_course_decs;
        private System.Windows.Forms.Label new_label4;
        private System.Windows.Forms.ComboBox cmb_course_sem;
        private System.Windows.Forms.Label new_label3;
        private System.Windows.Forms.Label new_label1;
        private System.Windows.Forms.Button btn_add_course;
        private System.Windows.Forms.TextBox txt_course_name;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmb_sub_course;
        private System.Windows.Forms.ComboBox cmb_subFaclty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_sub_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_sub_sem;
        private System.Windows.Forms.Panel pnl_sem;
        private System.Windows.Forms.Button btn_fee_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_fee_course;
        private System.Windows.Forms.ComboBox cmb_fee_sem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_fee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_show_datagrid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txt_fee_for;
        private System.Windows.Forms.ComboBox txt_subName;
        private System.Windows.Forms.Button btn_subject_update;
        private System.Windows.Forms.Button button4;
    }
}