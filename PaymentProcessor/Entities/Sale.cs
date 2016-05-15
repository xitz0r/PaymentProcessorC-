using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    public class Sale
    {
        public virtual int Id { get; set; }
        public virtual double Value { get; set; }
        public virtual DateTime DateTimeSale { get; set; }
        public virtual bool WasRefunded { get; set; }
        public virtual bool IsReload { get; set; }
        public virtual Student Student { get; set; }
        public virtual Terminal Terminal { get; set; }
    }
}
