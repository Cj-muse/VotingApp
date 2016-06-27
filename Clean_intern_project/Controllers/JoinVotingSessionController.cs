using Clean_intern_project.Models;
using Clean_intern_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clean_intern_project.Controllers
{
    public class JoinVotingSessionController : Controller
    {
        // GET: JoinVotingSession
        public ActionResult Index(string guid)
        {
            Dictionary<string, VotingSessionObject> dictionary = (Dictionary<string, VotingSessionObject>)HttpContext.Application.Get("votingSessions");
            VotingSessionObject votingSession = dictionary[guid];

            if (dictionary[guid] != null)
            {
                // adding a voting session object to the viewbag
                ViewBag.votingSessionData = votingSession;

                // Update session data 


                // Return updated dictionary to application scope object
                HttpContext.Application["votingSessions"] = dictionary;
            }
            else
            {
                throw new Exception("Failed to join voting session: invalid guid");
            }
                
            return View("JoinVotingSession");
        }
    }
}