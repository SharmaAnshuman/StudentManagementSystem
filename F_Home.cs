using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sis
{
    public partial class F_Home : Form
    {

        int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        int deskWidth = Screen.PrimaryScreen.Bounds.Width;
        public String userNm;
        public F_Home()
        {
            InitializeComponent();
        }
        public F_Home(String name)
        {
            userNm = name;
            InitializeComponent();
        }

        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_Home_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4 && e.Alt)
            {
                e.SuppressKeyPress = true;
                if (MessageBox.Show("Are You Sure To EXIT", "Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
            }
        }

        private void F_Home_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void newResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
        }

        private void Setting_toolStripMenuItem_Click(object sender, EventArgs e)
        {
                Account a = new Account(userNm);
                a.MdiParent = this.MdiParent;
                a.Location = new Point(0, 66);
                a.Size = new Size(deskWidth, deskHeight);
                a.ShowDialog();
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_stud_info a = new F_stud_info();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_mark_report a = new stud_mark_report();
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void oldResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Edit_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_student_marks a = new F_student_marks(userNm);
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }
    }
}
