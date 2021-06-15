using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReview.Migrations
{
    public partial class unique_ISBN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Book",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ISBN",
                table: "Book",
                column: "ISBN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Book_ISBN",
                table: "Book");

            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
