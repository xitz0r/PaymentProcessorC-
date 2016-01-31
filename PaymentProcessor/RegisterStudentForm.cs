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
        SqlCommand sqlCmd;
        bool bSave = false;

        public RegisterStudentForm()
        {
            InitializeComponent();
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

                if ((errorMsg == "") && (labelSwipedCard.Text == ""))
                    errorMsg = "Cadastre o cartão";
            }

            //checking if student is on the db
            sqlCmd = sqlConnection.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlConnection.Open();

            sqlCmd.CommandText = "SELECT COUNT(*) FROM STUDENT WHERE cpf='" + this.maskedTextBoxCPF.Text + "'";
            int teste = (int)sqlCmd.ExecuteScalar();
            if ((teste > 0) && (errorMsg == ""))
                errorMsg = "Estudante já cadastrado";

            if (errorMsg != "") //at least one field with error
            {
                sqlConnection.Close();
                SystemSounds.Beep.Play();
                MessageBox.Show(errorMsg, "Erro");
                return;
            }

            Insert_Student(sqlCmd);
            bSave = true;
            sqlConnection.Close();
            this.Close();
        }

        private void RegisterStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bSave && MessageBox.Show("Esta ação cancelará o cadastro. Confirma?", "Fechar cadastro", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void Insert_Student(SqlCommand cmd)
        {
            string sDate = this.dateTimePickerNascimento.Value.ToString().Substring(0, 10);

            sqlCmd.CommandText = "INSERT INTO Student (cpf, name, lastName, birthday) VALUES ('"
                + this.maskedTextBoxCPF.Text + "', '"
                + this.textBoxNome.Text + "', '"
                + this.textBoxSobrenome.Text + "', '"
                + sDate.Substring(6, 4) + sDate.Substring(3, 2) + sDate.Substring(0, 2) + "')";

            sqlCmd.ExecuteNonQuery();
        }
    }
}
