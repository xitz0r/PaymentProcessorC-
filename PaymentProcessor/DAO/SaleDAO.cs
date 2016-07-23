using NHibernate;
using NHibernate.Criterion;
using PaymentProcessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.DAO
{
    public class SaleDAO
    {
        private ISession session;


        public SaleDAO(ISession session)
        {
            this.session = session;
        }

        public void Add(Sale sale)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(sale);
            transacao.Commit();
        }

        internal int GetTotal()
        {
            return this.session.QueryOver<Sale>().RowCount();
        }

        public Sale Get(int id)
        {
            return session.Get<Sale>(id);
        }

        public void Update(Sale sale)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Update(sale);
            transacao.Commit();
        }
    }
}
