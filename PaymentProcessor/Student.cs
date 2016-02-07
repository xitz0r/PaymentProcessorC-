using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor
{
    class Student
    {
        private string name, lastName, cpf, card;
        private DateTime birthday, dateTimeCreated;


        public Student(string pName, string pLastName, string pCPF, DateTime pBirthday, string pCard)
        {
           this.name = pName;
            this.lastName = pLastName;
            this.cpf = pCPF;
            this.birthday = pBirthday;
            this.card = pCard;
            this.dateTimeCreated = DateTime.Now;
        }
    }

    public class InvalidCPFException : Exception
    {
        public InvalidCPFException()
        {
        }
    }

    public class CPFExistsException : Exception
    {
        public CPFExistsException()
        {
        }
    }
}
