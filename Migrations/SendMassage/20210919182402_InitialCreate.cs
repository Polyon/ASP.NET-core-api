using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.SendMassage
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Send",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    RecipientName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RecipientEmail = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    MassageSubject = table.Column<string>(type: "varchar(max)", nullable: true),
                    MassageBody = table.Column<string>(type: "varchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Send", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Send");
        }
    }
}
