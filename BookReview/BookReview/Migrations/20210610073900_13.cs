using Microsoft.EntityFrameworkCore.Migrations;

namespace BookReview.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_bookId",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "bookId",
                table: "Review",
                newName: "BookID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_bookId",
                table: "Review",
                newName: "IX_Review_BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Book_BookID",
                table: "Review",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Book_BookID",
                table: "Review");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Review",
                newName: "bookId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_BookID",
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
    }
}
