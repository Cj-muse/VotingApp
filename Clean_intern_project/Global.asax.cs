using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Clean_intern_project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Dictionary<Guid, string> sessionGuids = new Dictionary<Guid, string>();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Application.Add("sessionGuids", sessionGuids);
            HttpContext.Current.Application["fred"] = "barney";


        }
    }
}
