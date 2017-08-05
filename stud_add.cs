using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace Sis
{
    public partial class stud_add : Form
    {
        String gen,grno_course,grno_no,grno_year,grno;
        int i = 0,grNO,fee;
        byte[] ImageByte = null;

        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt ;

        public stud_add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Child_Load(object sender, EventArgs e)
        {
            txtfnm.Focus();
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.CustomFormat = "dd'/'MM'/'yyyy ";
            pic_PROFILE.Image = Properties.Resources.student_id;
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmd = new SqlCommand("select * from course", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCourse.Items.Add(dr.GetString(1).ToString());
            }
            dr.Close();
        }

        //changing values to know ture / false PictureBox
        private void txtfnm_TextChanged(object sender, EventArgs e)
        {

            if ((txtfnm.Text == "") || txtfnm.Text == "Student Full Name" || txtfnm.Text.Length < 15)
            {
                txtfnm.BackColor = Color.White;
                pic_NAME.Image = Properties.Resources.no;
            }
            else
            {
                txtfnm.BackColor = Color.AliceBlue;
                pic_NAME.Image = Properties.Resources.yes;
            }
        }
        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City")
            {
                pic_CITY.Image = Properties.Resources.no;
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
                pic_CITY.Image = Properties.Resources.yes;
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
            if (cmbCourse.Text == "" || cmb_sem.Text == "")
            {
                pic_STREAM.Image = Properties.Resources.no;
            }
            else
            {
                pic_STREAM.Image = Properties.Resources.yes;
            }
        }
        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sem.Text == "" || cmbCourse.Text == "")
            {
                pic_STREAM.Image = Properties.Resources.no;
            }
            else
            {
                pic_STREAM.Image = Properties.Resources.yes;
            }
        }
        private void cmb_city_TextChanged(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City" || cmb_city.Text == "")
            {
                cmb_city.BackColor = Color.White;
                pic_CITY.Image = Properties.Resources.no;
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
                pic_CITY.Image = Properties.Resources.yes;
            }
        }
        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMale.Checked == false && radioFemale.Checked == false)
            {
                pic_GENDER.Image = Properties.Resources.no;
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
                pic_GENDER.Image = Properties.Resources.yes;
            }
        }
        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

            if (radioMale.Checked == false && radioFemale.Checked == false)
            {
                pic_GENDER.Image = Properties.Resources.no;
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
                pic_GENDER.Image = Properties.Resources.yes;
            }
        }
        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            if (txtAdd.Text == "Student Address" || txtAdd.Text == "")
            {
                txtAdd.BackColor = Color.White;
                pic_ADDRESS.Image = Properties.Resources.no;
            }
            else
            {
                txtAdd.BackColor = Color.AliceBlue;
                pic_ADDRESS.Image = Properties.Resources.yes;
            }
        }
        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            pic_DOB.Image = Properties.Resources.yes;
        }
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (txtMobile.Text.Length == 9 || txtMobile.Text.Length >= 9)
            {
                txtMobile.BackColor = Color.AliceBlue;
                pic_MOBILE.Image = Properties.Resources.yes;
            }
            else
            {
                pic_MOBILE.Image = Properties.Resources.no;
            }

            if (txtMobile.Text.Length < 10 && (e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.AliceBlue;
        }
        private void cmb_city_TextChanged_1(object sender, EventArgs e)
        {
            if (cmb_city.Text == "Student City")
            {
                pic_CITY.Image = Properties.Resources.no;
            }
            else
            {
                cmb_city.BackColor = Color.AliceBlue;
                pic_CITY.Image = Properties.Resources.yes;
            }
        }

        //Upload Image
        private void btn_UPLOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog a = new OpenFileDialog();
            if (a.FileName == "")
            {
                try
                {
                    a.ShowDialog();
                    pic_PROFILE.Load(a.FileName);
                    pic_UPLOAD.Image = Properties.Resources.yes;

                    FileStream FS = new FileStream(a.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                    BinaryReader BR = new BinaryReader(FS);
                    long allbytes = new FileInfo(a.FileName).Length;
                    ImageByte = BR.ReadBytes((Int32)allbytes);
                    FS.Close();
                    FS.Dispose();
                    BR.Close();
                }
                catch (Exception ex)
                {
                    pic_UPLOAD.Image = Properties.Resources.no;
                    MessageBox.Show("Select Student Photo");
                }
            }

        }
        //Save Student
        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            int tmp;
            tmp = getresult();
            if (tmp == 1)
            {
                try
                {
                    if (ImageByte == null)
                    {
                        MessageBox.Show("Select Image");
                    }
                    else
                    {
                        //
                        //\\GET G.R. NO.
                        //
                        grno = get_grno();
                        cmd = new SqlCommand("INSERT INTO grno([year], course, [no]) VALUES(" + DateTime.Now.Year + ",'" + grno_course + "'," + grNO + ");", con);
                        cmd.ExecuteNonQuery();

                        //
                        //\\GET SEM FEE
                        //
                        cmd = new SqlCommand("select c_id from course where c_name='" + cmbCourse.Text + "'", con);
                        SqlDataReader dr1 = cmd.ExecuteReader();
                        dr1.Read();
                        int sem_id = Int32.Parse(dr1.GetValue(0).ToString());
                        cmd = new SqlCommand("SELECT   SUM(fee_rs) FROM semester WHERE (sem = " + cmb_sem.Text + " and c_id='" + sem_id + "')", con);
                        Object a = cmd.ExecuteScalar();
                        fee = Int32.Parse(a.ToString());




                        //
                        //\\ADMISSION OF STUDENT
                        //
                        cmd = new SqlCommand("INSERT INTO std (s_name, s_grno, s_city, s_add, s_gen, s_email, s_mobile, s_dob, s_course, s_sem,s_fee,s_img,s_join_dt) VALUES('" + txtfnm.Text + "','" + grno + "','" + cmb_city.Text + "','" + txtAdd.Text + "', '" + gen + "' ,'" + txtEmail.Text + "','" + txtMobile.Text + "','" + DOB.Text + "','" + cmbCourse.Text + "','" + cmb_sem.Text + "',"+fee+",@s_img,'"+DateTime.Now.ToString()+"')", con);
                        cmd.Parameters.Add("@s_img", ImageByte);
                        int m = cmd.ExecuteNonQuery();
                        if (m == 1)
                        {
                            
                            if (MessageBox.Show("Admission Done \n Print Recipt.?", "Print", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                            {
                                String date = DateTime.Now.ToString();
                                cmd = new SqlCommand("INSERT INTO admission  (s_grno, s_name, s_course, s_sem, s_fee, s_date,s_type) VALUES   ('" + grno + "', '" + txtfnm.Text + "', '" + cmbCourse.Text + "', '" + cmb_sem.Text + "', " + fee.ToString() + ",'" + date + "','New')", con);
                                int f = cmd.ExecuteNonQuery();
                                if (f == 0)
                                {
                                }
                                else
                                {
                                    da = new SqlDataAdapter("select a_id from admission where s_grno='"+grno+"' and s_sem='"+cmb_sem.Text+"'", con);
                                    dt = new DataTable();
                                    da.Fill(dt);
                                     
                                    DataTable xxx = new DataTable();
                                    xxx.Columns.Add("a_id", typeof(String));
                                    xxx.Columns.Add("s_grno", typeof(String));
                                    xxx.Columns.Add("s_name", typeof(String));
                                    xxx.Columns.Add("s_course", typeof(String));
                                    xxx.Columns.Add("s_sem", typeof(String));
                                    xxx.Columns.Add("s_fee", typeof(String));
                                    xxx.Rows.Add(dt.Rows[0][0].ToString(),grno,txtfnm.Text,cmbCourse.Text,cmb_sem.Text,fee.ToString());
                                    Std_fee_print z = new Std_fee_print(xxx);
                                    z.Show();
                                    Reload_Controls();
                                }
                                
                            }
                            Reload_Controls();
                        }
                        else
                            MessageBox.Show("Student admission failed");
                    }
                }
                catch (Exception xx)
                {
                    MessageBox.Show("Error Check The Course/Semester fee");
                }
            }
        }

        public void Reload_Controls()
        {
            pic_CITY.Image = Properties.Resources.no;
            pic_MOBILE.Image = Properties.Resources.no;
            pic_DOB.Image = Properties.Resources.no;
            pic_STREAM.Image = Properties.Resources.no;
            pic_PROFILE.Image = Properties.Resources.student_id;
            pic_UPLOAD.Image = Properties.Resources.no;
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtfnm.Text = "";
            txtAdd.Text = "";
            cmb_city.Text = "";
            cmb_sem.Text = "";
            cmbCourse.Text = "";
        }


        // Check All Fileds
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
            if (txtEmail.BackColor != Color.AliceBlue)
            {
                er += "\nEmail (if you want)";
            }
            if (txtMobile.BackColor != Color.AliceBlue)
            {
                er += "\nMobile";
                i = 0;
            }
            if (cmbCourse.Text == "")
            {
                er += "\nCourse";
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
        // Auto G.R.NO. Generator Function
        public String get_grno()
        {
            // Get the last G.R.NO from grno table
            da = new SqlDataAdapter("select * from grno", con);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                grno_no = (1).ToString();
                grNO = 1;
            }
            else
            {
                grno_no = ((dt.Rows.Count) + 1).ToString();
                grNO = dt.Rows.Count + 1;
            }

            grno_year = DateTime.Now.Year.ToString();
            grno_course = cmbCourse.Text;
            grno = grno_year + grno_course + grno_no;
            return (grno);
        }
        //exit
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        

    }
}