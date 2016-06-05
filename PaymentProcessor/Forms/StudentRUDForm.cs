using NHibernate;
using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Forms;
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

namespace PaymentProcessor
{
    public partial class StudentRUDForm : Form
    {
        private int numberOfStudents;
        private ISession session;
        private StudentDAO studentDAO;
        private Student student;

        public StudentRUDForm()
        {
            InitializeComponent();
        }

        private void StudentRUDForm_Load(object sender, EventArgs e)
        {
            this.session = NHibernateHelper.OpenSession();
            this.studentDAO = new StudentDAO(this.session);

            this.student = this.studentDAO.GetFirst();
            this.Fill(student);

            //counts number of students
            this.numberOfStudents = this.studentDAO.GetTotal();
        }

        private void Fill(Student student)
        {
            if (student != null)
            {
                this.student = student;
                this.idTextBox.Text = student.Id.ToString();
                this.nameTextBox.Text = student.Name;
                this.lastNameTextBox.Text = student.LastName;
                this.birthdayDateTimePicker.Value = student.Birthday;
                this.emailTextBox.Text = student.EmailStudent.EmailAddress;
                this.emailParentTextBox.Text = student.EmailParent.EmailAddress;
                this.balanceTextBox.Text = student.Balance.ToString();
            }
        }

        private void buttonNext_click(object sender, EventArgs e)
        {
            Student student = this.studentDAO.GetNextAfter(Int32.Parse(this.idTextBox.Text));
            this.Fill(student);
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            Student student = this.studentDAO.GetPreviousBefore(Int32.Parse(this.idTextBox.Text));
            this.Fill(student);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id;

            if (Int32.TryParse(this.idTextBox.Text, out id))
            {
                Student student = this.studentDAO.Get(id);
                if (student == null)
                    MessageBox.Show("Estudante não encontrado", "Erro");
                else
                    this.Fill(student);
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(Int32.Parse(this.idTextBox.Text));
            this.Hide();
            changePasswordForm.ShowDialog();
            this.Show();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            enable_Edition();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar?", "Atualizar aluno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                disable_Edition();

                this.Fill(this.student);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                new Student(this.nameTextBox.Text,
                            this.lastNameTextBox.Text,
                            this.birthdayDateTimePicker.Value,
                            new Email(this.emailTextBox.Text),
                            new Email(this.emailParentTextBox.Text),
                            1234);  //validating modified student fields

                this.student.Name = this.nameTextBox.Text;
                this.student.LastName = this.lastNameTextBox.Text;
                this.student.Birthday = this.birthdayDateTimePicker.Value;
                this.student.EmailStudent = new Email(this.emailTextBox.Text);
                this.student.EmailParent = new Email(this.emailParentTextBox.Text);

                this.studentDAO.Update(this.student);
                disable_Edition();

                MessageBox.Show("Modificado com sucesso", "Editar estudante");
            }
            catch (Exception ex)    //at least one field with error
            {
                SystemSounds.Beep.Play();
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void enable_Edition()
        {
            this.buttonPrevious.Enabled = false;
            this.buttonNext.Enabled = false;
            this.buttonSearch.Enabled = false;
            this.idTextBox.Enabled = false;
            this.buttonChangePassword.Enabled = false;

            this.buttonCancel.Enabled = true;
            this.buttonSave.Enabled = true;
            this.nameTextBox.Enabled = true;
            this.lastNameTextBox.Enabled = true;
            this.birthdayDateTimePicker.Enabled = true;
            this.emailTextBox.Enabled = true;
            this.emailParentTextBox.Enabled = true;
        }

        private void disable_Edition()
        {
            this.buttonPrevious.Enabled = true;
            this.buttonNext.Enabled = true;
            this.buttonSearch.Enabled = true;
            this.idTextBox.Enabled = true;
            this.buttonChangePassword.Enabled = true;

            this.buttonCancel.Enabled = false;
            this.buttonSave.Enabled = false;
            this.nameTextBox.Enabled = false;
            this.lastNameTextBox.Enabled = false;
            this.birthdayDateTimePicker.Enabled = false;
            this.emailTextBox.Enabled = false;
            this.emailParentTextBox.Enabled = false;

            this.student = this.studentDAO.Get(this.student.Id);
            this.Fill(student);
        }
    }
}
