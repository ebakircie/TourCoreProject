using Microsoft.AspNetCore.Mvc;

namespace TourCoreProject.ViewComponents.Default
{
    public class _Testimonial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
