using PaymentProcessor.Entities;
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
        public HttpResponseMessage Post(Sale sale)
        {
            CarrinhoDAO carrinhoDAO = new CarrinhoDAO();

            try
            {
                Carrinho carrinho = carrinhoDAO.Busca(id);
                return Request.CreateResponse(HttpStatusCode.OK, carrinho);
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
