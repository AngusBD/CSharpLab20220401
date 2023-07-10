using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5PracticeQ4
{
    public partial class Form1 : Form
    {
        public static Random r = new Random();
        int ran;

        public Form1()
        {
            InitializeComponent();
            ran = r.Next(11, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            if (ran == num)
            {
                MessageBox.Show("Congratulations!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Clear();
            }
            else if (num > ran && num < int.Parse(label3.Text))
            {
                MessageBox.Show("Enter a lower number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                label3.Text = num.ToString();
                textBox1.Clear();
            }
            else if (num < ran && num > int.Parse(label2.Text))
            {
                MessageBox.Show("Enter a higher number", "Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                label2.Text = num.ToString();
                textBox1.Clear();
            }
            else if (num <= int.Parse(label2.Text) || num >= int.Parse(label3.Text))
            {
                MessageBox.Show($"Please enter a number between {label2.Text} and {label3.Text}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Clear();
            }
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "10";
            label3.Text = "100";
            textBox1.Clear();
            textBox1.Focus();
            ran = r.Next(11, 100);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
