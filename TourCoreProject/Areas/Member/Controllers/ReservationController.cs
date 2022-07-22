using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TourCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        [HttpGet]
        public IActionResult MyCurrentReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MyOldReservation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }
    }
}
