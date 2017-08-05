using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sis
{
    public partial class Home : Form
    {
        int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        int deskWidth = Screen.PrimaryScreen.Bounds.Width;

        public Home()
        {
            InitializeComponent();
        }


        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Menu_students_Click(object sender, EventArgs e)
        {


        }

        private void Home_KeyDown(object sender, KeyEventArgs e)
        {
            //for to use set design time propertiy KEYPREVIWE=TURE;
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
                if (MessageBox.Show("Are You Sure To EXIT", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
            }
        }

        private void Home_Leave(object sender, EventArgs e)
        {

        }

        private void sreacgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_add a = new stud_add();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void feeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
    
        }

        private void adminManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin_panel a = new admin_panel();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course a = new Course();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void updateCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            course_update_delete a = new course_update_delete();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_fee_pay a = new stud_fee_pay();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void Edit_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_add_report a = new stud_add_report();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Tables_details a = new Tables_details();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            stud_exam a = new stud_exam();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void studentDetailUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_add_update a = new stud_add_update();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void Setting_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            help a = new help();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            admin_panel a = new admin_panel();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();

        }

    }
}
