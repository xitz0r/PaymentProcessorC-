using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            ManagerMenuForm managerMenuForm = new ManagerMenuForm();
            this.Hide();
            managerMenuForm.ShowDialog();
            this.Show();
        }

        private void buttonShopkeeper_Click(object sender, EventArgs e)
        {
           // NHibernateHelper.GenerateSchema();
            ShopkeeperMenu shopkeeperMenu = new ShopkeeperMenu();
            this.Hide();
            shopkeeperMenu.ShowDialog();
            this.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
