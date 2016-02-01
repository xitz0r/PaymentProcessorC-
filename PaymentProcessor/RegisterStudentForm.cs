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
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename='" + Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + "\\dbpp.mdf';Integrated Security = True; Connect Timeout = 30");
        bool creatingUser = false;
        bool bSaved = false;

        public RegisterStudentForm()
        {
            sqlConnection.Open();
            InitializeComponent();
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            FormCard formCard = new FormCard(this);
            this.Hide();
            formCard.ShowDialog();
            this.Show();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Student student;
            string errorMsg = "";

            if (textBoxNome.Text == "")
                errorMsg = "Nome vazio";
            else if (textBoxSobrenome.Text == "")
                errorMsg = "Sobrenome vazio";

            if (errorMsg == "")
            {
                try
                {
                    //TODO passar cartão
                    student = new Student(textBoxNome.Text, textBoxSobrenome.Text, maskedTextBoxCPF.Text, dateTimePickerNascimento.Value, "");
                }
                catch (InvalidCPFException)
                {
                    errorMsg = "CPF inválido";
                }
            }

            if (creatingUser)
            {
                //checking if student is on the db
                SqlCommand sqlCmd;
                sqlCmd = sqlConnection.CreateCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE cpf='" + this.maskedTextBoxCPF.Text + "'";

                if ((errorMsg == "") && ((int)sqlCmd.ExecuteScalar() > 0))
                    errorMsg = "Estudante já cadastrado";
            }

            if (errorMsg != "") //at least one field with error
            {
                sqlConnection.Close();
                SystemSounds.Beep.Play();
                MessageBox.Show(errorMsg, "Erro");
                return;
            }

            if (creatingUser)
                Insert_Student();
            else
                Update_Student();
            bSaved = true;
            this.Close();
        }

        private void RegisterStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bSaved && MessageBox.Show("Deseja cancelar?", "Cancelar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
            else
                sqlConnection.Close();
        }

        private void Insert_Student()
        {
            string sDate = this.dateTimePickerNascimento.Value.ToString().Substring(0, 10);
            SqlCommand sqlCmd;

            sqlCmd = sqlConnection.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "INSERT INTO Student (cpf, name, lastName, birthday) VALUES ('"
                + this.maskedTextBoxCPF.Text + "', '"
                + this.textBoxNome.Text + "', '"
                + this.textBoxSobrenome.Text + "', '"
                + sDate.Substring(6, 4) + sDate.Substring(3, 2) + sDate.Substring(0, 2) + "')";

            sqlCmd.ExecuteNonQuery();
        }

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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.maskedTextBoxCPF.Text = "";
            textBoxNome.Text = "";
            textBoxNome.Enabled = false;
            textBoxSobrenome.Text = "";
            textBoxSobrenome.Enabled = false;
            dateTimePickerNascimento.Value = DateTime.Now;
            dateTimePickerNascimento.Enabled = false;
            buttonEdit.Enabled = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!ValidacaoCPF.ValidadorCPF.Valido(this.maskedTextBoxCPF.Text))
                MessageBox.Show("CPF inválido", "Erro");
            else
            {
                SqlCommand sqlCmd;
                sqlCmd = sqlConnection.CreateCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE cpf='" + this.maskedTextBoxCPF.Text + "'";

                if ((int)sqlCmd.ExecuteScalar() == 0)
                {
                    if (MessageBox.Show("Usuário inexistente. Criar?", "Criar usuário", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        creatingUser = true;
                        textBoxNome.Enabled = true;
                        textBoxNome.Text = "";
                        textBoxSobrenome.Enabled = true;
                        textBoxSobrenome.Text = "";
                        dateTimePickerNascimento.Enabled = true;
                        dateTimePickerNascimento.Value = DateTime.Now;
                        buttonOk.Enabled = true;
                        buttonEdit.Enabled = false;
                        buttonClear.Enabled = false;
                        buttonSearch.Enabled = false;
                        maskedTextBoxCPF.Enabled = false;
                    }
                }
                else
                {
                    SqlDataReader sqlReader;
                    sqlCmd.CommandText = "SELECT name, lastName, birthday FROM STUDENT WHERE cpf='" + this.maskedTextBoxCPF.Text + "'";
                    sqlReader = sqlCmd.ExecuteReader();
                    sqlReader.Read();
                    this.textBoxNome.Text = sqlReader.GetString(0).Trim();
                    this.textBoxSobrenome.Text = sqlReader.GetString(1).Trim();
                    this.dateTimePickerNascimento.Text = sqlReader.GetDateTime(2).ToString();
                    this.buttonEdit.Enabled = true;
                    sqlReader.Close();
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxNome.Enabled = true;
            textBoxSobrenome.Enabled = true;
            dateTimePickerNascimento.Enabled = true;
            maskedTextBoxCPF.Enabled = false;
            buttonClear.Enabled = false;
            buttonSearch.Enabled = false;
            buttonEdit.Enabled = false;
            buttonOk.Enabled = true;
        }
    }
}
