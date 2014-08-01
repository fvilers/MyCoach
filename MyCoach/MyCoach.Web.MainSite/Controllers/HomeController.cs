using System;
using System.Web.Mvc;

namespace MyCoach.Web.MainSite.Controllers
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("search")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(string[] keywords)
        {
            throw new NotImplementedException();
        }
    }
}