using System;
using System.Web;
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
            int i = 0;
            string[] parsedIssues = issues.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            IHtmlString[] htmlIssues = new HtmlString[10];
            ViewBag.sessionTitle = sessionTitle;
                                   
            // Add issues as html table row elements for ease of use in the view
            for (i = 0; i < parsedIssues.Length; i++)
            {
                if (string.Empty == parsedIssues[i])
                { continue; }
                IHtmlString str = new HtmlString(parsedIssues[i]);
                htmlIssues[i] = str;
            }

            ViewBag.numberOfIssues = i;
            ViewBag.htmlIssues = htmlIssues;

            // generate Guid for this session and 
            // add it to collection at application scope
            Guid guid = new Guid();
            ViewBag.guid = guid;
            //System.Web.HttpContext.Current.Session["MyIssuesAtSessionScope"] = issues; 

            return View();
        }

        public string WelcomeMessage()
        {
            Guid myguid = Guid.NewGuid();
            return "Welcome to Conner's App!";
        }
    }
}