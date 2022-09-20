using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberAPI.Migrations
{
    public partial class initBarberAPIDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
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
                    Number = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    MainStreet = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    lon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barbers",
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
                    BarberName = table.Column<string>(nullable: false),
                    BarberEmail = table.Column<string>(nullable: false),
                    AddressGuid = table.Column<string>(nullable: true),
                    AverageRating = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
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
                    UserName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: false),
                    CustomerEmail = table.Column<string>(nullable: false),
                    CustomerAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
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
                    BarberGuid = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    Percentage = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogVisits",
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
                    table.PrimaryKey("PK_LogVisits", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Barbers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "LogVisits");
        }
    }
}
