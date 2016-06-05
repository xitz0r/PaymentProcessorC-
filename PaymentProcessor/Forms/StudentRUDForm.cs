using NHibernate;
using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
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
    public partial class StudentRUDForm : Form
    {
        private int numberOfStudents;
        private ISession session;
        private StudentDAO studentDAO;

        public StudentRUDForm()
        {
            InitializeComponent();
        }

        private void StudentRUDForm_Load(object sender, EventArgs e)
        {
            this.session = NHibernateHelper.OpenSession();
            this.studentDAO = new StudentDAO(this.session);

            Student student = this.studentDAO.GetFirst();
            this.Fill(student);

            //counts number of students
            this.numberOfStudents = new StudentDAO(NHibernateHelper.OpenSession()).GetTotal();
        }

        private void Fill(Student student)
        {
            if (student != null)
            {
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
    }
}
