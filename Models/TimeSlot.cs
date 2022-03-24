using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public partial class TimeSlot
    {
        [Key]
        [Required]
        public int TimeSlotId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public bool Reserved { get; set; }
    }
}
