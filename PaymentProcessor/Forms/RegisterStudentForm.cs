using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentProcessor
{
    public partial class RegisterStudentForm : Form
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='" + Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\dbpp.mdf';Integrated Security = True; Connect Timeout = 30");
        bool bSaved = false;
        bool invalid = false;

        public RegisterStudentForm()
        {
            sqlConnection.Open();
            InitializeComponent();
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard();
            this.Hide();
            formCard.ShowDialog();
            this.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string errorMsg = "", sId;

            if (textBoxNome.Text == "")
                errorMsg = "Nome vazio";
            else if (textBoxSobrenome.Text == "")
                errorMsg = "Sobrenome vazio";
            else if (!IsValidEmail(textBoxEmailStudent.Text))
                errorMsg = "E-mail estudante inválido";
            else if (!IsValidEmail(textBoxEmailParent.Text))
                errorMsg = "E-mail responsável inválido";
            else if (textBoxPassword.Text == "")
                errorMsg = "Senha vazia";
            else if (textBoxPasswordConfirm.Text == "")
                errorMsg = "Confirmação de senha vazia";
            else if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
                errorMsg = "Senhas não conferem";

            if (errorMsg != "") //at least one field with error
            {
                sqlConnection.Close();
                SystemSounds.Beep.Play();
                MessageBox.Show(errorMsg, "Erro");
                return;
            }

            sId = Insert_Student();
            bSaved = true;
            MessageBox.Show("Cadastro efetuado com sucesso!\n\nMatrícula: " + sId, "Cadastro");
            this.Close();
        }

        private bool IsValidEmail(string psEmail)
        {
            if (String.IsNullOrEmpty(psEmail))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                psEmail = Regex.Replace(psEmail, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(psEmail,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
       {
          // IdnMapping class with default property values.
          IdnMapping idn = new IdnMapping();

          string domainName = match.Groups[2].Value;
          try {
             domainName = idn.GetAscii(domainName);
          }
          catch (ArgumentException) {
             invalid = true;
          }
          return match.Groups[1].Value + domainName;
       }

        private void RegisterStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bSaved && MessageBox.Show("Deseja cancelar?", "Cadastrar aluno", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
            else
                sqlConnection.Close();
        }

        private string Insert_Student()
        {
            string sDate = this.dateTimePickerNascimento.Value.ToString().Substring(0, 10);
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
        }

        /*
        private void Update_Student()
        {
            string sDate = this.dateTimePickerNascimento.Value.ToString().Substring(0, 10);
            SqlCommand sqlCmd;

            sqlCmd = sqlConnection.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "UPDATE Student SET "
                + "name='" + textBoxNome.Text
                + "', lastName='" + textBoxSobrenome.Text
                + "', birthday='" + sDate.Substring(6, 4) + sDate.Substring(3, 2) + sDate.Substring(0, 2)
                + "' WHERE cpf='" + maskedTextBoxCPF.Text + "'";

            sqlCmd.ExecuteNonQuery();
        }
        */

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
