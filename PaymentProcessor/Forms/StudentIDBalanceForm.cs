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
    public partial class StudentIDBalanceForm : Form
    {

        public StudentIDBalanceForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
            {
                //bacalhau
                Sale sale = new Sale(0, null, null);
                MessageBox.Show(sale.sendBalance(textBoxId.Text));
                this.Close();
            }
        }

    }
}

