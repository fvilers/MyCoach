using System.Web.Mvc;

namespace MyCoach.Web.MainSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}