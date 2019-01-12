using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MyParshadServiceService.Startup))]

namespace MyParshadServiceService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}