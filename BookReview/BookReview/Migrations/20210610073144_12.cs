using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReview.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewID",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReviewID",
                table: "Book",
                type: "int",
                nullable: true);
        }
    }
}
