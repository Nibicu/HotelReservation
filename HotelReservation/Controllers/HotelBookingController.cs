using HotelReservation.Models.Hotel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace HotelReservation.Controllers
{
    public class HotelBookingController : Controller
    {
        public IActionResult CreateOrderHotelBooking()
        {
            var viewModels = new List<hotelViewModel>
            {
                new hotelViewModel{
                    Name = "Long Beach",
                    Src = "https://resize.onlinetours.ru/Z3up_vDf_o_ITTQipKPb8T7N1X42dQI2cLgNJbsxca8/rs:fit:8192:800:0:0/g:ce/aHR0cHM6Ly9zdGF0/aWM1Lm9sdC5zdS9z/eXN0ZW0vdXBsb2Fk/cy9ob3RlbF9waG90/by9pbWFnZS8xNS81/NC8zNy80My8xMDAz/NDEzMjEuanBnP3Rp/bWVzdGFtcD0xNjYy/NDY4NTM2.jpg"
                },
                new hotelViewModel{
                    Name = "D Eco Wellness Center Pattaya",
                    Src = "https://static.tourvisor.ru/hotel_pics/verybig/2/d-eco-wellness-center-pattaya-54000.jpg"
                },
                new hotelViewModel{
                    Name = "Tuana The Phulin Resort",
                    Src = "https://static.tourvisor.ru/hotel_pics/verybig/2/eastern-grand-palace-1511001.jpg"
                },
            };
            return View(viewModels);
        }

    }
}
