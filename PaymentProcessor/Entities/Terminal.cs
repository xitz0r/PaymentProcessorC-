using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    public class Terminal
    {
        public virtual int Id { get; set; }
        public virtual bool IsAdmin { get; set; }
        public virtual string TerminalId { get; set; }
        public virtual string Description { get; set; }
        public virtual IList<Sale> Sales { get; set; }
    }
}
