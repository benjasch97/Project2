using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public Reservation Reservation { get; set; }
        public TimeSlot TimeSlot { get; set; }
    }
}
