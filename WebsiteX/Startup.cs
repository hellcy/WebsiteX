using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteX.Startup))]
namespace WebsiteX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
