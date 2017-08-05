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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        //Vaariables And Objects
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int tmp,reset=0;
            
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void admin_panel_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            user_data();
        }

        private void btn_anoter_user_Click(object sender, EventArgs e)
        {
            if (cmb_user_type.Text == "")
            {
                MessageBox.Show("Select Type");
            }
            else
            {
                try
                {

                    cmd = new SqlCommand("UPDATE  login_info  SET   [user] ='" + cmb_update_user.Text + "', pass ='" + txt_user_pass.Text + "', type ='" + cmb_user_type.Text + "'  where ID =" + cmb_user_id.Text + " ", con);
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                        MessageBox.Show("Update Done");
                    else
                        MessageBox.Show("Not Update");
                }
                catch (Exception ss)
                {
                    MessageBox.Show("Sorry ID Not Found");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(txt_add_phone.Text == "" && txt_add_pass.Text == "" && txt_add_fullnm.Text == "" && txt_add_address.Text == "" && cmb_add_typ.Text == "" && cmb_add_gender.Text == ""))
            {
                cmd = new SqlCommand("select id from login_info where ([user]='" + txt_add_user.Text + "')", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Username Already Saved");
                }
                else
                {
                    if (!(txt_add_pass.Text == "" && txt_add_user.Text == "" && cmb_user_type.Text == ""))
                    {
                        cmd = new SqlCommand("INSERT INTO login_info ([user], pass, type, fullname, address, gender, phone, other) VALUES('" + txt_add_user.Text + "','" + txt_add_pass.Text + "','" + cmb_add_typ.Text + "','" + txt_add_fullnm.Text + "','" + txt_add_address.Text + "','" + cmb_add_gender.Text + "','" + txt_add_phone.Text + "','" + txt_add_other.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User Added..!");
                        user_data();
                    }
                    else
                    {
                        MessageBox.Show("Fill Info..!");
                        user_data();
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Details.!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure..!", "Delete User", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                cmd = new SqlCommand("delete from login_info where user='" + cmb_delete_user.Text + "'", con);
                tmp=cmd.ExecuteNonQuery();
                if (tmp == 0)
                    MessageBox.Show("Not Deleted");
                else
                    MessageBox.Show("Deleted..!");
                cmb_delete_user.Text = "";
                cmb_delete_user.Items.Clear();
                user_data();
            }
            else
            {
                MessageBox.Show("User Safe..!");
            }
            user_data();
        }

        private void cmb_delete_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select type,fullname,gender,phone from login_info where [user]= '" + cmb_delete_user.Text + "' ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_delete_type_know.Text = dr.GetString(0).ToString();
                    txt_fullname.Text = dr.GetString(1).ToString();
                    txt_gender.Text = dr.GetString(2).ToString();
                    txt_phone.Text = dr.GetString(3).ToString();
                }
                dr.Close();
            }
            catch (Exception x)
            {
                txt_fullname.Text = "";
                txt_gender.Text = "";
                txt_phone.Text = "";
            }
        }

   

        private void admin_panel_MouseHover(object sender, EventArgs e)
        {
            
        }
        public void user_data()
        {
            cmd = new SqlCommand("select [user],ID from login_info", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (cmb_update_user.Items.Contains(dr.GetString(0).ToString()))
                {
                }
                else
                {
                    cmb_update_user.Items.Add(dr.GetString(0).ToString());
                    cmb_delete_user.Items.Add(dr.GetString(0).ToString());
                   // MessageBox.Show(dr.Ge5tString(0).ToString());
                }

            }
            dr.Close();
        }

        private void cmb_update_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select id from login_info where ([user]='"+cmb_update_user.Text+"')", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                    cmb_user_id.Text = dr.GetValue(0).ToString();
            }
            dr.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_update_user_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            reset = reset + 1;
            if (reset == 3)
            {
                if (MessageBox.Show("Clear Database.?", "Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("delete from admission", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from course", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from exam", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from grno", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from login_info", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from marks", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from semester", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from subject", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("delete from std", con);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("insert into login_info ([user],pass,type) values('admin','admin','Admin')", con);
                    cmd.ExecuteNonQuery();
                    reset = 0;
                }
            }
        }

    }
}
