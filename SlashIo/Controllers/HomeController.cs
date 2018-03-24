using System.Web.Mvc;

namespace SlashIo.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            return View();
        }

            
    }
}