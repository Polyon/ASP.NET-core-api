using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.TrainingData
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    TrainingTitle = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    TrainingDuration = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    TrainingDetails = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
