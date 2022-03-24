﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project2.Models;

namespace Project2.Migrations
{
    [DbContext(typeof(TempleContext))]
    partial class TempleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Project2.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<long>("TimeSlotId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReservationId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Project2.Models.TimeSlot", b =>
                {
                    b.Property<long>("TimeSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Reserved")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeSlotId");

                    b.ToTable("TimeSlots");

                    b.HasData(
                        new
                        {
                            TimeSlotId = 1L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 2L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 3L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 4L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 5L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 6L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 7L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 8L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 9L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 10L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 11L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 12L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 13L,
                            Date = "3/24",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 14L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 15L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 16L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 17L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 18L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 19L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 20L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 21L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 22L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 23L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 24L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 25L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 26L,
                            Date = "3/25",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 27L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 28L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 29L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 30L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 31L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 32L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 33L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 34L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 35L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 36L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 37L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 38L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 39L,
                            Date = "3/26",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 40L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 41L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 42L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 43L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 44L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 45L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 46L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 47L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 48L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 49L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 50L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 51L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 52L,
                            Date = "3/27",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 53L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 54L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 55L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 56L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 57L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 58L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 59L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 60L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 61L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 62L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 63L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 64L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 65L,
                            Date = "3/28",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 66L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 67L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 68L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 69L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 70L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 71L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 72L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 73L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 74L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 75L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 76L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 77L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 78L,
                            Date = "3/29",
                            Reserved = false,
                            Time = "8:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 79L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "8:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 80L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "9:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 81L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "10:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 82L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "11:00 AM"
                        },
                        new
                        {
                            TimeSlotId = 83L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "12:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 84L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "1:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 85L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "2:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 86L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "3:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 87L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "4:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 88L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "5:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 89L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "6:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 90L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "7:00 PM"
                        },
                        new
                        {
                            TimeSlotId = 91L,
                            Date = "3/30",
                            Reserved = false,
                            Time = "8:00 PM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
