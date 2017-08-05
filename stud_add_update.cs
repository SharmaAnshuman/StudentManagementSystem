using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Sis
{
    public partial class stud_add_update : Form
    {
        public stud_add_update()
        {
            InitializeComponent();
        }

        String gen;
        int i = 0;
        byte[] ImageByte_Get = null;
        bool dr1;

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;


        private void stud_add_update_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            txtfnm.Focus();
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "dd'/'MM'/'yyyy ";
            pic_PROFILE.Image = Properties.Resources.student_id;
            cmd = new SqlCommand("select c_name from course", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCourse.Items.Add(dr.GetString(0).ToString());
            }
            dr.Close();
           
        }

        private void txt_GRNOWHERE_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtfnm.Text = "";
            txtMobile.Text = "";
            txtAdd.Text = "";
            txtEmail.Text = "";
            cmb_city.Text = "";
            pic_PROFILE.Image = Properties.Resources.student_id;
            cmb_city.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtMobile.BackColor = Color.White;
            cmbCourse.BackColor = Color.White;
            try
            {
                cmd = new SqlCommand("select * from std where s_grno='" + txt_GRNOWHERE.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr1 = dr.Read();
                 //id, s_name, s_enroll, s_grno, s_city, s_add, s_gen, s_email, s_mobile, s_dob, s_course, s_sem, s_fee, s_img
                txtfnm.Text=dr.GetValue(1).ToString();
                cmb_city.Text = dr.GetString(4);
                txtAdd.Text = dr.GetString(5);
                if (dr.GetString(6) == "Male")
                {
                    radioMale.Checked = true;
                }
                else
                {
                    radioFemale.Checked = true;
                }
                txtEmail.Text = dr.GetString(7);
                txtMobile.Text = dr.GetString(8);
                //DOB.Text = dr.GetString(9);
                    ImageByte_Get = (byte[])dr[13];
                    MemoryStream ms = new MemoryStream(ImageByte_Get);
                    Image img = Image.FromStream(ms);
                    pic_PROFILE.Image = img;
                    if (txtMobile.Text.Length == 10)
                    {
                        txtMobile.BackColor = Color.AliceBlue;
                    }
            }
            catch (Exception x)
            {
                txtfnm.Text = "";
                txtMobile.Text = "";
                txtAdd.Text = "";
                txtEmail.Text = "";
                cmb_city.Text = "";
                cmb_city.BackColor = Color.White;                
                txtEmail.BackColor = Color.White;
                txtMobile.BackColor = Color.White; 
                cmbCourse.BackColor = Color.White;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dr1==true)
            {
                int c1 = getresult();
                if (c1 == 1 && txtMobile.Text.Length == 10)
                {
                    String sql;
                    sql = "update std set s_name='" + txtfnm.Text + "',s_city='" + cmb_city.Text + "', s_add='" + txtAdd.Text + "', s_gen='" + gen + "', s_email='" + txtEmail.Text + "', s_mobile='" + txtMobile.Text + "', s_dob='" + DOB.Text + "', s_course='" + cmbCourse.Text + "', s_sem='" + cmb_sem.Text + "', s_fee=" + get_fee(cmb_sem.Text) + " where s_grno='" + txt_GRNOWHERE.Text + "'";
                    try
                    {
                        cmd = new SqlCommand(sql, con);
                        if (MessageBox.Show("Are You Sure", "Update..?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            int i = cmd.ExecuteNonQuery();
                            if (i == 0)
                            {
                                MessageBox.Show("Error");
                            }
                            else
                            {
                                //    MessageBox.Show("Student Information Updated..!");
                                label4.Visible = true;
                                label4.ForeColor = Color.LightSalmon;
                            }
                        }
                    }
                    catch (Exception c)
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("G.R Not Found.!");
            }
                
            
        }

        private void txtfnm_TextChanged(object sender, EventArgs e)
        {

            if ((txtfnm.Text == "") || txtfnm.Text == "Student Full Name" || txtfnm.Text.Length < 15)
            {
                txtfnm.BackColor = Color.White;
               
            }
            else
            {
                txtfnm.BackColor = Color.AliceBlue;
            }
        }
        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City")
            {
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
            }
        }
        private void cmbStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_sem.Items.Clear();
            da = new SqlDataAdapter("select c_sem from course where c_name='" + cmbCourse.SelectedItem + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            for (int x = 1; x <= Int32.Parse(dt.Rows[0][0].ToString()); x++)
            {
                cmb_sem.Items.Add(x);
            }
          
        }
        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cmb_city_TextChanged(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City" || cmb_city.Text == "")
            {
                cmb_city.BackColor = Color.White;
               
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
            }
        }
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMale.Checked == false && radioFemale.Checked == false)
            {
               
            }
            else
            {
                if (radioFemale.Checked == true)
                {
                    gen = "Female";
                }
                else
                {
                    gen = "Male";
                }
               
            }
        }
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

            if (radioMale.Checked == false && radioFemale.Checked == false)
            {
            }
            else
            {
                if (radioFemale.Checked == true)
                {
                    gen = "Female";
                }
                else
                {
                    gen = "Male";
                }
             
            }
        }
        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text == "Student Address" || txtAdd.Text == "")
            {
                txtAdd.BackColor = Color.White;
              
            }
            else
            {
                txtAdd.BackColor = Color.AliceBlue;
            }
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.AliceBlue;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        
        int getresult()
        {
            String er = "Enter Information";
            i = 1;
            if (txtfnm.BackColor != Color.AliceBlue)
            {
                er += "\nName";
                i = 0;
            }
            if (cmb_city.BackColor != Color.AliceBlue)
            {
                er += "\nCity";
                i = 0;
            }
            if (txtAdd.BackColor != Color.AliceBlue)
            {
                er += "\nAddress ";
                i = 0;
            }
            if (gen == null)
            {
                er += "\nGender";
                i = 0;
            }
            
            if (txtMobile.BackColor != Color.AliceBlue)
            {
                er += "\nMobile";
                i = 0;
            }
            if (cmbCourse.Text == "")
            {
                er += "\nStream";
                i = 0;
            }
            if (cmb_sem.Text == "")
            {
                er += "\nSemester";
                i = 0;
            }
            if (pic_PROFILE.Image == null)
            {
                er += "\nPhoto";
                //i=0;
            }
            if (i == 0)
            {
                MessageBox.Show(er);
            }
            return i;
        }

        public int get_fee(String Sem)
        {
            da = new SqlDataAdapter("select c_id from course where c_name='"+cmbCourse.Text+"'", con);
            DataTable dtt = new DataTable();
            da.Fill(dtt);
            String Course_id =dtt.Rows[0][0].ToString();

            String sql = "select SUM(fee_rs) from semester where c_id=" + Course_id + " and sem = " + Sem + " ";
            cmd = new SqlCommand(sql,con);
            Object a = cmd.ExecuteScalar();
            return Int32.Parse(a.ToString());
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            if (txtMobile.Text.Length == 9 || txtMobile.Text.Length >= 9)
            {
                txtMobile.BackColor = Color.AliceBlue;
            }
            else
            {
            }

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar == 8))
            {

                if (txtMobile.Text.Length >= 10)
                {
                    e.Handled = true;
                }
            }
            else
            {

                e.Handled = true;
            }

        
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_sem.Items.Clear();
            da = new SqlDataAdapter("select c_sem from course where c_name='" + cmbCourse.SelectedItem + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            for (int x = 1; x <= Int32.Parse(dt.Rows[0][0].ToString()); x++)
            {
                cmb_sem.Items.Add(x);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_city_TextChanged_2(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City")
            {
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
            }
        }
        
    }
}
