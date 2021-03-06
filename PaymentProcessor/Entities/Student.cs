﻿using System;
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
        public virtual IList<Card> Cards { get; set; }
        public virtual DateTime Birthday { get; set; }
        public virtual DateTime DateTimeCreated { get; set; }
        public virtual Email EmailStudent { get; set; }
        public virtual Email EmailParent { get; set; }
        public virtual double Balance { get; set; }
        public virtual string Password { get; set; }
        public virtual IList<Sale> Sales { get; set; }

        public Student() {}

        public Student(string name, string lastName, DateTime birthday, Email email, Email emailParent, int password)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Birthday = birthday;
            this.DateTimeCreated = DateTime.Now;
            this.EmailStudent = email;
            this.EmailParent = emailParent;
            this.Password = Encryptor.MD5Hash(password.ToString());
            this.Balance = 0.0;

            CheckInstance(); //checks if this instance is a valid one
        }

        private void CheckInstance()
        {
            string errorMsg = "";

            if (String.IsNullOrEmpty(this.Name))
                errorMsg = "Nome vazio";
            else if (String.IsNullOrEmpty(this.LastName))
                errorMsg = "Sobrenome vazio";
            else if (String.IsNullOrEmpty(this.Password))
                errorMsg = "Senha vazia";

            if (!String.IsNullOrEmpty(errorMsg))
                throw (new Exception(errorMsg));
        }

        public virtual void ChangePassword(int password)
        {
            this.Password = Encryptor.MD5Hash(password.ToString());
        }

        public virtual bool CheckPassword(string password)
        {
            return password == this.Password;
        }
    }

    public class InvalidCPFException : Exception
    {
        public InvalidCPFException()
        {
        }
    }
}
