using Microsoft.AspNetCore.Mvc;
using Project2.Models;
using Project2.Models.ViewModels;
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
            var appointments = _templeContext.Reservations
                .ToList();
            return View(appointments);
        }


        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp(long timeSlotId)
        {
            var x = new AppointmentViewModel
            {
                Reservation = new Reservation(),
                
                TimeSlot = _templeContext.TimeSlots.Single(x => x.TimeSlotId == timeSlotId)

            };
            
            
            return View("SignUp", x);
        }
        
        [HttpPost]
        public IActionResult SignUp(AppointmentViewModel r)
        {
            r.Reservation.TimeSlotId = r.TimeSlot.TimeSlotId;
            if (ModelState.IsValid)
            {
                _templeContext.Add(r.Reservation);
                _templeContext.SaveChanges();

                return RedirectToAction("Index");
            }

            else
            {
                return View();
            }



        }


    }

}


