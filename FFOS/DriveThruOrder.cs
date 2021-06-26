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
    public partial class DriveThruOrder : Form
    {
        public DriveThruOrder()
        {
            InitializeComponent();
        }

        private void DriveThruOrder_Shown(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("DT", 1, "DW", "Jackson");
            dataGridView2.Rows.Add("DT", 2, "DW", "Jackson");
            dataGridView2.Rows.Add("DT", 3, "DW", "Jackson");
            dataGridView2.Rows.Add("DT", 4, "DW", "Jackson");
            dataGridView2.Rows.Add("DT", "Black,Car", "DW", "Jackson");
            dataGridView1.Rows.Add("DT", 6, "DW", "DO 💳");
            dataGridView1.Rows.Add("DT", 7, "DW", "💳");
            dataGridView1.Rows.Add("DT", 8, "DW", "DO");
            dataGridView1.Rows.Add("DT", 9, "DW", "");
            dataGridView1.Rows.Add("DT", "Green,SUV", "DW", "");
        }
    }
}
