using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketBooking.Startup))]
namespace TicketBooking
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
