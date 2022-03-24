using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Controllers
{
    public class HomeController : Controller
    {
        private TempleContext _templeContext { get; set; }

        public HomeController(TempleContext someName)
        {
            _templeContext = someName;
        }
        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TimeSlots()
        {
            var times = _templeContext.TimeSlots
                .ToList();
            
            return View(times);
        }
        public IActionResult ViewAppointments()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult SignUp(Reservation r)
        {
            if (ModelState.IsValid)
            {
                TempleContext.Add(r);
                TempleContext.SaveChanges();

                return RedirectToAction("Home");
            }

            else
            {
                return View();
            }
            
        }

    }

}


