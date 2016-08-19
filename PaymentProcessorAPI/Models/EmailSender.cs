using PaymentProcessor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace PaymentProcessorAPI.Models
{
    public class EmailSender
    {
        static string email = "paymentprocessornotifier@gmail.com";
        static string password = "senhatemporaria2";

        public static void sendEmail(Sale sale)
        {
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(EmailSender.email, EmailSender.password);
            SmtpServer.EnableSsl = true;
            MailMessage mail = new MailMessage(EmailSender.email, sale.Student.EmailParent.EmailAddress);
            mail.Subject = "Aviso de compra: " + sale.Student.Name + " " + sale.Student.LastName + " - " + sale.DateTimeSale.ToString();
            mail.IsBodyHtml = true;
            //mail.Body = sale.Student.Name + " fez uma compra de R$" + sale.Value.ToString() + " em " + sale.DateTimeSale.ToString()
            //    + ". Seu saldo disponível no momento é: R$" + sale.Student.Balance.ToString();

            string template = EmailTemplate();
            template = template.Replace("ViewBag.Name", sale.Student.Name + " " + sale.Student.LastName)
                .Replace("ViewBag.Valor", sale.Value.ToString())
                .Replace("ViewBag.Data", sale.DateTimeSale.ToString())
                .Replace("ViewBag.Saldo", sale.Student.Balance.ToString());

            mail.Body = template;

            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception) { }
            
        }

        static internal string EmailTemplate()
        {
            return "<body><p style=\"font-size:22px;\"<b>ViewBag.Name</b> fez uma compra de<b> R$ViewBag.Valor </b> em ViewBag.Data.<br/>O seu saldo disponível no momento é de<b> R$ViewBag.Saldo.</b></p></body></html>";
        }
    }
}