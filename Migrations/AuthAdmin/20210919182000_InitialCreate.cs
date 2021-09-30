using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.AuthAdmin
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    PassWord = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");
        }
    }
}
