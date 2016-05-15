using NHibernate;
using NUnit.Framework;
using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Tests
{
    [TestFixture]
    class StudentDAOTest
    {
        private ISession session;

        [OneTimeSetUp]
        public void PreparingTests()
        {
            NHibernateHelper.GenerateSchema();
            session = NHibernateHelper.OpenSession();
        }

        [Test]
        public void CantInsertSameCPFAgain()
        {
            Student student1 = new Student("Bruno", "Paulo", DateTime.Now, new Email("emailStudent1@gmail.com"), new Email("emailParent1@gmail.com"), "1234");
            Student student2 = new Student("Pablo", "Montenegro", DateTime.Now, new Email("emailStudent2@gmail.com"), new Email("emailParent2@gmail.com"), "1234");

            StudentDAO studentDAO = new StudentDAO(session);

            studentDAO.Add(student1);
            Assert.Throws<NHibernate.Exceptions.GenericADOException>(() => studentDAO.Add(student2));

        }

        [OneTimeTearDown]
        public void FinalizeTests()
        {
            session.Close();
        }
    }
}
