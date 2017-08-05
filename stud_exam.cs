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
    public partial class stud_exam : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;

        public stud_exam()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stud_exam_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            FILL_ALL_COURSE();
           
        }
        private void btn_ADD_exam_Click(object sender, EventArgs e)
        {
            if (cmb_ADD_examSem.Text == "" && cmb_ADD_examCourse.Text == "")
            {
                MessageBox.Show("Select Course And Semester");
            }
            else
            {
                try
                {
                    if (txt_ADD_examTitle.Text != "")
                    {
                        String c_id, sem_id;
                        sem_id = getSEM_ID(cmb_ADD_examSem.Text);
                        c_id = getC_ID(cmb_ADD_examCourse.Text);
                        String EXAM = cmb_ADD_examCourse.Text + "-" + cmb_ADD_examSem.Text + "-" + txt_ADD_examTitle.Text;
                        if (MessageBox.Show("Are You Sure..!", "Save Exam", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            cmd = new SqlCommand("INSERT INTO exam(c_id, sem_id, exam) VALUES(" + c_id + ", " + sem_id + ",'" + EXAM + "')", con);
                            int x = cmd.ExecuteNonQuery();
                            if (x == 0)
                            {
                                MessageBox.Show("Error");
                            }
                            stud_exam_Load(sender, e);
                        }
                    }
                }
                catch (Exception x)
                {

                }
            }
           

        }

        
        //UDF for course
        public void FILL_ALL_COURSE()
        {
            da = new SqlDataAdapter("select c_name from course",con);
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!(cmb_ADD_examCourse.Items.Contains(dt.Rows[i][0].ToString())))
                    cmb_ADD_examCourse.Items.Add(dt.Rows[i][0].ToString());
                if (!(cmb_DETELE_examCourse.Items.Contains(dt.Rows[i][0].ToString())))
                cmb_DETELE_examCourse.Items.Add(dt.Rows[i][0].ToString());
                if (!(cmb_SHOW_examCourse.Items.Contains(dt.Rows[i][0].ToString())))
                cmb_SHOW_examCourse.Items.Add(dt.Rows[i][0].ToString());
            }
        }
        //UDF for semester
        public void FILL_SEM_S_COURSE(String c_name,String Printresult_Obj)
        {
            if (!(cmb_ADD_examCourse.Text == "" && cmb_DETELE_examCourse.Text == "" && cmb_SHOW_examCourse.Text == ""))
            {
                da = new SqlDataAdapter("SELECT c_sem FROM course WHERE c_name = '"+c_name+"' ",con);
                dt = new DataTable();
                da.Fill(dt);
                int sem = Int32.Parse(dt.Rows[0][0].ToString());
                for (int i = 1; i <= sem; i++)
                {
                    if (Printresult_Obj == "SHOW")
                    {
                        
                        if(!(cmb_SHOW_examSem.Items.Contains(i.ToString())))
                        cmb_SHOW_examSem.Items.Add(i.ToString());
                    }
                    else if (Printresult_Obj == "DELETE")
                    {
                        
                        if (!(cmb_DETELE_examSem.Items.Contains(i.ToString())))
                            cmb_DETELE_examSem.Items.Add(i.ToString());
                    }
                    else
                    {
                        
                        if (!(cmb_ADD_examSem.Items.Contains(i.ToString())))
                            cmb_ADD_examSem.Items.Add(i.ToString());
                    }
                }
            }

        }      
        public String getC_ID(String c_name)
        {
            da = new SqlDataAdapter("select c_id from course where c_name='" + c_name + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            String x = dt.Rows[0][0].ToString();
            return x;
        }
        public String getSEM_ID(String sem)
        {
            da = new SqlDataAdapter("select s_id from semester where sem=" + sem + " and c_id='"+getC_ID(cmb_ADD_examCourse.Text)+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            String c = dt.Rows[0][0].ToString();
            return c;
        }

    

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_SHOW_examALL_Click(object sender, EventArgs e)
        {

            da = new SqlDataAdapter("select exam as 'Exam Title' from exam", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_SHOW_examSingle_Click(object sender, EventArgs e)
        {

            if (cmb_SHOW_examCourse.Text == "" && cmb_SHOW_examSem.Text == "")
            {
                da = new SqlDataAdapter("select   e_id as 'Exam ID',exam as 'Exam Title' from exam ", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if ((!(cmb_SHOW_examCourse.Text == "")) && cmb_SHOW_examSem.Text == "")
            {
                da = new SqlDataAdapter("select   e_id as 'Exam ID',exam as 'Exam Title' from exam where c_id in(select c_id from course where c_name='" + cmb_SHOW_examCourse.Text + "')", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else if ((!(cmb_SHOW_examCourse.Text == "")) && (!(cmb_SHOW_examSem.Text == "")))
            {
                da = new SqlDataAdapter("SELECT   exam FROM  exam WHERE   c_id IN(SELECT c_id   FROM  course   WHERE   c_name = '"+cmb_SHOW_examCourse.Text+"') AND sem_id IN(SELECT s_id FROM  semester WHERE   sem = "+cmb_SHOW_examSem.Text+")", con);
                
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void cmb_ADD_examCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ADD_examSem.Items.Clear();
            FILL_SEM_S_COURSE(cmb_ADD_examCourse.Text,"");
        }

        private void cmb_DETELE_examCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_DETELE_examSem.Items.Clear();
            FILL_SEM_S_COURSE(cmb_DETELE_examCourse.Text,"DELETE");
        }

        private void cmb_SHOW_examCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_SHOW_examSem.Items.Clear();
            FILL_SEM_S_COURSE(cmb_SHOW_examCourse.Text,"SHOW");
        }

        

        private void btn_SHOW_clear_Click(object sender, EventArgs e)
        {
            cmb_SHOW_examCourse.Items.Insert(0, "");
            cmb_SHOW_examSem.Items.Insert(0, "");
        }

        private void btn_SHOW_selected_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(cmb_SHOW_examCourse.Text == "") && (!(cmb_SHOW_examSem.Text == "")))
                {

                    da = new SqlDataAdapter("select * from exam where c_id=" + getC_ID(cmb_SHOW_examCourse.Text) + " and sem_id=" + getSEM_ID(cmb_SHOW_examSem.Text) + " ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if ((!(cmb_SHOW_examCourse.Text == "")) && cmb_SHOW_examSem.Text == "")
                {
                    da = new SqlDataAdapter("select * from exam where c_id=" + getC_ID(cmb_SHOW_examCourse.Text) + " ", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Select Course And Semester");
                }
            }
            catch (Exception x)
            { }
        }

        private void cmb_DETELE_examSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_DETELE_examTitle.Items.Clear();
                cmb_DETELE_examTitle.Enabled = true;
                da = new SqlDataAdapter("select exam from exam where c_id=" + getC_ID(cmb_DETELE_examCourse.Text) + " and sem_id=" + getSEM_ID(cmb_DETELE_examSem.Text) + " ", con);
                dt = new DataTable();
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (cmb_DETELE_examTitle.Items.Contains(dt.Rows[i][0].ToString()))
                    {
                    }
                    else
                        cmb_DETELE_examTitle.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Exam Not Found..");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("delete exam where exam='" + cmb_DETELE_examTitle.Text + "'");
            try
            {
                cmd = new SqlCommand("delete exam where exam='" + cmb_DETELE_examTitle.Text + "'", con);
                int q = cmd.ExecuteNonQuery();
                if (q == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                    MessageBox.Show(q.ToString() + " Data Deleted.!");
                cmb_DETELE_examTitle.Items.Remove(cmb_DETELE_examTitle.Text);
                cmb_DETELE_examTitle.Text = "";
            }
            catch (Exception)
            {
            }
        }


    }
}
