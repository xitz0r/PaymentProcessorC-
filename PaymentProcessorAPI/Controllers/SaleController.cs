using PaymentProcessor.DAO;
using PaymentProcessor.Entities;
using PaymentProcessor.Infra;
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

            SaleDAO saleDAO = new SaleDAO(NHibernateHelper.OpenSession());
            CardDAO cardDAO = new CardDAO(NHibernateHelper.OpenSession());
            StudentDAO studentDAO = new StudentDAO(NHibernateHelper.OpenSession());

            Card card = cardDAO.Get(sale.Card.PAN);
            Student student;

            if (card == null)
                return Request.CreateResponse(HttpStatusCode.NotFound);

            student = card.Student;

            if (sale.IsReload || sale.WasRefunded)
            {
                saleDAO.Add(sale);
                student.Balance += sale.Value;
                studentDAO.Update(student);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else //sale
            {
                //verifying password
                if (student.CheckPassword(sale.Password))
                {
                    saleDAO.Add(sale);
                    student.Balance -= sale.Value;
                    studentDAO.Update(student);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                else
                    return Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
        }
    }
}
