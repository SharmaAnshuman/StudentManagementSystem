using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sis
{
    public partial class Std_fee_print : Form
    {
        public Std_fee_print()
        {
            InitializeComponent();
        }
        DataTable dt;
        public Std_fee_print(DataTable dt1)
        {
            InitializeComponent();
            dt = dt1;
        }
       
       
       
        private void Std_add_print_Load(object sender, EventArgs e)
        {

            std_add_conf a = new std_add_conf();
            a.SetDataSource(dt);
            crystalReportViewer1.ReportSource =a;
            //crystalReportViewer1.PrintReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
