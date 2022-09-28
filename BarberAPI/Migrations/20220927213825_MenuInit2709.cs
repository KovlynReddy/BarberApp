using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberAPI.Migrations
{
    public partial class MenuInit2709 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
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
                    ItemName = table.Column<string>(nullable: true),
                    MenuId = table.Column<string>(nullable: true),
                    SKUCode = table.Column<string>(nullable: true),
                    Caption = table.Column<string>(nullable: true),
                    Cost = table.Column<int>(nullable: false),
                    Currency = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
