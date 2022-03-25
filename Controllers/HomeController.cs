using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
                .Where(t => t.Reserved == false)
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
        public IActionResult Edit(int reservationid, long timeslotid)
        {
            var x = new AppointmentViewModel
            {
                Reservation = _templeContext.Reservations.Single(x => x.ReservationId == reservationid),
                TimeSlot = _templeContext.TimeSlots.Single(x => x.TimeSlotId == timeslotid)
            };
        
            return View("Edit", x);
        }

        [HttpPost]
        public IActionResult Edit(AppointmentViewModel r, int reservationid)
        {
            r.Reservation.TimeSlotId = r.TimeSlot.TimeSlotId;
            if (ModelState.IsValid)
            {
                Reservation oldappointment = _templeContext.Reservations.Single(x => x.ReservationId == reservationid);
                _templeContext.Update(r.Reservation);
                _templeContext.Remove(oldappointment);
                _templeContext.SaveChanges();
          


                return RedirectToAction("ViewAppointments");

            }


            else
            {
                return View();
            }


        }

        [HttpGet]
        public IActionResult Delete(int reservationid)
        {
             Reservation reservation = _templeContext.Reservations.Single(x => x.ReservationId == reservationid);
            _templeContext.Reservations.Remove(reservation);
            _templeContext.TimeSlots.Single(x => x.TimeSlotId == reservation.TimeSlotId).Reserved = false;
            _templeContext.SaveChanges();
            return RedirectToAction("ViewAppointments");
        }
        //[HttpPost]
        //public IActionResult Delete(Reservation r, int reservationid )
        //{
        //    Reservation appointmenttodelete = _templeContext.Reservations.Single(x => x.ReservationId == reservationid);

        //    _templeContext.Reservations.Remove(r);
        //    _templeContext.SaveChanges();

        //    return RedirectToAction("ViewAppointments");


        //}

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
                _templeContext.TimeSlots.Single(x => x.TimeSlotId == r.Reservation.TimeSlotId).Reserved = true;
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


