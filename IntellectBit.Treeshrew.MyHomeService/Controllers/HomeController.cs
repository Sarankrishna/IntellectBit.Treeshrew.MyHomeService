using System.Web.Mvc;

namespace IntellectBit.Treeshrew.MyHomeService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
