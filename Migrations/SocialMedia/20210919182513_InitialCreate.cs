using Microsoft.EntityFrameworkCore.Migrations;

namespace MineApi.Migrations.SocialMedia
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "varchar(max)", nullable: true),
                    MediaTitle = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    MediaLink = table.Column<string>(type: "varchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
