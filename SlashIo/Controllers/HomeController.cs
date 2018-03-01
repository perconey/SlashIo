using System.Web.Mvc;

namespace SlashIo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return RouteData.ToString();
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}