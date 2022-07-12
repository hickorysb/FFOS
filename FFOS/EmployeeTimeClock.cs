using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFOS
{
    public partial class EmployeeTimeClock : Form
    {
        private Employee em;

        public EmployeeTimeClock(Employee em)
        {
            InitializeComponent();
            Dictionary<int, string> jcs = em.getJobCodes();
            job_list.DataSource = new BindingSource(jcs, null);
            job_list.DisplayMember = "Value";
            job_list.ValueMember = "Key";

            int jobCode = (int)job_list.SelectedValue;
            double rateOfPay = em.getPayRate(jobCode);

            jobcode.Text = "Job Code: " + jobCode;
            rop.Text = "Rate of Pay: " + rateOfPay;
            this.em = em;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void job_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int jobCode = (int)job_list.SelectedValue;
            double rateOfPay = em.getPayRate(jobCode);

            jobcode.Text = "Job Code: " + jobCode;
            rop.Text = "Rate of Pay: " + rateOfPay;
        }
    }
}
