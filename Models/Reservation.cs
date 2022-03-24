using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class Reservation
    {
        [Key]
        [BindNever]
        public int ReservationId { get; set; }
        
        [Required(ErrorMessage = "Please enter a group name")]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "The maximum group size is 15.")]
        [Range(1, 15)]
        public int GroupSize { get; set; }
       
        [Required(ErrorMessage = "Please enter an email")]
        public string Email { get; set; }
        public string Phone { get; set; }

        [Required]
        public long TimeSlotId { get; set; }
    }
}
