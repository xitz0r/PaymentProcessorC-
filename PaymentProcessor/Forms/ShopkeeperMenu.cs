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
    public partial class ShopkeeperMenu : Form
    {
        public ShopkeeperMenu()
        {
            InitializeComponent();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            SaleForm saleForm = new SaleForm();
            this.Hide();
            saleForm.ShowDialog();
            this.Show();
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            StudentIDBalanceForm studentForm = new StudentIDBalanceForm();
            this.Hide();
            studentForm.ShowDialog();
            this.Show();
        }
    }
}
