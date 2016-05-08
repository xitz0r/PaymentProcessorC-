using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class SaleForm : Form
    {
        public SaleForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBoxValue.Text += "0";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text == "")
                textBoxValue.Text = "0,";
            else if (textBoxValue.Text.IndexOf(',') == -1)
                textBoxValue.Text += ",";
        }

        private void textBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBoxValue.Text = 
        }
    }
}
