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
    public partial class Login : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                //Online
                con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
                con.Open();
            }
            catch (SqlException x)
            {
                if (MessageBox.Show("Driver Error.!\n Show Error Details.?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show("Driver Error :\n " + x);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_login.Text != "" && txt_pass.Text != "")
            {
                da = new SqlDataAdapter("select type,[user] from login_info where [user]='" + txt_login.Text + "' and pass='" + txt_pass.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Worng Username/Password");
                }
                else
                {
                    if (dt.Rows[0][0].ToString() == "Admin")
                    {
                        this.Hide();
                        Home a = new Home();
                        a.Show();
                    }
                    else if (dt.Rows[0][0].ToString() == "Faculty")
                    {
                        this.Hide();
                        F_Home a = new F_Home(dt.Rows[0][1].ToString());
                        a.Show();
                    }
                    else if (dt.Rows[0][0].ToString() == "Clerk")
                    {
                        this.Hide();
                        C_Home a = new C_Home(dt.Rows[0][1].ToString());
                        a.Show();
                    }
                }
            }

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
