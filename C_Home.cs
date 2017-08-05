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
    public partial class C_Home : Form
    {
        int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        int deskWidth = Screen.PrimaryScreen.Bounds.Width;
        public String userNm;

        public C_Home()
        {
            InitializeComponent();
        }
        public C_Home(String name)
        {
            userNm = name;
            InitializeComponent();
        }
        

        private void Close_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_add a = new stud_add();
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

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_add_report a = new stud_add_report();
            a.ShowDialog();
        }

        private void adminManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account a = new Account(userNm);
            a.MdiParent = this.MdiParent;
            a.Location = new Point(0, 66);
            a.Size = new Size(deskWidth, deskHeight);
            a.ShowDialog();
        }

        private void C_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
