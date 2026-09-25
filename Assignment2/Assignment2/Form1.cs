using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name = textname.Text;
            string id = textID.Text;
            string dept = textdept.Text;
            string semester = textsemester.Text;

            string result = name + " " + id + " " + dept + " " + semester;
            lbloutput.Text = result;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textID.Clear();
            textdept.Clear();
            textsemester.Clear();
            lbloutput.Text = " ";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
