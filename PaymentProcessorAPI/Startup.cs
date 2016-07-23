using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentProcessorAPI.Startup))]
namespace PaymentProcessorAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
