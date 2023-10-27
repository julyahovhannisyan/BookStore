using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Database.Connection.Migrations
{
    public partial class changeLangTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Flag",
                table: "GlobalLanguages",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Flag",
                table: "GlobalLanguages");
        }
    }
}
