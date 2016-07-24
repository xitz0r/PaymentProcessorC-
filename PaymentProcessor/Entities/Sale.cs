using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Sale
    {
        [JsonProperty]
        public virtual Card Card { get; set; }
        [JsonProperty]
        public virtual string Password { get; set; }

        public virtual int Id { get; set; }
        [JsonProperty]
        public virtual double Value { get; set; }
        [JsonProperty]
        public virtual DateTime DateTimeSale { get; set; }
        [JsonProperty]
        public virtual bool WasRefunded { get; set; }
        [JsonProperty]
        public virtual bool IsReload { get; set; }
        public virtual Student Student { get; set; }
        [JsonProperty]
        public virtual Terminal Terminal { get; set; }

        public Sale()
        {
            this.DateTimeSale = DateTime.Now;
        }

        public Sale(double txValue, Card card, string password)
        {
            this.Value = txValue;
            this.Card = card;
            this.Password = password;
            this.DateTimeSale = DateTime.Now;
        }


        public virtual string send()
        {
            string incomingMsg;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://192.168.25.66:56556/api/sale/");
            //request.Method = "GET";
            request.Method = "POST";
            //request.Accept = "application/xml";
            request.ContentType = "application/json";

            byte[] jsonBytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(this, Formatting.Indented));
            request.GetRequestStream().Write(jsonBytes, 0, jsonBytes.Length);
            HttpWebResponse response;
            try
            {

                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStreamer = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStreamer, Encoding.UTF8);
                    incomingMsg = reader.ReadToEnd();
                }
                return "Aprovado";
            }
            catch (WebException e)
            {
                if(e.Status == WebExceptionStatus.ProtocolError && e.Response!= null)
                {
                    var resp = (HttpWebResponse)e.Response;
                    if (resp.StatusCode == HttpStatusCode.NotFound)
                        return "Cartão não encontrado.";
                    else if (resp.StatusCode == HttpStatusCode.NoContent)
                        return "Erro interno.";
                    else if (resp.StatusCode == HttpStatusCode.Unauthorized)
                        return "Saldo insuficiente.";
                    else if (resp.StatusCode == HttpStatusCode.Conflict)
                        return "Senha inválida.";
                    else if (resp.StatusCode == HttpStatusCode.UpgradeRequired)
                        return "Cartão bloqueado.";
                }
                return "Erro de comunicação";
            }         
        }
    }
}
