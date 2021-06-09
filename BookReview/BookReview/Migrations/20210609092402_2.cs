using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReview.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Review_ReviewId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ReviewId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Review_BookId",
                table: "Review",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_BookId",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Review");

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_ReviewId",
                table: "Book",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Review_ReviewId",
                table: "Book",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
