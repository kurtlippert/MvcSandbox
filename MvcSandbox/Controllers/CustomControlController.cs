using System.Web.Mvc;

namespace MvcSandbox.Controllers
{
    public class CustomControlController : Controller
    {
        // GET: CustomControl
        public ActionResult Index()
        {
            return View();
        }
    }
}