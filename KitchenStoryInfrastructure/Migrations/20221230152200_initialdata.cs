using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KitchenStoryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initialdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Productcategory",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productcategory", x => x.ProductCategoryId);
                });

            migrationBuilder.InsertData(
                table: "Productcategory",
                columns: new[] { "ProductCategoryId", "Description", "Name", "tags" },
                values: new object[,]
                {
                    { 1, "Shoes for all needs", "Shoes", "shoes" },
                    { 2, "Shoes for all needs", "Sandals", "shoes" },
                    { 3, "Shoes for all needs", "slip ons", "shoes" },
                    { 4, "Shoes for all needs", "Test Prod Cat1", "shoes" },
                    { 5, "Shoes for all needs", "Test Prod Cat2", "shoes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productcategory");
        }
    }
}
