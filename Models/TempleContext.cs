using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class TempleContext : DbContext
    {
        public TempleContext()
        {
        }

        public TempleContext(DbContextOptions<TempleContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(

                new TimeSlot
                {
                    TimeSlotId = 1,
                    Date = "3/23",
                    Time = "8:00 AM",
                    Reserved = false
                },
                new TimeSlot
                {
                    TimeSlotId = 2,
                    Date = "3/23",
                    Time = "9:00 AM",
                    Reserved = false
                }

            );
        }
    }
}
