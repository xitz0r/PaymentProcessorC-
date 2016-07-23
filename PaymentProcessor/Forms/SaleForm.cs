using PaymentProcessor.Entities;
using PaymentProcessor.Forms;
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
        private Card card;
        private string password;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void buttonGeneralClick(char key)
        {
            string text = textBoxValue.Text;

            if (!text.Contains(',') || (text.IndexOf(',') + 3 > text.Length))
                textBoxValue.Text += key;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxValue.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('9');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonGeneralClick('0');
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

        private void buttonCard_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard();
            DialogResult showFormCard;

            this.Hide();
            showFormCard = formCard.ShowDialog();

            if (showFormCard == DialogResult.OK)
            {
                this.card = formCard.ReturnValueCard;

                PasswordForm passwordForm = new PasswordForm();
                this.Hide();
                showFormCard = passwordForm.ShowDialog();

                if (showFormCard == DialogResult.OK)
                {
                    this.password = passwordForm.ReturnValuePassword;

                    Sale sale = new Sale(double.Parse(this.textBoxValue.Text), this.card, this.password);
                    sale.send();
                    this.Close();
                }
            }
            else
                this.Show();
        }
    }
}
