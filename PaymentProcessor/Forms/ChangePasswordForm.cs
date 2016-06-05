using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private int studentId;
        private bool updated;

        public ChangePasswordForm(int studentId)
        {
            this.studentId = studentId;
            this.updated = false;
            InitializeComponent();
        }

        private void ChangePasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.updated && MessageBox.Show("Deseja cancelar?", "Trocar senha", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPassword.Text))
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Senha vazia", "Erro");
            }
            else if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Senhas não conferem", "Erro");
            }
            else
            {
                StudentDAO studentDAO = new StudentDAO(NHibernateHelper.OpenSession());
                Student student = studentDAO.Get(this.studentId);
                student.ChangePassword(Int32.Parse(textBoxPassword.Text));
                studentDAO.Update(student);

                this.updated = true;

                MessageBox.Show("Senha trocada com sucesso", "Trocar senha");

                this.Close();
            }
        }
    }
}
