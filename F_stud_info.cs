using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Sis
{
    public partial class F_stud_info : Form
    {
        public F_stud_info()
        {
            InitializeComponent();
        }
        String sql;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlConnection con;
        DataTable dt;
        SortedList sl = new SortedList();

        private void F_stud_info_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmb_where.Items.Add("Student Name%"); sl.Add("Student Name%", "s_name");
            cmb_where.Items.Add("G.R. No."); sl.Add("G.R. No.", "s_grno");
            cmb_where.Items.Add("Course%"); sl.Add("Course%", "s_course");
            cmb_where.Items.Add("Fee"); sl.Add("Fee", "s_fee");
            cmb_where.Items.Add("City%"); sl.Add("City%", "s_city");
            cmb_where.Items.Add("Email"); sl.Add("Email", "s_email");
            cmb_where.Items.Add("Gender"); sl.Add("Gender", "s_gen");
            cmb_where.Items.Add("Mobile"); sl.Add("Mobile", "s_mobile");
            cmb_where.Items.Add("Date Of Brith%"); sl.Add("Date Of Brith%", "s_dob");
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
             int index=sl.IndexOfKey(cmb_where.Text);
            dataGridView1.DataSource = GetDataSourceForGrid("std",sl[sl.GetKey(index)].ToString());
        }

        public DataTable GetDataSourceForGrid(String table, String col)
        {
            if (cmb_where.Text == "Date Of Brith%" || cmb_where.Text == "Address %" || cmb_where.Text == "Student Name%" || cmb_where.Text == "City%")
            {
                try
                {
                    String s = "select id AS 'ID', s_name AS 'Student Name', s_grno AS 'GR NO', s_city AS 'City', s_add AS 'Address', s_gen AS 'Gender', s_email AS 'Email', s_mobile AS 'Mobile',s_dob AS 'Date Of Brith', s_course AS 'Course', s_sem AS 'Semester', s_fee AS 'Fee', s_img AS 'Photo' from " + table + " where  " + col + " like '%" + txt_value.Text + "%' ";
                    da = new SqlDataAdapter(s, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception er)
                {
                    return dt;
                }
                return dt;
            }
            else
            {
                try
                {
                    String s = "select id AS 'ID', s_name AS 'Student Name', s_grno AS 'GR NO', s_city AS 'City', s_add AS 'Address', s_gen AS 'Gender', s_email AS 'Email', s_mobile AS 'Mobile',s_dob AS 'Date Of Brith', s_course AS 'Course', s_sem AS 'Semester', s_fee AS 'Fee', s_img AS 'Photo' from " + table + " where  " + col + " = " + txt_value.Text + " ";
                    da = new SqlDataAdapter(s, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;

                }
                catch (Exception er)
                {
                    String s = "select id AS 'ID', s_name AS 'Student Name', s_grno AS 'GR NO', s_city AS 'City', s_add AS 'Address', s_gen AS 'Gender', s_email AS 'Email', s_mobile AS 'Mobile',s_dob AS 'Date Of Brith', s_course AS 'Course', s_sem AS 'Semester', s_fee AS 'Fee', s_img AS 'Photo' from " + table + " where  " + col + " = '" + txt_value.Text + "' ";
                    da = new SqlDataAdapter(s, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                return dt;
            }
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String s = "select id AS 'ID', s_name AS 'Student Name', s_grno AS 'GR NO', s_city AS 'City', s_add AS 'Address', s_gen AS 'Gender', s_email AS 'Email', s_mobile AS 'Mobile',s_dob AS 'Date Of Brith', s_course AS 'Course', s_sem AS 'Semester', s_fee AS 'Fee', s_img AS 'Photo' from std ";
                da = new SqlDataAdapter(s, con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
