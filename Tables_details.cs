using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sis
{
    public partial class Tables_details : Form
    {
        public Tables_details()
        {
            InitializeComponent();
        }

        String sql;
        SqlDataAdapter da;
        SqlConnection con;
        String btn,table_nm;
        DataTable dt;
        SortedList sl = new SortedList();

        public void EnabledTrue()
        {
            cmb_where.Items.Clear();
            cmb_where.Enabled = true;
            txt_value.Enabled = true;
            btn_find.Enabled = true;
        }
        private void stud_Payment_details_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmb_where.Enabled = false;
            txt_value.Enabled = false;
            btn_find.Enabled = false;
        }

        private void btn_admission_Click(object sender, EventArgs e)
        {
            table_nm = "admission";
            EnabledTrue();
            sl.Clear();
            cmb_where.Items.Add("Admission Type (new/old)"); sl.Add("Admission Type (new/old)", "s_type");
            cmb_where.Items.Add("Student Name %"); sl.Add("Student Name %", "s_name");
            cmb_where.Items.Add("G.R. NO."); sl.Add("G.R. NO.", "s_grno");
            cmb_where.Items.Add("Course"); sl.Add("Course", "s_course");
            cmb_where.Items.Add("Date (0/00/0000 0:00:00 PM%)"); sl.Add("Date (0/00/0000 0:00:00 PM%)","s_date");
            cmb_where.Items.Add("Fee"); sl.Add("Fee", "s_fee");
            cmb_where.Items.Add("ID"); sl.Add("ID", "a_id");

        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            table_nm = "course";
            EnabledTrue();
            sl.Clear();
            cmb_where.Items.Add("ID"); sl.Add("ID", "c_id");
            cmb_where.Items.Add("Course Name"); sl.Add("Course Name", "c_name");
            cmb_where.Items.Add("Course Decsription %"); sl.Add("Course Decsription %","c_des");

        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            table_nm = "exam";
            EnabledTrue();
            cmb_where.Items.Add("ID");
            cmb_where.Items.Add("Exam Name(BCA-1-XXXXXX)%");
            sl.Clear();
            sl.Add("ID", "e_id");
            sl.Add("Exam Name(BCA-1-XXXXXX)%", "exam");

        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            table_nm = "login_info";
            EnabledTrue();
            sl.Clear();
            cmb_where.Items.Add("Login"); sl.Add("Login", "[user]");
            cmb_where.Items.Add("Name"); sl.Add("Name", "fullname");
            cmb_where.Items.Add("Type"); sl.Add("Type", "type");
            cmb_where.Items.Add("Gender"); sl.Add("Gender", "gender");
            cmb_where.Items.Add("Address %"); sl.Add("Address %", "address");
            cmb_where.Items.Add("Phone"); sl.Add("Phone", "phone");

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
             table_nm="std";
            EnabledTrue();
            sl.Clear();
            cmb_where.Items.Add("Student Name"); sl.Add("Student Name", "s_name");
            cmb_where.Items.Add("G.R. No."); sl.Add("G.R. No.", "s_grno");
            cmb_where.Items.Add("Course%"); sl.Add("Course%", "s_course");
            cmb_where.Items.Add("Fee"); sl.Add("Fee", "s_fee");
            cmb_where.Items.Add("City%"); sl.Add("City%", "s_city");
            cmb_where.Items.Add("Email"); sl.Add("Email", "s_email");
            cmb_where.Items.Add("Gender"); sl.Add("Gender", "s_gen");
            cmb_where.Items.Add("Mobile"); sl.Add("Mobile", "s_mobile");
            cmb_where.Items.Add("Date Of Brith%"); sl.Add("Date Of Brith%", "s_dob");
        }

        private void cmb_where_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_value.Enabled = true;
            
            
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            try
            {

                int index = sl.IndexOfKey(cmb_where.Text);
                //MessageBox.Show(sl[sl.GetKey(index)].ToString());
                dataGridView1.DataSource = GetDataSourceForGrid(table_nm, sl[sl.GetKey(index)].ToString());
            }catch(Exception m)
            {

            }

             
        }

        public DataTable GetDataSourceForGrid(String table, String col)
        {
            if (cmb_where.Text == "Date Of Brith%" || cmb_where.Text == "Address %" || cmb_where.Text == "Student Name %" || cmb_where.Text == "Exam Name(BCA-1-XXXXXX)%" || cmb_where.Text == "Course Decsription %" || cmb_where.Text == "Date (0/00/0000 0:00:00 PM%)")
            {
                try
                {
                    String s = "select * from " + table + " where  " + col + " like '%" + txt_value.Text + "%' ";
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
            try
            {
                String s = "select * from " + table + " where  " + col + "=" + txt_value.Text + " ";
                da = new SqlDataAdapter(s, con);
                dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception er)
            {
                try
                {
                    String s = "select * from " + table + " where  " + col + "='" + txt_value.Text + "' ";
                    da = new SqlDataAdapter(s, con);
                    dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch(Exception c)
                {
                }

            }
            return dt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}