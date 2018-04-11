using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(sendrequesttestService.Startup))]

namespace sendrequesttestService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}