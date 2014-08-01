using System;
using System.Web;
using System.Web.Routing;

namespace MyCoach.Web.MainSite
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}