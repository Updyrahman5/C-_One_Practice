using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayweek = dweek.Text;
            string mon = month.Text;
            string daymonth = dMonth.Text;
            string yr = year.Text;

            string result = dayweek + " " + mon + " " + daymonth + " " + yr;
            Result.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dweek.Clear();
            month.Clear();
            dMonth.Clear();
            year.Clear();
            Result.Text=" ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
