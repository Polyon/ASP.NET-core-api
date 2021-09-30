using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.WorkExp
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exprience",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    JobTimeline = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exprience", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exprience");
        }
    }
}
