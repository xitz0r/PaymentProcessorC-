using PaymentProcessor.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor.Forms
{
    public partial class RechForm : Form
    {
        private int studentId;

        public RechForm(int id)
        {
            this.studentId = id;
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

        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(textBoxValue.Text, out value))
            {
                Sale sale = new Sale(double.Parse(this.textBoxValue.Text), null, null);
                Student student = new Student();
                student.Id = this.studentId;
                sale.Student = student;
                sale.IsReload = true;
                MessageBox.Show(sale.send());
                this.Close();
            }
            else
                MessageBox.Show("Insira um valor válido.");
        }
    }
}
