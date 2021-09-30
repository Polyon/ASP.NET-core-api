using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.ProjectData
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    ProjectTitle = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AboutProject = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    ProjectLink = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    AuthUser = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
