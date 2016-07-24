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
    public partial class PasswordForm : Form
    {
        public string ReturnValuePassword;

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnValuePassword = Encryptor.MD5Hash("1234");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void okPin_Click(object sender, EventArgs e)
        {
            if (pinText.Text != "")
            {
                ReturnValuePassword = Encryptor.MD5Hash(pinText.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}
