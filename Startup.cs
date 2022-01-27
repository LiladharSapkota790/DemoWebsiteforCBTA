using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoWebsiteforCBTA.Startup))]
namespace DemoWebsiteforCBTA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
