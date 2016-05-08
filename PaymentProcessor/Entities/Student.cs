using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string CPF { get; set; }
        public virtual IList<Card> Cards { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual DateTime DateTimeCreated { get; set; }
    }

    public class InvalidCPFException : Exception
    {
        public InvalidCPFException()
        {
        }
    }
}
