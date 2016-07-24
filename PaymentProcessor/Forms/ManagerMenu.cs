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
    public partial class ManagerMenuForm : Form
    {
        public ManagerMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterStudentForm studentForm = new RegisterStudentForm();
            this.Hide();
            studentForm.ShowDialog();
            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            StudentRUDForm studentRUDForm = new StudentRUDForm();
            this.Hide();
            studentRUDForm.ShowDialog();
            this.Show();
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            StudentIDForm studentidform = new StudentIDForm();
            this.Hide();
            studentidform.ShowDialog();
            this.Show();
        }
    }
}
