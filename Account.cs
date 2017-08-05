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
    public partial class Account : Form
    {
        SqlConnection con;
       
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;
        String userNm;

        public Account()
        {
            InitializeComponent();
        }
        public Account(String name)
        {
            userNm = name;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Account_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            try
            {
                cmd = new SqlCommand("SELECT  *  FROM      login_info WHERE   ([user] = '" + userNm + "')", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                //(id,[user], pass, type, fullname, address, gender, phone, other)
                txt_user_login.Enabled = false;
                txt_user_login.Text = dr.GetString(1);
                txt_user_pass.Text = dr.GetString(2);
                txt_user_fullname.Text = dr.GetString(4);
                txt_user_address.Text = dr.GetString(5);
                cmb_user_gender.Text = dr.GetString(6);
                txt_user_mobile.Text = dr.GetString(7);
                txt_user_other.Text = dr.GetString(8);
                txt_user_pass.Focus();
            }
            catch (Exception c)
            {
               
            }
        }

        private void btn_anoter_user_Click(object sender, EventArgs e)
        {

        }

        private void txt_add_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_anoter_user_Click_1(object sender, EventArgs e)
        {

            if (!(txt_user_login.Text == "" || txt_user_pass.Text == "" || txt_user_mobile.Text == "" || txt_user_fullname.Text == ""))
            {
                cmd = new SqlCommand("update login_info set pass='" + txt_user_pass.Text + "',fullname='" + txt_user_fullname.Text + "',address='" + txt_user_address.Text + "',gender='" + cmb_user_gender.Text + "',phone='" + txt_user_mobile.Text + "',other='" + txt_user_other.Text + "' where [user]='" + txt_user_login.Text + "' ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    MessageBox.Show("User info Updated..!!");

                }
            }
            else
            {
                MessageBox.Show("Enter Information..", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
