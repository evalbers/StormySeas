using System.Web.Mvc;

namespace Ev.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "play the rpg \"Ev\" (html5 ultima5-esque fantasy)";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "play the rpg \"Ev\" (html5 ultima5-esque fantasy)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "play the rpg \"Ev\" (html5 ultima5-esque fantasy)";

            return View();
        }
    }
}