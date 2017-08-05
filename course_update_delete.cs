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
    public partial class course_update_delete : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        int tmp,tmp1,CO1,SE1,SU1,Ex1;

        public course_update_delete()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_course_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select * from course", con);
                dt = new DataTable();
                da.Fill(dt);
                data_course_show.DataSource = dt;
            }
            catch(Exception s)
            {
                MessageBox.Show("Course Not Found..!!");
            }
        }

        private void btn_update_course_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cmb_courseUPDATE_name.Text == "")
                {
                    MessageBox.Show("Select Course Then Update");
                }
                else
                {
                    if (MessageBox.Show("Are You Sure To Update", "Update", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("update course set c_des='" + txt_courseUPDATE_decs.Text + "',c_sem='" + cmb_courseUPDATE_sem.Text + "' where c_name='" + cmb_courseUPDATE_name.Text + "'", con);
                        tmp = cmd.ExecuteNonQuery();
                        if (tmp == 1)
                            MessageBox.Show("Couser Updated..!");
                        else
                            MessageBox.Show("Couser NOT Updated..!");
                    }
                    else
                    {
                        MessageBox.Show("Couser NOT Updated..!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Check Filds");
            }
            fill_cmb();
        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            if (cmb_courseDELETE_name.Text == "")
            {
                MessageBox.Show("Select Course");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("select c_id from course where c_name='" + cmb_courseDELETE_name.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    tmp1 = Int32.Parse(dr.GetValue(0).ToString()); ;
                    if (MessageBox.Show("Are You Sure To Delete..!!", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        cmd = new SqlCommand("delete from course where c_name='" + cmb_courseDELETE_name.Text + "'", con);
                        CO1 = cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("delete from semester where C_id='" + tmp1 + "'", con);
                        SE1 = cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("delete from subject where C_id='" + tmp1 + "'", con);
                        SU1 = cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("delete from exam where C_id='" + tmp1 + "'", con);
                        Ex1 = cmd.ExecuteNonQuery();


                        MessageBox.Show(CO1.ToString() + " Course Deleted\n" + SE1.ToString() + " Semester Deleted\n" + SU1.ToString() + " Subject Deleted \n"+Ex1.ToString() +" Exam Deleted");
                        
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Some Error Check Semester/Subject Are set.!","Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
                
            }
            fill_cmb();
        }

     

        private void cmb_courseUPDATE_name_SelectedIndexChanged(object sender, EventArgs e)
              {
                  cmd = new SqlCommand("select * from course where c_name='" + cmb_courseUPDATE_name.Text + "'", con);
                  SqlDataReader dr = cmd.ExecuteReader();
                  while (dr.Read())
                  {
                      txt_courseUPDATE_decs.Text = dr.GetString(3).ToString();
                      cmb_courseUPDATE_sem.Text = dr.GetValue(2).ToString();
                  }
                  dr.Close();
              }

   
        private void course_update_delete_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
                con.Open();
            }
            catch (Exception x)
            {
                MessageBox.Show("Connection Error");
            }
            fill_cmb();
        }

        public void fill_cmb()
        {
            cmb_courseDELETE_name.Items.Clear();
            cmb_courseUPDATE_name.Items.Clear();
            cmd = new SqlCommand("select c_name from course", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_courseUPDATE_name.Items.Add(dr.GetString(0));
                cmb_courseDELETE_name.Items.Add(dr.GetString(0));
            }
            dr.Close();
            txt_courseUPDATE_decs.Text = "";
            cmb_courseUPDATE_sem.Text = "";

            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void cmb_courseDELETE_name_MouseClick(object sender, MouseEventArgs e)
        {
            fill_cmb();
        }

        private void cmb_courseUPDATE_name_MouseClick(object sender, MouseEventArgs e)
        {
            fill_cmb();
        }
    }
}
