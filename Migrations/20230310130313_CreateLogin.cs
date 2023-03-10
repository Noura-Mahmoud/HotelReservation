using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Start.Migrations
{
    /// <inheritdoc />
    public partial class CreateLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitchens",
                columns: table => new
                {
                    User_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitchens", x => x.User_name);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    User_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Pass_word = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.User_name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitchens");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
