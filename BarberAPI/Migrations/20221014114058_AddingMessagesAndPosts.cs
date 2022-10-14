using Microsoft.EntityFrameworkCore.Migrations;

namespace BarberAPI.Migrations
{
    public partial class AddingMessagesAndPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserGuid",
                table: "Addresses",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Messages",
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
                    SenderGuid = table.Column<string>(nullable: true),
                    RecieverGuid = table.Column<string>(nullable: true),
                    GroupGuid = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    AttatchmentString = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Read = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
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
                    SenderGuid = table.Column<string>(nullable: true),
                    RecieverGuid = table.Column<string>(nullable: true),
                    GroupGuid = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Caption",
                value: "Test01");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Caption",
                value: "Test03");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropColumn(
                name: "UserGuid",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Caption",
                value: null);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Caption",
                value: null);
        }
    }
}
