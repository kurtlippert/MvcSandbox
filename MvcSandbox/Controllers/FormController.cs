using System.Web.Mvc;
using MvcSandbox.Models;

namespace MvcSandbox.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormIndexViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Oops");

                if (viewModel.Name == "abc")
                {
                    ModelState.AddModelError("Name", "I don't like abc");
                }
            }

            return View(viewModel);
        }
    }
}