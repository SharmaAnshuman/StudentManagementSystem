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
    public partial class stud_fee_pay : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        int fee;
        /// <summary>
        /// Getting Current Srceen Size
        /// </summary>
        int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        int deskWidth = Screen.PrimaryScreen.Bounds.Width;

        public stud_fee_pay()
        {
            InitializeComponent();
        }

        private void txt_grno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select s_name,s_sem,s_course from std where s_grno='" + txt_grno.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                txt_Course.Text = dr.GetString(2).ToString();
                txt_stud_name.Text = dr.GetString(0).ToString();
                txt_currentSEM.Text = dr.GetString(1).ToString();
                txt_nextSEM.Text = (Int32.Parse(txt_currentSEM.Text) + 1).ToString();
                fee = (Int32.Parse(txt_currentSEM.Text) + 1);
                cmd = new SqlCommand("select c_id from course where c_name='" + txt_Course.Text + "'", con);
                SqlDataReader dr1 = cmd.ExecuteReader();
                dr1.Read();
                int sem_id = Int32.Parse(dr1.GetValue(0).ToString());
                cmd = new SqlCommand("SELECT   SUM(fee_rs) FROM semester WHERE (sem = "+txt_nextSEM.Text+" and c_id='"+sem_id+"')", con);
                Object a = cmd.ExecuteScalar();
                txt_Fee.Text= "Rs."+a.ToString();
                fee = Int32.Parse(a.ToString());
                txt_DATE.Text = DateTime.Now.ToString();
            }
            catch (Exception x)
            {
                txt_DATE.Text = "";
                txt_Fee.Text = "";
                txt_stud_name.Text = "";
                txt_currentSEM.Text = "";
                txt_nextSEM.Text = "";
                txt_Course.Text = "";
               //MessageBox.Show(x.ToString());
            }
        }

        private void stud_fee_pay_Load(object sender, EventArgs e)
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
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (!(txt_DATE.Text == "" && txt_Fee.Text == ""))
            {
                da = new SqlDataAdapter("select s_sem from std where s_grno='" + txt_grno.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (!(dt.Rows[0][0].ToString() == txt_nextSEM.Text))
                {
                    String sql;
                    sql = "INSERT INTO admission  (s_grno, s_name, s_course, s_sem, s_fee, s_date,s_type) VALUES   ('" + txt_grno.Text + "','" + txt_stud_name.Text + "','" + txt_Course.Text + "'," + txt_nextSEM.Text + "," + fee + ",'" + txt_DATE.Text + "','Old')";
                    try
                    {

                        cmd = new SqlCommand(sql, con);
                        int i = cmd.ExecuteNonQuery();
                        if (i == 0)
                        {
                            MessageBox.Show("Oops Error.!!");
                        }
                        else
                        {
                            DataTable xxx = new DataTable();
                            xxx.Columns.Add("s_grno", typeof(String));
                            xxx.Columns.Add("s_name", typeof(String));
                            xxx.Columns.Add("s_course", typeof(String));
                            xxx.Columns.Add("s_sem", typeof(String));
                            xxx.Columns.Add("s_fee", typeof(String));
                            xxx.Rows.Add(txt_grno.Text, txt_stud_name.Text, txt_Course.Text, txt_nextSEM.Text, txt_Fee.Text);

                            Std_fee_print a = new Std_fee_print(xxx);
                            a.MdiParent = this.MdiParent;
                            a.Location = new Point(0, 66);
                            a.Size = new Size(deskWidth, deskHeight);
                            a.ShowDialog();
                        }

                        cmd = new SqlCommand("UPDATE  std SET s_sem = '" + txt_nextSEM.Text + "',s_fee='"+fee+"' WHERE   (std.s_grno = '" + txt_grno.Text + "')", con);
                        i = cmd.ExecuteNonQuery();
                        if (i == 0)
                        {
                            MessageBox.Show("Student Semester NOT Updated");
                        }
                    }
                    catch (Exception x)
                    {
                        MessageBox.Show("Error ::" + x);
                    }
                }
                else
                {
                    MessageBox.Show("Fee Already Tacken");
                }
            }
            else
            {
                MessageBox.Show("Student G.R.No Not Found");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
