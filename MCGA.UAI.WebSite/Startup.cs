using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCGA.UI.WebSite.Startup))]
namespace MCGA.UI.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
