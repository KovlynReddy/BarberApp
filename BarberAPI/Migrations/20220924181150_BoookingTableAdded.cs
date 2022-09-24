using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberAPI.Migrations
{
    public partial class BoookingTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelGUID = table.Column<string>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    CreatedDateTime = table.Column<string>(nullable: false),
                    DeletedDateTime = table.Column<string>(nullable: true),
                    CompletedDateTime = table.Column<string>(nullable: true),
                    CreatorId = table.Column<string>(nullable: true),
                    BarberGuid = table.Column<string>(nullable: true),
                    UserGuid = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BookingTime = table.Column<string>(nullable: true),
                    ArriveTime = table.Column<string>(nullable: true),
                    CompletionTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CompletedDateTime", "Country", "CreatedDateTime", "CreatorId", "DeletedDateTime", "IsDeleted", "Lat", "MainStreet", "ModelGUID", "Number", "PostCode", "Street", "Suburb", "lon" },
                values: new object[,]
                {
                    { 1, null, "USA", "0001/01/01 00:00:00", "C1111", null, 0, "1000", "Street10", "A1111", "3", "1111", "Street1", "Sub1", "1111" },
                    { 2, null, "USB", "0001/01/01 00:00:00", "C2222", null, 0, "2000", "Street20", "A2222", "6", "2222", "Sreet2", "Sub2", "2222" }
                });

            migrationBuilder.InsertData(
                table: "Barbers",
                columns: new[] { "Id", "AddressGuid", "AverageRating", "BarberEmail", "BarberName", "CompletedDateTime", "CreatedDateTime", "CreatorId", "DeletedDateTime", "IsDeleted", "ModelGUID", "Status" },
                values: new object[,]
                {
                    { 1, "A1111", "10", "barber1@gmail.com", "Barber1", null, "0001/01/01 00:00:00", "C1111", null, 0, "B1111", 0 },
                    { 2, "A2222", "1", "barber2@gmail.com", "Barber2", null, "0001/01/01 00:00:00", "C2222", null, 0, "B2222", 0 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompletedDateTime", "CreatedDateTime", "CreatorId", "CustomerAddress", "CustomerEmail", "CustomerName", "DeletedDateTime", "Email", "IsDeleted", "ModelGUID", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, "0001/01/01 00:00:00", "0001/01/01 00:00:00", "C1111", "A1111", "Customer1@gmail.com", "Customer1", null, "Customer1@gmail.com", 0, "C1111", "1", "Customer1" },
                    { 2, "0001/01/01 00:00:00", "0001/01/01 00:00:00", "C2222", "A2222", "Customer2@gmail.com", "Customer2", null, "Customer2@gmail.com", 0, "C2222", "2", "Customer2" }
                });

            migrationBuilder.InsertData(
                table: "LogVisits",
                columns: new[] { "Id", "ArriveTime", "BarberGuid", "BookingTime", "CompletedDateTime", "CompletionTime", "CreatedDateTime", "CreatorId", "DeletedDateTime", "Description", "IsDeleted", "ModelGUID", "Rating", "Reason", "UserGuid" },
                values: new object[,]
                {
                    { 1, "0001/01/01 00:00:00", "B1111", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "C1111", null, "Booking", 0, "V1111", 2, "Hair Cut", "C1111" },
                    { 2, "0001/01/01 00:00:00", "B2222", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "0001/01/01 00:00:00", "C2222", null, "Walk In", 0, "V2222", 2, "Booking ", "C2222" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Barbers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LogVisits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LogVisits",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
