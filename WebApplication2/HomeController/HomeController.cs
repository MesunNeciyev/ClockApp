using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.HomeController
{
    public class HomeController: Controller
    {
        private readonly IClockRepisotry _clockRepisotry;

        public HomeController(IClockRepisotry clockRepository)
        {
            _clockRepisotry = clockRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            IEnumerable<Clock> clocks = _clockRepisotry.GetAllClocks();
            return View(clocks);
        }

        public IActionResult Buy(Clock amount)
        {
            return View(amount);
        }
    }
}
