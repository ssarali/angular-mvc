using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class AngularDataController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your angular page.";
            return View();
        }
    }
}