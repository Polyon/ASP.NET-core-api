using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.SkillData
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Technology = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SkillLevel = table.Column<int>(type: "int", nullable: false),
                    AboutSkill = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
