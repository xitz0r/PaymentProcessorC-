using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidacaoCPF;

namespace PaymentProcessor
{
    class Student
    {
        private string name, lastName, cpf, card;
        private DateTime birthday, dateTimeCreated;


        public Student(string pName, string pLastName, string pCPF, DateTime pBirthday, string pCard)
        {
            if (!ValidadorCPF.Valido(pCPF))
                throw new InvalidCPFException();
            else if (Exists(pCPF))
                throw new CPFExistsException();

            this.name = pName;
            this.lastName = pLastName;
            this.cpf = pCPF;
            this.birthday = pBirthday;
            this.card = pCard;
            this.dateTimeCreated = DateTime.Now;
        }

        public static bool Exists(string cpf)
        {
            if (!ValidadorCPF.Valido(cpf))
                throw new InvalidCPFException();

            

            return false; //TODO e olhar no banco e ver se o cpf existe
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
