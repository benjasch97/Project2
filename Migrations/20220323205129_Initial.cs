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
                values: new object[] { 1L, "3/23", false, "8:00 AM" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotId", "Date", "Reserved", "Time" },
                values: new object[] { 2L, "3/23", false, "9:00 AM" });

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
