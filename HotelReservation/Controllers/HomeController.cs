using System.Diagnostics;
using HotelReservation.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelReservation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
