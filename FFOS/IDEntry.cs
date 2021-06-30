using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace FFOS
{
    public partial class IDEntry : Form
    {
        public int Result;
        public IDEntry()
        {
            InitializeComponent();
            textBox1.ShortcutsEnabled = false;
            textBox1.ContextMenu = new ContextMenu();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 1;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 2;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 3;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 4;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 5;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 6;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 7;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 8;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 9;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 9) textBox1.Text += 0;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Result = int.Parse(textBox1.Text);
        }

        private void textBox1_PreviewExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy || e.Command == ApplicationCommands.Cut || e.Command == ApplicationCommands.Paste)
            {
                e.Handled = true;
            }
        }
    }
}
