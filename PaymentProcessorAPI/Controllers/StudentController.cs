using NHibernate;
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
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get([FromUri] int id)
        {
            ISession session = NHibernateHelper.OpenSession();
            StudentDAO studentDAO = new StudentDAO(session);
            Student student = studentDAO.Get(id);

            if (student == null)
                return ReturnResponse(session, HttpStatusCode.NotFound);
            else
                return ReturnResponse(session, HttpStatusCode.OK, student.Balance);  
        }

        internal HttpResponseMessage ReturnResponse(ISession session, HttpStatusCode code, double balance=-1)
        {
            if (session != null)
                session.Close();

            if (balance >= 0)
                return Request.CreateResponse(code, balance);
            else
                return Request.CreateResponse(code);
        }
    }
}
