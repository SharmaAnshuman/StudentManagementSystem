using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sis
{
    public partial class stud_mark_report : Form
    {
        public stud_mark_report()
        {
            InitializeComponent();
        }
        String eid;
        SqlCommand cmd;
        SqlConnection con;
        SqlDataReader dr;
        private void stud_mark_report_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;MultipleActiveResultSets=True;AttachDbFilename=|DataDirectory|\Student_Managment_DB.mdf;Integrated Security=True;User Instance=True");
            con.Open();
            cmd = new SqlCommand("select exam from exam",con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String exam=comboBox1.Text;
            //cmd = new SqlCommand("select ", con);

            SqlDataReader dr = (new SqlCommand("select sub_id,marks from marks where e_id='"+eid+"' and s_grno='"+comboBox2.Text+"'",con)).ExecuteReader();
            
            List<string> marks = new List<string>();
            marks.Add(comboBox1.Text);   //Exam Name. COMBOBOX1
            cmd = new SqlCommand("select s_name from std where s_grno='"+comboBox2.Text+"'", con);//GETTING SUBJECT AND MARKS 
            SqlDataReader dr1 = cmd.ExecuteReader();
            dr1.Read();
            marks.Add(comboBox2.Text);   //GRNO.
            marks.Add(dr1.GetString(0)); //That GRno Name
            int i=3;
            while (dr.Read())
            {
                string subject = dr["sub_id"].ToString()+" :";
                string mark = dr["marks"].ToString();
                marks.Add(subject);
                marks.Add(mark);
                i++;
            }
            if (i < 23)
            {
                for (i = i; i < 23; i++)
                    marks.Add("");
            }

            DataSet_For_Reporting dt = new DataSet_For_Reporting();
            dt.result.AddresultRow(marks[0], marks[1], marks[2], marks[3], marks[4], marks[5], marks[6], marks[7], marks[8], marks[9], marks[10], marks[11], marks[12], marks[13], marks[14], marks[15], marks[16], marks[17], marks[18], marks[19], marks[20], marks[21], marks[22]);
            //dt.result.AddresultRow("BCA Sem Internal", "2015BCA9", "Sharma Anshuman MadanLal", "C Lang.", "32", "PHP", "20", "HTML", "92", "C#", "41", "JavaScript", "44", "Asp.Net", "13", "SQL", "41", "Oracle", "44", "Operating System", "44", "J2EE", "08");

            MarkShit a = new MarkShit();
            a.SetDataSource(dt);
            crystalReportViewer1.ReportSource = a;
 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select s_grno,e_id from marks where e_id=(select e_id from exam where exam='"+comboBox1.Text+"')",con);
            dr = cmd.ExecuteReader();
            comboBox2.Items.Clear();
            eid = "";
            while (dr.Read())
            {
                eid = dr.GetValue(1).ToString();
                if (comboBox2.Items.Contains(dr.GetString(0)))
                {
                }
                else
                {
                    comboBox2.Items.Add(dr.GetString(0));
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.PrintReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
