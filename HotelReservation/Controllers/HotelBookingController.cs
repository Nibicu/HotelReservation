using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    public class HotelBookingController : Controller
    {
        public IActionResult CreateOrderHotelBooking()
        {
            return View();
        }

    }
}
