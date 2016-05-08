using NHibernate;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.DAO
{
    public class StudentDAO
    {
        private ISession session;


        public StudentDAO(ISession session)
        {
            this.session = session;
        }

        public void Add(Student student)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(student);
            transacao.Commit();
        }
    }
}
