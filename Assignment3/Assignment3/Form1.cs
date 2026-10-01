using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Creating variables
                string food1 = textfood1.Text;
                int price1 = int.Parse(textprice1.Text);

                string food2 = textfood2.Text;
                int price2 = int.Parse(textprice2.Text);

                // Calculate tax
                double tax = (price1 + price2) * 0.07;

                // Calculate total
                double total = price1 + price2 + tax;

                // Label output of result
                display.Text = "tax is $" + tax.ToString("0.00") + " total is $" + total.ToString("0.00");
            }
            catch
            {
                MessageBox.Show("enter valid");
            }
        }
    }
}
