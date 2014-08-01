using Microsoft.Owin;
using MyCoach.Web.MainSite;
using Owin;

[assembly: OwinStartup(typeof(Startup))]
namespace MyCoach.Web.MainSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}