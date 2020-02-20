using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyReview.Migrations
{
    public partial class AddedReviewSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "Date", "ProductId", "Rating", "Reviewer" },
                values: new object[,]
                {
                    { 1, "Review", "july 32nd, 2020", 1, 3, "Corleeone" },
                    { 2, "Review", "January 1st, 1893", 1, 2, "Jake" },
                    { 3, "Review", "THE END TIMES", 2, 1, "Jackie Fredrickson" },
                    { 4, "Review", "33 BC", 2, 47, "Becky with the good hair" },
                    { 5, "Review", "Day 1", 3, 0, "Johnny Pearseed" },
                    { 6, "Review", "Decemberuary 4th, 3112", 3, 5, "Harriet Tubman" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
