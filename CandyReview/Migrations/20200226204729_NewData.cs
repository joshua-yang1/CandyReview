using Microsoft.EntityFrameworkCore.Migrations;

namespace CandyReview.Migrations
{
    public partial class NewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Marshmallow", "Peeps" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Sour", "Sour Patch Kids" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Hershey's Kisses");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Why wouldn't you just eat a marshmallow..? Peeps make for a very fun s'more though.", "2/26/20", 5, "Josh" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "God awful. Please do not spend money on these.", "2/26/20", 1, "Rhianna" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "They are the perfect combination of chewy and sour", "2/26/20", 4, "Tatyana" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "First, they're sour. Then, they're sweet.", "2/26/20", 5, "Rob" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "I mean, it's chocolate. You can't really go wrong here.", "2/26/20", 4, "Josh" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Date", "Reviewer" },
                values: new object[] { "I find myself accidentally eating the entire bag. Chocolate is always A+", "2/26/20", "Rhianna" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Chewy", "Swedish Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Name" },
                values: new object[] { "Chewy", "Starburst" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Heath Bar");

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Review", "july 32nd, 2020", 3, "Corleeone" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Review", "January 1st, 1893", 2, "Jake" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Review", "THE END TIMES", 1, "Jackie Fredrickson" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Review", "33 BC", 47, "Becky with the good hair" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Date", "Rating", "Reviewer" },
                values: new object[] { "Review", "Day 1", 0, "Johnny Pearseed" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Date", "Reviewer" },
                values: new object[] { "Review", "Decemberuary 4th, 3112", "Harriet Tubman" });
        }
    }
}
