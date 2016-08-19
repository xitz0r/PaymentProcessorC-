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
    public partial class StudentIDRecForm : Form
    {
        public StudentIDRecForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RechForm rechForm = new RechForm(Int32.Parse(textBoxId.Text));
            this.Hide();
            rechForm.ShowDialog();
            this.Show();
        }

    }
}
