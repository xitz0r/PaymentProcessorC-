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

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxValue.Text != "")
            {
                Sale sale = new Sale(double.Parse(this.textBoxValue.Text), null, null);
                Student student = new Student();
                student.Id = this.studentId;
                sale.Student = student;
                sale.IsReload = true;
                MessageBox.Show(sale.send());
                this.Close();
            }
        }
    }
}
