using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReview.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Review",
                newName: "bookId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_BookId",
                table: "Review",
                newName: "IX_Review_bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Book_bookId",
                table: "Review",
                column: "bookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_bookId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "bookId",
                table: "Review",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_bookId",
                table: "Review",
                newName: "IX_Review_BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Book_BookId",
                table: "Review",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
