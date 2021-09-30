using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.AcademicRecord
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Academics",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    QualificationLevel = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Organisation = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    CenterBoard = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Marks = table.Column<double>(type: "float", nullable: false),
                    PassingYear = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academics", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Academics");
        }
    }
}
