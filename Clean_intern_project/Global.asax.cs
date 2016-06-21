using Clean_intern_project.Models;
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
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Dictionary<string, VotingSessionObject> votingSessionDictionary =
                new Dictionary<string, VotingSessionObject>();
            Application.Add("votingSessions", votingSessionDictionary);
            //HttpContext.Current.Application["votingSessions"] = votingSessionDictionary;

        }
    }
}
