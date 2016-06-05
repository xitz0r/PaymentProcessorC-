using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
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

        internal int GetTotal()
        {
            return this.session.QueryOver<Student>().RowCount();
        }

        public Student GetFirst()
        {
            return this.session.Query<Student>().FirstOrDefault();
        }

        public Student Get(int id)
        {
            ITransaction transaction = session.BeginTransaction();
            Student student = session.Get<Student>(id);
            transaction.Commit();
            return student;
        }

        public Student GetNextAfter(int id)
        {
            Student student = null;
            ICriteria criteria = session.CreateCriteria<Student>();
            criteria.Add(Restrictions.Gt("Id", id))
                    .SetMaxResults(1);

            try    //may not have next student
            {
                student = criteria.List<Student>().First<Student>();
            }
            catch (Exception) { }

            return student;
        }

        public Student GetPreviousBefore(int id)
        {
            Student student = null;
            ICriteria criteria = session.CreateCriteria<Student>();
            criteria.Add(Restrictions.Lt("Id", id))
                    .SetMaxResults(1);

            try    //may not have previous student
            {
                student = criteria.List<Student>().First<Student>();
            }
            catch (Exception) { }

            return student;
        }

        public void Update(Student student)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Update(student);
            transacao.Commit();
        }
    }
}
