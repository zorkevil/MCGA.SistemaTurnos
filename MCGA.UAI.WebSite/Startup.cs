using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCGA.UAI.WebSite.Startup))]
namespace MCGA.UAI.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
