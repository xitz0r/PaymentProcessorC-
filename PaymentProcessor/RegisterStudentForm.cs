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
    public partial class RegisterStudentForm : Form
    {
        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void RegisterStudentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void RegisterStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void buttonBirthday_Click(object sender, EventArgs e)
        {
            monthCalendar.Show();
        }

        private void maskedTextBoxCPF_TextChanged(object sender, EventArgs e)
        {
            //maskedTextBoxCPF.Text = maskedTextBoxCPF.Text.PadLeft(11, '0');
            //TODO mascarar CPF
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard(this);
            this.Hide();
            formCard.ShowDialog();
            this.Show();
        }

        public string labelSwipedCardText
        {
            set
            {
                labelSwipedCard.Text = value;
            }
        }

    }
}
