using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_productSubCategories_ProductSubCategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_productSubCategories_Productcategory_ProductCategoryId",
                table: "productSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Productcategory",
                table: "Productcategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productSubCategories",
                table: "productSubCategories");

            migrationBuilder.RenameTable(
                name: "Productcategory",
                newName: "ProductCategory");

            migrationBuilder.RenameTable(
                name: "productSubCategories",
                newName: "ProductSubCategory");

            migrationBuilder.RenameIndex(
                name: "IX_productSubCategories_ProductCategoryId",
                table: "ProductSubCategory",
                newName: "IX_ProductSubCategory_ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory",
                column: "ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory",
                column: "ProductSubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_ProductSubCategory_ProductSubCategoryId",
                table: "products",
                column: "ProductSubCategoryId",
                principalTable: "ProductSubCategory",
                principalColumn: "ProductSubCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId",
                principalTable: "ProductCategory",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_ProductSubCategory_ProductSubCategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                table: "ProductSubCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductCategory",
                table: "ProductCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSubCategory",
                table: "ProductSubCategory");

            migrationBuilder.RenameTable(
                name: "ProductCategory",
                newName: "Productcategory");

            migrationBuilder.RenameTable(
                name: "ProductSubCategory",
                newName: "productSubCategories");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "productSubCategories",
                newName: "IX_productSubCategories_ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Productcategory",
                table: "Productcategory",
                column: "ProductCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_productSubCategories",
                table: "productSubCategories",
                column: "ProductSubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_productSubCategories_ProductSubCategoryId",
                table: "products",
                column: "ProductSubCategoryId",
                principalTable: "productSubCategories",
                principalColumn: "ProductSubCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productSubCategories_Productcategory_ProductCategoryId",
                table: "productSubCategories",
                column: "ProductCategoryId",
                principalTable: "Productcategory",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
