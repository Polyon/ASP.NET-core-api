using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.RecieveMassage
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecieveMassages",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    SenderName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    SenderEmail = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    MassageBody = table.Column<string>(type: "varchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Reply = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecieveMassages", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecieveMassages");
        }
    }
}
