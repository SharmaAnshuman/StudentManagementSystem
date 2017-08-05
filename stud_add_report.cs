using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sis
{
    public partial class stud_add_report : Form
    {
        public stud_add_report()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SortedList st = new SortedList();
        String TB_COL="";
        private void stud_add_report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            st.Add("s_grno","G.R. No.");
            st.Add("s_name","Student Name");
            st.Add("s_mobile","Mobile Number");
            st.Add("s_course","Course");
            st.Add("s_gen","Gender");
            st.Add("s_join_dt", "Admission Date <**/**/****>");
            cmb_rep_srch.Items.Add("G.R. No.");
            cmb_rep_srch.Items.Add("Student Name");
            cmb_rep_srch.Items.Add("Mobile Number");
            cmb_rep_srch.Items.Add("Course");
            cmb_rep_srch.Items.Add("Gender");
            cmb_rep_srch.Items.Add("Admission Date <**/**/****>");
        }

        public String getCol(String fake_col_nm)
        {
            
            return (String)st.GetKey(st.IndexOfValue(fake_col_nm));
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            String s = "select * from std where " + getCol(cmb_rep_srch.Text.ToString()) + "='" + txt_srch.Text + "';";
            getDT(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String s = "select * from std;";
            getDT(s);
        }

        public void getDT(String sql)
        {
            //"select * from std ;"
            try
            {
                da = new SqlDataAdapter(sql, con);
                dt = new DataTable();
                da.Fill(dt);
                CrystalReport1 a = new CrystalReport1();
                a.SetDataSource(dt);
                crystalReportViewer1.ReportSource = a;
            }
            catch (Exception c)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
