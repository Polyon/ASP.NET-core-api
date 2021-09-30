using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.PersonalData
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalData",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    imagePath = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    MyName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MyAddress = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    PIN = table.Column<long>(type: "bigint", nullable: false),
                    MyEmail = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    ContectNo = table.Column<long>(type: "bigint", nullable: false),
                    AuthId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalData", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalData");
        }
    }
}
