using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessor.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Sale
    {
        [JsonProperty]
        protected Card card;
        [JsonProperty]
        protected string password;

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

        public Sale() { }

        public Sale(double txValue, Card card, string password)
        {
            this.Value = txValue;
            this.card = card;
            this.password = password;
            this.DateTimeSale = DateTime.Now;
        }

        public virtual void send()
        {
            string output = JsonConvert.SerializeObject(this, Formatting.Indented);

            Console.Write(output);
        }
    }
}
