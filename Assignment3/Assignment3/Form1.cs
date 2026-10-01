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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Getting all user inputs from textboxes
                string customerName = txtCustomer.Text;
                double previous = double.Parse(txtPrevious.Text);
                double current = double.Parse(txtCurrent.Text);
                double unitPrice = double.Parse(txtUnitPrice.Text);

                // Calculations
                double unitsUsed = current - previous;

                double bill = (unitsUsed * unitPrice);
                double tax = bill * 0.07;   
                double fixedCharge = 5;

                double total = bill + tax + fixedCharge;

                // OUTPUT
                lblUnits.Text = "Units Used: " + unitsUsed.ToString();
                lblBill.Text = "Bill: $" + tax.ToString("0.00");
                lblTotal.Text = "Total Bill: $" + total.ToString("0.00");
            }
            catch
            {
                //if user enters invalid input, show error mess
                MessageBox.Show("Enter valid numbers!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
