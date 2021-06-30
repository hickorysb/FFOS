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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Shown(object sender, EventArgs e)
        {
            //TO-DO: ADD ACTUAL WORK HERE
            DatabaseConnector.ConnectToDatabase();
            await Task.Delay(4000);
            label1.Text = "Loading menu items...";
            await Task.Delay(2500);
            label1.Text = "Loading employee permission data...";
            DatabaseConnector.PullEmployeeData();
            await Task.Delay(1000);
            label1.Text = "Fetching terminal job assignment...";
            await Task.Delay(1000);
            label1.Text = "Loading current orders...";
            await Task.Delay(5000);
            label1.Text = "Checking integrity of terminal peripherals...";
            await Task.Delay(1500);
            label1.Text = "Preparing user interface...";
            await Task.Delay(2000);
            DriveThruOrder DTO = new DriveThruOrder();
            this.Hide();
            DTO.Closed += (s, args) => this.Close();
            DTO.Show();
        }
    }
}
