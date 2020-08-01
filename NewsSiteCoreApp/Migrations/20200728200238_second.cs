using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsSiteCoreApp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                table: "News",
                type: "nvarchar(100)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
