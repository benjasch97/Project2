using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var appointment = _templeContext.Reservations
                .Include(x => x.TimeSlot)
                .ToList();
            return View(appointment);
        }


        [HttpGet]
        public IActionResult Edit(int reservationid)
        {
            ViewBag.Categories = _templeContext.Reservations.ToList();

            var reservation = _templeContext.Reservations.Single(x => x.ReservationId == reservationid);
            //connect id to bring the info back
            return View("SignUp", reservation);
        }

        [HttpPost]
        public IActionResult Edit(Reservation bob)
        {
            if (ModelState.IsValid)
            {
                _templeContext.Update(bob);
                _templeContext.SaveChanges();
                return RedirectToAction("ViewAppointments");
            }
            else
            {
                ViewBag.Categories = _templeContext.TimeSlots.ToList();
                return View("SignUp");
            }
        }

    
        [HttpGet]
        public IActionResult Delete(int reservationid)
        {
            var movies = _templeContext.Reservations.Single(x => x.ReservationId == reservationid);
            return View(movies);
        }
        [HttpPost]
        public IActionResult Delete(Reservation r)
        {
            _templeContext.Reservations.Remove(r);
            _templeContext.SaveChanges();

            return RedirectToAction("ViewAppointments");


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
                //TempleContext.Add(r);
               // TempleContext.SaveChanges();

                return RedirectToAction("Home");
            }

            else
            {
                return View();
            }
            
        }


    }

}


