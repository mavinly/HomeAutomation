using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeAutomation.Web.Startup))]
namespace HomeAutomation.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
