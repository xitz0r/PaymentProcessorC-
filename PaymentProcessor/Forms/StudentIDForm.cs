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

namespace PaymentProcessor.Forms
{
    public partial class StudentIDForm : Form
    {
        public StudentIDForm()
        {
            InitializeComponent();
        }

        private void okMat_Click(object sender, EventArgs e)
        {
            if (matAluno.Text != "")
            {
                FormCard formCard = new FormCard();
                DialogResult showFormCard;

                this.Hide();
                showFormCard = formCard.ShowDialog();

                if (showFormCard == DialogResult.OK)
                {
                    ISession session = NHibernateHelper.OpenSession();
                    StudentDAO studentDAO = new StudentDAO(session);
                    Student student = studentDAO.Get(Int32.Parse(matAluno.Text));
                    if (student == null)
                        MessageBox.Show("Aluno inexistente");
                    else
                    {
                        Card card = formCard.ReturnValueCard;
                        CardDAO cardDAO = new CardDAO(session);

                        if (cardDAO.Get(card.PAN) == null)
                        {
                            foreach (Card c in student.Cards)
                                if (!c.Blocked)
                                {
                                    MessageBox.Show("Erro", "Já existe um cartão ativo");
                                    return;
                                }

                            student.Cards.Add(card);
                            cardDAO.Add(card);
                            studentDAO.Update(student);
                        }
                        else
                            MessageBox.Show("Erro", "Cartão já cadastrado");
                    }
                    session.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (matAluno.Text != "")
            {
                FormCard formCard = new FormCard();
                DialogResult showFormCard;

                this.Hide();
                showFormCard = formCard.ShowDialog();

                if (showFormCard == DialogResult.OK)
                {
                    ISession session = NHibernateHelper.OpenSession();
                    StudentDAO studentDAO = new StudentDAO(session);
                    Student student = studentDAO.Get(Int32.Parse(matAluno.Text));
                    if (student == null)
                        MessageBox.Show("Aluno inexistente");
                    else
                    {
                        Card card = formCard.ReturnValueCard;
                        CardDAO cardDAO = new CardDAO(session);
                        foreach (Card c in student.Cards)
                            if (!c.Blocked)
                            {
                                c.Blocked = true;
                                cardDAO.Update(c);
                                MessageBox.Show("Cartão bloqueado com sucesso.");
                            }
                        MessageBox.Show("Não há cartões ativos para esse aluno.");
                    }
                    session.Close();
                }
            }
        }
    }
}
