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
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
        }
        int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        int deskWidth = Screen.PrimaryScreen.Bounds.Width;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        String c_name, c_sem, c_decs;
        int c_fee=0,tmp,ID,c_id,sem_id,sub_id;


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Course_Load(object sender, EventArgs e)
        {

           
            try
            {
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
                con.Open();
      
            }
            catch (Exception x)
            {
                MessageBox.Show("Connection Error"+e.ToString());
            }
            get_faclty();
            get_course();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_course_sem.Text == "" || txt_course_decs.Text=="")
            {
                MessageBox.Show("Information Needed..!");
            }
            else
            {
                da = new SqlDataAdapter("select c_name from course where c_name='"+txt_course_name.Text+"'", con);
                DataTable c1 = new DataTable();
                da.Fill(c1);
                if (c1.Rows.Count == 0)
                {
                    try
                    {

                        c_name = txt_course_name.Text;
                        c_sem = cmb_course_sem.Text;
                        c_decs = txt_course_decs.Text;
                        if (MessageBox.Show("Are you sure", "Add Course", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            cmd = new SqlCommand("INSERT INTO course (c_name, c_sem, c_des) VALUES   ('" + txt_course_name.Text + "','" + cmb_course_sem.Text + "','" + txt_course_decs.Text + "')", con);
                            c_fee = cmd.ExecuteNonQuery();
                            if (c_fee == 0)
                            {
                                MessageBox.Show("Failed..! ");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Not Saved..!!");
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Some Error" + x.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("This Course Already Added..!");
                }
            }
            get_faclty();
            get_course();
        }

        private void pnl_sem_MouseHover(object sender, EventArgs e)
        {
          get_course();
        }

        //getting Faculty information for to set subjest
        public void get_faclty()
        {
            cmb_subFaclty.Items.Clear();
            cmd = new SqlCommand("select [user] from login_info where type='Faculty'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_subFaclty.Items.Add(dr.GetString(0).ToString());
            }
            dr.Close();
        }

        //for getting Course Name From table And Fill Into comboBox's
        public void get_course()
        {
            try
            {
                cmd = new SqlCommand("select c_name from course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (cmb_sub_course.Items.Contains(dr.GetString(0).ToString()) && cmb_fee_course.Items.Contains(dr.GetString(0).ToString()))
                    {
                    }
                    else
                    {
                        cmb_sub_course.Items.Add(dr.GetString(0).ToString());
                        cmb_fee_course.Items.Add(dr.GetString(0).ToString());
                    }
                }
                dr.Close();
            }
            catch (Exception x)
            {
                dr.Close();
            }
            
        }

        //for getting semester from selected course
        private void cmb_fee_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_fee_sem.Items.Clear();
            cmd = new SqlCommand("select c_sem from course where c_name='"+cmb_fee_course.Text+"'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                //number type column data can't get with GetInt(); 
                //Just retirve with like value and convert it
                for (int i = 1; i <= Int32.Parse(dr.GetValue(0).ToString()); i++)
                {
                    cmb_fee_sem.Items.Add(i.ToString());
                }

            dr.Close();
            
        }

        private void btn_fee_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                if (cmb_fee_course.Text == "" && cmb_fee_sem.Text == "")
                {
                    MessageBox.Show("Some Information Needed..!");
                }
                else
                {
                    //at form loading all course NAME added 
                    //get the selected course ID
                    cmd = new SqlCommand("select c_id from course where c_name='" + cmb_fee_course.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    //selected course id save into tmp 
                    tmp = Int32.Parse(dr.GetValue(0).ToString());

                    
                    
                        //Insert New semester Fee
                        if (!(txt_fee.Text == ""))
                        {
                          
                            c_fee = Int32.Parse(txt_fee.Text);
                            cmd = new SqlCommand("INSERT INTO semester(c_id, fee_rs, sem,fee_desc,fee_date) VALUES   ("+tmp+","+c_fee+","+cmb_fee_sem.Text+",'"+txt_fee_for.Text+"','"+DateTime.Now.ToString()+"')",con);
                            tmp = cmd.ExecuteNonQuery();
                            if (tmp == 1)
                                MessageBox.Show("Semester FEE Saved");
                            else
                                MessageBox.Show("Semester FEE NOT Saved");
                        }
                        else
                        {
                            MessageBox.Show("Enter Fee");
                        }
                    
                   
                }
               
            }
            catch (Exception x)
            {
                MessageBox.Show("Pleas Enter Fee In Number\n"+x.ToString());
            }
            cmb_fee_course.Text = "";
            cmb_fee_sem.Text = "";
            txt_fee.Text = "";
            txt_fee_for.Text = "";
        }

        private void cmb_sub_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gettin sem from selected course
            cmb_sub_sem.Items.Clear();
            cmd = new SqlCommand("select c_sem,c_id from course where c_name='" + cmb_sub_course.Text + "'", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            //found c_id save into c_id Variable
            c_id = Int32.Parse(dr.GetValue(1).ToString());

            //that c_id looping semester add into comboBox
            for (int i = 1; i <= Int32.Parse(dr.GetValue(0).ToString()); i++)
            {
                cmb_sub_sem.Items.Add(i.ToString());
            }
            dr.Close();
        }
        
        // Save Subject..!
        private void btn_sub_save_Click(object sender, EventArgs e)
        {
            try
            {
                //c_id from cmbBOX of subject selectedindexchanged() get the id of selected course_name
                //sem_id from cmbBOX of subject selectedindexchanged() get the id of selected semester_name 23 68
                da = new SqlDataAdapter("select * from subject where c_id='"+c_id+"' and s_id='"+getSEM_ID(cmb_sub_sem.Text)+"' ", con);
                DataTable count_subjet = new DataTable();
                da.Fill(count_subjet);
                if (count_subjet.Rows.Count != 10)
                {

                    da = new SqlDataAdapter("select * from subject where subject_name='" + txt_subName.Text + "' and c_id='" + c_id + "'", con);
                    dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)//Check In table Sub_nm and Course Are exist or not
                    {

                        cmd = new SqlCommand("insert into subject (c_id,s_id,subject_name,Faculty_name) values ('" + c_id + "','" + sem_id + "','" + txt_subName.Text + "','" + cmb_subFaclty.Text + "')", con);
                        tmp = cmd.ExecuteNonQuery();
                        if (tmp == 0)
                            MessageBox.Show("Subject Not Added");
                        else
                        {

                        }
                            MessageBox.Show("Subject Added");
                    }
                    else
                    {
                        MessageBox.Show("This Subject Are Already Saved for " + cmb_sub_course.Text);
                    }
                }
                else
                {
                    MessageBox.Show("10 Subject Limite","Information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                
            }
            catch (Exception c)
            {
                MessageBox.Show(c.ToString());
                //MessageBox.Show("Please Set First Semester FEE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (cmb_fee_course.Text == "" && cmb_fee_sem.Text=="")
                {
                    MessageBox.Show("Some Information Needed..!");
                }
                else
                {
                    //Course Table Detail
                    cmd = new SqlCommand("select c_id from course where c_name='" + cmb_fee_course.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    tmp = Int32.Parse(dr.GetValue(0).ToString());                   //To Check Current Record In table or Not
                    int sem = Int32.Parse(cmb_fee_sem.Text);
                    cmd = new SqlCommand("select * from semester where c_id='" + tmp + "' and sem=" + sem + "", con);
                    SqlDataReader dr11 = cmd.ExecuteReader();
                    if (dr11.Read())
                    {
                        sem_id=Int32.Parse(dr11.GetValue(0).ToString());
                        //update semester details

                        c_fee = Int32.Parse(txt_fee.Text);
                        cmd = new SqlCommand("update semester set fee_rs=" + c_fee + ",fee_desc='"+txt_fee_for.Text+"' where s_id="+sem_id+"", con);
                        tmp = cmd.ExecuteNonQuery();
                        if (tmp == 1)
                        {
                            MessageBox.Show("Fee Details Updated..!");
                            txt_fee_for.Text = "";
                            txt_fee.Text = "";
                            cmb_fee_sem_SelectedIndexChanged(null, new EventArgs());
                        }
                        else
                            MessageBox.Show("Update Error.!");
                        dr11.Close();
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Save This Semester Fee First", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Pleas Enter Fee In Number\n" + x.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (cmb_fee_course.Text == "" && cmb_fee_sem.Text == "")
            {
                MessageBox.Show("Select Course And Semester");
            }
            else
            {
                try
                {
                    //Course Table Detail
                    cmd = new SqlCommand("select c_id from course where c_name='" + cmb_fee_course.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    tmp = Int32.Parse(dr.GetValue(0).ToString());
                    dr.Close();
                    da = new SqlDataAdapter("select fee_desc AS 'Fee Description',fee_rs AS 'Fee Amount',fee_date AS 'Fee Date' from semester where c_id= " + tmp + " and sem=" + cmb_fee_sem.Text + "", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView_fee.DataSource = dt;
                }
                catch (Exception s)
                {
                    MessageBox.Show("Course Not Found..!!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select c_id as 'ID',c_name as 'Course Name',c_sem as 'Semester',c_des as 'Decsription' from course", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_fee.DataSource = dt;
            }
            catch (Exception s)
            {
                MessageBox.Show("Course Not Found..!!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select c_id from course where c_name='" + cmb_sub_course.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                tmp = Int32.Parse(dr.GetValue(0).ToString());
                dr.Close();

                cmd = new SqlCommand("select s_id from semester where sem='" + cmb_sub_sem.Text + "' and c_id=( select c_id from course where c_name='"+cmb_sub_course.Text+"')", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                Int32 tmp1 = Int32.Parse(dr.GetValue(0).ToString());
                dr.Close();

                da = new SqlDataAdapter("select subject_name AS 'Subject',faculty_name AS 'Faculty'  from subject where c_id= '" + tmp + "' and s_id='"+ tmp1 +"'", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView_fee.DataSource = dt;
            }
            catch (Exception s)
            {
                MessageBox.Show("Course Not Found..!!");
            }
        }

        private void cmb_sub_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //user select a semester then getting the s_id for selected semester
                cmd = new SqlCommand("select s_id from semester where sem=" + cmb_sub_sem.Text + " and c_id='" + c_id + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                sem_id = Int32.Parse(dr.GetValue(0).ToString());



                //for update getting subjects in combobox txt_subName
                cmd = new SqlCommand("select * from subject where s_id='" + sem_id + "' and c_id='" + c_id + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (!(txt_subName.Items.Contains(dr.GetString(3))))
                    {
                        txt_subName.Items.Add(dr.GetString(3));
                    }
                }

            }
            catch (Exception)
            {
                
            }
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmb_fee_course_MouseClick(object sender, MouseEventArgs e)
        {
            get_course();
        }

        private void cmb_sub_course_MouseClick(object sender, MouseEventArgs e)
        {
            get_course();
        }

        private void pnl_sem_MouseClick(object sender, MouseEventArgs e)
        {
            get_course();
        }

        private void cmb_fee_sem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmb_fee_course.Text == "" && cmb_fee_sem.Text == "")
            {
                MessageBox.Show("Select Course And Semester");
            }
            else
            {
                try
                {
                    //Course Table Detail
                    cmd = new SqlCommand("select c_id from course where c_name='" + cmb_fee_course.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    tmp = Int32.Parse(dr.GetValue(0).ToString());
                    dr.Close();
                    cmd = new SqlCommand("select fee_desc from semester where c_id= " + tmp + " and sem=" + cmb_fee_sem.Text + "", con);
                    dr = cmd.ExecuteReader();
                    txt_fee_for.Items.Clear();
                    while (dr.Read())
                    {
                        if (txt_fee_for.Items.Contains(dr.GetString(0)))
                        {
                        }
                        else
                        {
                        txt_fee_for.Items.Add(dr.GetString(0));

                        }
                        
                    }
                }
                catch (Exception s)
                {
                    MessageBox.Show("Course Not Found..!!");
                }
            }
        }

        private void txt_fee_for_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Select * from semester where fee_desc = '"+txt_fee_for.Text+"'
        }

        private void btn_subject_update_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update subject set subject_name='"+txt_subName.Text+"',faculty_name='"+cmb_subFaclty.Text+"' where sub_id="+sub_id+"",con);
            int p =cmd.ExecuteNonQuery();
            if (p == 0)
            {
                MessageBox.Show("Update Error");
            }
            else
            {
                MessageBox.Show("Subject Update Success.!");
            }

        }

        private void txt_subName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sub_id = "";
            String sql = "Select sub_id from subject where subject_name='" + txt_subName.Text + "'";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            sub_id=Int32.Parse(dr.GetValue(0).ToString());

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
            da = new SqlDataAdapter("select s_id from semester where sem=" + sem + " and c_id='" + getC_ID(cmb_sub_course.Text) + "'", con);
            dt = new DataTable();
            da.Fill(dt);
            String c = dt.Rows[0][0].ToString();
            return c;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            admin_panel x = new admin_panel();
            x.MdiParent = this.MdiParent;
            x.Location = new Point(0, 66);
            x.Size = new Size(deskWidth, deskHeight);
            x.ShowDialog();
        }

        private void cmb_subFaclty_MouseHover(object sender, EventArgs e)
        {
            get_faclty();
        }

    }
}
///<
///Command Class Object ne execute karta pela 
///DataReadr na Object ne Close() karvu pade. 6e.!!