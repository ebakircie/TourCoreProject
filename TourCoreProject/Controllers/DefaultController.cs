using Microsoft.AspNetCore.Mvc;

namespace TourCoreProject.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
