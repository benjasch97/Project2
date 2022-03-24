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

    






        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TimeSlots()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

    }

}


