using NHibernate;
using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
using PaymentProcessorAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaymentProcessorAPI.Controllers
{
    public class SaleController : ApiController
    {
        public HttpResponseMessage Post([FromBody] Sale sale)
        {
            if (sale == null)
                Request.CreateResponse(HttpStatusCode.NoContent);

            ISession session = NHibernateHelper.OpenSession();
            SaleDAO saleDAO = new SaleDAO(session);
            CardDAO cardDAO = new CardDAO(session);
            StudentDAO studentDAO = new StudentDAO(session);
            Student student;

            if (sale.IsReload || sale.WasRefunded)
            {
                student = studentDAO.Get(sale.Student.Id);
                if (student == null)
                    return ReturnResponse(session, HttpStatusCode.NotFound);

                saleDAO.Add(sale);
                student.Balance += sale.Value;
                studentDAO.Update(student);
                return ReturnResponse(session, HttpStatusCode.OK);
            }
            else //sale
            {
                Card card = cardDAO.Get(sale.Card.PAN);
                if (card == null)
                    return ReturnResponse(session, HttpStatusCode.NotFound);

                student = card.Student;

                if (card.Blocked)
                    return ReturnResponse(session, HttpStatusCode.UpgradeRequired);
                else if (!student.CheckPassword(sale.Password))
                    return ReturnResponse(session, HttpStatusCode.Conflict);
                else if (student.Balance < sale.Value)
                    return ReturnResponse(session, HttpStatusCode.Unauthorized);
                else
                {
                    sale.Student = student;
                    student.Sales.Add(sale);
                    saleDAO.Add(sale);
                    student.Balance -= sale.Value;
                    studentDAO.Update(student);

                    EmailSender.sendEmail(sale);

                    return ReturnResponse(session, HttpStatusCode.OK);
                }
            }
        }

        internal HttpResponseMessage ReturnResponse(ISession session, HttpStatusCode code)
        {
            session.Close();
            return Request.CreateResponse(code);
        }
    }
}
