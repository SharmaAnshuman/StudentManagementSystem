using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Sis
{
    public partial class F_student_marks : Form
    {

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt_subj;
        DataTable dt;
        TextBox[] textBox = new TextBox[10];
        Label[] lable = new Label[10];
        String userNm,sql;
     
        int Subject_count, e_id;
        public F_student_marks()
        {
            InitializeComponent();
        }
        public F_student_marks(String x)
        {
            userNm = x;
            InitializeComponent();
        }

        private void F_student_marks_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmd = new SqlCommand("select exam from exam", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (cmb_exam.Items.Contains(dr.GetString(0).ToString()))
                {
                }
                else
                {
                    cmb_exam.Items.Add(dr.GetString(0).ToString());
                    cmb_exam_update.Items.Add(dr.GetString(0).ToString());
                }
            }
            dr.Close();
        }        

        //Save Result Into Table 
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_grno.Text != "")//  - Checking The GrNO 
            {
                int result = 0;
                dt = new DataTable();
                try
                {
                        for (int i = 0; i < Subject_count; i++)
                        {
                            //Checking Subject Marks Saved Or Not.?
                            sql = "SELECT  * FROM marks WHERE (sub_id = '" + lable[i].Text + "') AND (s_grno = '" + cmb_grno.Text + "')";
                            da = new SqlDataAdapter(sql, con);
                            da.Fill(dt);

                            if (dt.Rows.Count == 0)// zero for subject mark not found in table then save subject mark
                            {
                                sql = "INSERT INTO marks (e_id, s_grno, sub_id, marks)VALUES   ('" + e_id + "','" + cmb_grno.Text + "','" + lable[i].Text + "'," + textBox[i].Text + ")";
                                cmd = new SqlCommand(sql, con);
                                result += cmd.ExecuteNonQuery();
                            }
                        }
                        if (result == 0)
                        {
                            MessageBox.Show("That student mark has been taken already", "Not Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Marks Saved", "Student Marks Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
                catch (Exception x)
                {
                    MessageBox.Show("\aFill Student Mark in Number");
                }
            }
            else
            {
                MessageBox.Show("Select G.R.No ..!");
            }
      
        }

      
       /* public SqlDataReader Get_GRNO_For_exam(String sql)
        {
            MessageBox.Show(sql+"  FOR EXECUTE");
            SqlDataReader dr;
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            return dr;
        }*/

        private void cmb_exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear exsist data / controls
            cmb_exam.Text = "";
            cmb_grno.Items.Clear();
            cmb_grno.Text="";
            txt_std_nm.Text = "";
            flowLayoutPanel1.Controls.Clear();


            //Getting Sigle Exam Info
            da = new SqlDataAdapter("select * from exam where exam='"+cmb_exam.Text+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            
            String sem_id, c_id, cname, sem;
            e_id   = Int32.Parse(dt.Rows[0][0].ToString());
            c_id   = dt.Rows[0][1].ToString();
            sem_id = dt.Rows[0][2].ToString();
            //Converting ID into Name
            cname  = getC_Name(c_id);
            sem    = getSEM(sem_id);

            //Getting Semester Subjects
            da = new SqlDataAdapter("SELECT DISTINCT subject.subject_name FROM  subject CROSS JOIN semester WHERE   (subject.Faculty_name = '" + userNm + "') AND subject.c_id='" + c_id + "' and (subject.s_id = '" + sem_id + "')", con);
            dt = new DataTable();
            da.Fill(dt);
            dt_subj = dt;
            Subject_count = dt.Rows.Count;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;
            
            try
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //sujbect name
                    Label l = addlabel();
                    l.Text = dt.Rows[i][0].ToString();
                    flowLayoutPanel1.Controls.Add(l);
                    lable[i] = l;

                    //subject marks textbox
                    TextBox c = addtextbox();
                    flowLayoutPanel1.Controls.Add(c);
                    textBox[i] = c;
                }
            }
            catch (IndexOutOfRangeException xax)
            {
            }
            //Getting GRNO Of Stud's
            da = new SqlDataAdapter("select s_grno from std where s_course='"+cname+"' and s_sem='"+sem+"'", con);
            dt = new DataTable();
            da.Fill(dt);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cmb_grno.Items.Contains(dt.Rows[i][0].ToString()))
                {

                }
                else
                {
                    cmb_grno.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            
        }
        int XX = 0;
        public TextBox addtextbox()
        {
            TextBox a = new TextBox();
            a.Name="TextBox_D "+XX.ToString();
            XX = XX +1;
            return a;
        }
        int YY = 0;
        public Label addlabel()
        {
            Label a = new Label();
            a.Name = "Lable_D " + YY.ToString();
            YY = YY + 1;
            return a;
        }
        
        
        public String getC_Name(String c_id)
        {
            da = new SqlDataAdapter("select c_name from course where c_id='" + c_id + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            String x = dt.Rows[0][0].ToString();
            return x;
        }
        public String getSEM(String s_id)
        {
            da = new SqlDataAdapter("select sem from semester where s_id=" + s_id + "", con);
            dt = new DataTable();
            da.Fill(dt);
            String c = dt.Rows[0][0].ToString();
            return c;
        }

        private void cmb_grno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select s_name from std where s_grno='" + cmb_grno.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                txt_std_nm.Text = dt.Rows[0][0].ToString();
            }
            catch (Exception x)
            {
            }
        }

        private void cmb_grno_TextChanged(object sender, EventArgs e)
        {
            cmb_grno_SelectedIndexChanged(null, new EventArgs());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select sub_id as 'Subject',marks as 'Marks' from marks where s_grno = '"+ cmb_grno_update.Text+"'", con);
            da.Fill(dt = new DataTable());
            dataGridView_ShowMarks.DataSource = dt;

        }

        private void cmb_exam_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            // fill the grno
            //Getting Sigle Exam Info
            da = new SqlDataAdapter("select * from exam where exam='" + cmb_exam_update.Text + "'", con);
            dt = new DataTable();
            da.Fill(dt);

            String sem_id, c_id, cname, sem;
            e_id = Int32.Parse(dt.Rows[0][0].ToString());
            c_id = dt.Rows[0][1].ToString();
            sem_id = dt.Rows[0][2].ToString();
            //Converting ID into Name
            cname = getC_Name(c_id);
            sem = getSEM(sem_id);

            //Getting GRNO Of Stud's
            da = new SqlDataAdapter("select s_grno from std where s_course='" + cname + "' and s_sem='" + sem + "'", con);
            dt = new DataTable();
            da.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (cmb_grno_update.Items.Contains(dt.Rows[i][0].ToString()))
                {

                }
                else
                {
                    cmb_grno_update.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void cmb_grno_update_SelectedIndexChanged(object sender, EventArgs e)
        {

            txt_stdname_update.Text = "";
            txt_update_mark.Text = "";
            cmb_subject_update.Items.Clear();
            try
            {
//display the student name
                da = new SqlDataAdapter("select s_name from std where s_grno='" + cmb_grno_update.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                txt_stdname_update.Text = dt.Rows[0][0].ToString();
//filling subject to update
                cmd = new SqlCommand("select sub_id from marks where s_grno='"+cmb_grno_update.Text+"'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                int chk_while_on=0;
                
                while (dr.Read())
                {
                    if (cmb_subject_update.Items.Contains(dr.GetString(0)))
                    {
                    }
                    else
                    {
                        cmb_subject_update.Items.Add(dr.GetString(0));
                    }
                    chk_while_on = 1;
                }

                if (chk_while_on == 0)
                {
                    cmb_subject_update.Items.Add( "This Student Mark Requered.");
                }
                chk_while_on = 0;
            }
            catch (Exception x)
            {
            }
        }

        private void cmb_grno_update_TextChanged(object sender, EventArgs e)
        {
            cmb_grno_update_SelectedIndexChanged(null,new EventArgs());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String err=" ";
            if (txt_stdname_update.Text != "")
            {
                if (cmb_subject_update.Text != "")
                {
                    if (txt_update_mark.Text != "")
                    {
                        int n;
                        if (Int32.TryParse(txt_update_mark.Text, out n))
                        {


                            String sql = "update marks set marks='" + txt_update_mark.Text + "' where s_grno='" + cmb_grno_update.Text + "' and sub_id='" + cmb_subject_update.Text + "'";
                            cmd = new SqlCommand(sql, con);
                            int a = cmd.ExecuteNonQuery();
                            if (a == 1)
                            {
                                MessageBox.Show("Subject: " + cmb_subject_update.Text + " Mark: " + txt_update_mark.Text + "\n\n Student marks updated.!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Marks In Number.!");
                        }
                    }
                    else
                    {
                        err += "Enter Student Marks To Update";
                    }
                }
                else
                {
                    err += "Select Subject To Update";
                }
            }
            else
            {
                err += "Check Exam Details.!";
            }
            if (err != " ")
            {

                MessageBox.Show(err);
            }
        }
    }
}
