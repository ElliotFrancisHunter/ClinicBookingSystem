using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClinicBookingSystemFrontEnd.Startup))]
namespace ClinicBookingSystemFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
