using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class RegisterStudentForm : Form
    {
        bool bSaved = false;

        public RegisterStudentForm()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorMsg = "";

            if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
                errorMsg = "Senhas não conferem";

            if (!String.IsNullOrEmpty(errorMsg))
            {
                ShowError(errorMsg);
                return;
            }

            try
            {
                Student student = new Student(this.textBoxNome.Text,
                                    this.textBoxSobrenome.Text,
                                    this.dateTimePickerNascimento.Value,
                                    new Email(this.textBoxEmailStudent.Text),
                                    new Email(this.textBoxEmailParent.Text),
                                    this.textBoxPassword.Text);

                StudentDAO studentDAO = new StudentDAO(NHibernateHelper.OpenSession());
                studentDAO.Add(student);
                bSaved = true;
                MessageBox.Show("Cadastro efetuado com sucesso!\n\nMatrícula: " + student.Id, "Cadastro");
                this.Close();
            }
            catch (Exception ex)    //at least one field with error
            {
                ShowError(ex.Message);
            }
        }

        private void ShowError(string errorMsg)
        {
            SystemSounds.Beep.Play();
            MessageBox.Show(errorMsg, "Erro");
        }

        private void RegisterStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bSaved && MessageBox.Show("Deseja cancelar?", "Cadastrar aluno", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
            //else
                //sqlConnection.Close();
        }

        private string Insert_Student()
        {
            string sDate = this.dateTimePickerNascimento.Value.ToString().Substring(0, 10);
            /*
            SqlCommand sqlCmd;

            sqlCmd = sqlConnection.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO Student (name, lastName, birthday, email, emailParent, password) VALUES ('"
                + this.textBoxNome.Text + "', '"
                + this.textBoxSobrenome.Text + "', '"
                + sDate.Substring(6, 4) + sDate.Substring(3, 2) + sDate.Substring(0, 2) + "', '"
                + textBoxEmailStudent.Text + "', '"
                + textBoxEmailParent.Text + "', '"
                + Encryptor.MD5Hash(textBoxPassword.Text) + "'); SELECT SCOPE_IDENTITY();";

            return sqlCmd.ExecuteScalar().ToString();
            */
            return "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = "";
            textBoxSobrenome.Text = "";
            dateTimePickerNascimento.Value = DateTime.Now;
            textBoxEmailStudent.Text = "";
            textBoxEmailParent.Text = "";
            textBoxPassword.Text = "";
            textBoxPasswordConfirm.Text = "";
        }
    }
}
