using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Clean_intern_project.Models;


namespace Clean_intern_project.Controllers
{
    public class VotingSessionController : Controller
    {
        // GET: VotingSession
        public ActionResult Index(string guid)
        {
            Dictionary<string, VotingSessionObject> dictionary =
                 (Dictionary<string, VotingSessionObject>)HttpContext.Application.Get("votingSessions");

            if (dictionary[guid] != null)
            {
                ViewBag.VotingSession = dictionary[guid];
            }
            else
            {
                throw new ArgumentNullException("VotingSessionController/Index: dictionary lookup returned null");
            }
            return View("../../Views/Home/CreateSession");
        }

        // Get: Vote
        [HttpGet]
        public void Vote(string voteValue, string guid)
        {
            // get the VotingSessionObject for this voting session
            Dictionary<string, VotingSessionObject> dictionary =
                (Dictionary<string, VotingSessionObject>)HttpContext.Application.Get("votingSessions");

            VotingSessionObject votingSession = dictionary[guid];

            if (votingSession == null)
            {
                throw new NullReferenceException("VotingSessionController: Vote action method dictionary lookup faild, returned null");
                return;
            }

            // increment current issue's vote count 
            if ("Yes" == voteValue)
            {
                votingSession.getActiveVotingObject().YesVotes++;
            }
            else
            {
                votingSession.getActiveVotingObject().NoVotes++;
            }

            
        }
    }
}