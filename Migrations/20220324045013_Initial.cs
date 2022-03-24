using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotId = table.Column<int>(nullable: false)
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
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotId = table.Column<int>(nullable: false)
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
                values: new object[] { 1, "3/24", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 66, "3/29", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 65, "3/28", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 64, "3/28", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 63, "3/28", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 62, "3/28", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 61, "3/28", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 60, "3/28", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 59, "3/28", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 58, "3/28", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 57, "3/28", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 56, "3/28", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 55, "3/28", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 54, "3/28", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 53, "3/28", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 52, "3/27", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 51, "3/27", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 50, "3/27", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 49, "3/27", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 48, "3/27", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 67, "3/29", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 47, "3/27", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 68, "3/29", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 70, "3/29", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 89, "3/30", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 88, "3/30", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 87, "3/30", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 86, "3/30", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 85, "3/30", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 84, "3/30", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 83, "3/30", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 82, "3/30", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 81, "3/30", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 80, "3/30", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 79, "3/30", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 78, "3/29", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 77, "3/29", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 76, "3/29", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 75, "3/29", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 74, "3/29", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 73, "3/29", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 72, "3/29", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 71, "3/29", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 69, "3/29", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 90, "3/30", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 46, "3/27", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 44, "3/27", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 20, "3/25", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 19, "3/25", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 18, "3/25", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 17, "3/25", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 16, "3/25", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 15, "3/25", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 14, "3/25", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 13, "3/24", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 12, "3/24", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 11, "3/24", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 10, "3/24", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 9, "3/24", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 8, "3/24", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 7, "3/24", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 6, "3/24", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 5, "3/24", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 4, "3/24", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 3, "3/24", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 2, "3/24", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 21, "3/25", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 45, "3/27", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 22, "3/25", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 24, "3/25", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 43, "3/27", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 42, "3/27", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 41, "3/27", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 40, "3/27", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 39, "3/26", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 38, "3/26", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 37, "3/26", false, "6:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 36, "3/26", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 35, "3/26", false, "4:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 34, "3/26", false, "3:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 33, "3/26", false, "2:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 32, "3/26", false, "1:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 31, "3/26", false, "12:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 30, "3/26", false, "11:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 29, "3/26", false, "10:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 28, "3/26", false, "9:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 27, "3/26", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 26, "3/25", false, "8:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 25, "3/25", false, "7:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 23, "3/25", false, "5:00 PM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 91, "3/30", false, "8:00 PM" });

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
