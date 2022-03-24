using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    Reserved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotId);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<byte>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_TimeSlots_TimeSlotId",
                        column: x => x.TimeSlotId,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 1L, "3/24", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 66L, "3/29", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 65L, "3/28", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 64L, "3/28", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 63L, "3/28", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 62L, "3/28", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 61L, "3/28", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 60L, "3/28", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 59L, "3/28", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 58L, "3/28", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 57L, "3/28", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 56L, "3/28", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 55L, "3/28", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 54L, "3/28", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 53L, "3/28", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 52L, "3/27", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 51L, "3/27", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 50L, "3/27", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 49L, "3/27", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 48L, "3/27", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 67L, "3/29", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 47L, "3/27", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 68L, "3/29", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 70L, "3/29", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 89L, "3/30", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 88L, "3/30", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 87L, "3/30", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 86L, "3/30", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 85L, "3/30", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 84L, "3/30", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 83L, "3/30", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 82L, "3/30", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 81L, "3/30", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 80L, "3/30", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 79L, "3/30", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 78L, "3/29", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 77L, "3/29", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 76L, "3/29", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 75L, "3/29", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 74L, "3/29", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 73L, "3/29", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 72L, "3/29", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 71L, "3/29", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 69L, "3/29", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 90L, "3/30", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 46L, "3/27", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 44L, "3/27", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 20L, "3/25", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 19L, "3/25", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 18L, "3/25", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 17L, "3/25", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 16L, "3/25", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 15L, "3/25", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 14L, "3/25", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 13L, "3/24", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 12L, "3/24", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 11L, "3/24", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 10L, "3/24", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 9L, "3/24", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 8L, "3/24", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 7L, "3/24", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 6L, "3/24", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 5L, "3/24", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 4L, "3/24", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 3L, "3/24", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 2L, "3/24", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 21L, "3/25", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 45L, "3/27", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 22L, "3/25", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 24L, "3/25", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 43L, "3/27", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 42L, "3/27", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 41L, "3/27", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 40L, "3/27", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 39L, "3/26", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 38L, "3/26", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 37L, "3/26", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 36L, "3/26", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 35L, "3/26", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 34L, "3/26", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 33L, "3/26", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 32L, "3/26", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 31L, "3/26", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 30L, "3/26", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 29L, "3/26", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 28L, "3/26", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 27L, "3/26", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 26L, "3/25", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 25L, "3/25", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 23L, "3/25", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 91L, "3/30", false, "8:00 PM" });

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TimeSlotId",
                table: "Reservations",
                column: "TimeSlotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
