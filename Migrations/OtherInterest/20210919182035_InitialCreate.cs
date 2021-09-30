using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.OtherInterest
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Others",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Others", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Others");
        }
    }
}
