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
    public class CardDAO
    {
        private ISession session;


        public CardDAO(ISession session)
        {
            this.session = session;
        }

        public void Add(Card card)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Save(card);
            transacao.Commit();
        }

        public Card Get(string pan)
        {
            ICriteria criteria = session.CreateCriteria<Card>();
            if (pan != null)
                criteria.Add(Restrictions.Eq("PAN", pan));

            return criteria.UniqueResult<Card>();
        }

        public void Update(Card card)
        {
            ITransaction transacao = session.BeginTransaction();
            session.Update(card);
            transacao.Commit();
        }
    }
}
