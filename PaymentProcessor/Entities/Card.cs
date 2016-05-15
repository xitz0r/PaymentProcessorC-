using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    public class Card
    {
        public virtual int Id { get; set; }
        public virtual string PAN { get; set; }
        public virtual string Track1 { get; set; }
        public virtual string Track2 { get; set; }
        public virtual DateTime ExpirationDate { get; set; }
        public virtual int CVV2 { get; set; }
        public virtual Boolean Blocked { get; set; }
        public virtual Student Student { get; set; }
    }
}
