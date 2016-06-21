using Clean_intern_project.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Clean_intern_project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/CreateSession
        [HttpPost]
        public ActionResult CreateSession(string sessionTitle, string issues)
        {
            VotingSessionManager manager = new VotingSessionManager();
            VotingSessionObject votingSession = manager.CreateSession(sessionTitle, issues, (Dictionary<string, VotingSessionObject>)HttpContext.Application.Get("votingSessions"));

            ViewBag.VotingSession = votingSession;            

            return View();
        }
        
    }
}