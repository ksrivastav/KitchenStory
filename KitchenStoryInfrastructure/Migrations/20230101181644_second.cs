using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderAddressess_orders_OrderId",
                table: "orderAddressess");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Productcategory_ProductCategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "orderDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "products",
                newName: "ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_ProductCategoryId",
                table: "products",
                newName: "IX_products_ProductSubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_ProductId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orderDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailId");

            migrationBuilder.CreateTable(
                name: "productSubCategories",
                columns: table => new
                {
                    ProductSubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSubCategories", x => x.ProductSubCategoryId);
                    table.ForeignKey(
                        name: "FK_productSubCategories_Productcategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "Productcategory",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_productSubCategories_ProductCategoryId",
                table: "productSubCategories",
                column: "ProductCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderAddressess_Orders_OrderId",
                table: "orderAddressess",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_productSubCategories_ProductSubCategoryId",
                table: "products",
                column: "ProductSubCategoryId",
                principalTable: "productSubCategories",
                principalColumn: "ProductSubCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderAddressess_Orders_OrderId",
                table: "orderAddressess");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_products_productSubCategories_ProductSubCategoryId",
                table: "products");

            migrationBuilder.DropTable(
                name: "productSubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "orderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductSubCategoryId",
                table: "products",
                newName: "ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_products_ProductSubCategoryId",
                table: "products",
                newName: "IX_products_ProductCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ProductId",
                table: "orderDetails",
                newName: "IX_orderDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "orderDetails",
                newName: "IX_orderDetails_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderDetails",
                table: "orderDetails",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderAddressess_orders_OrderId",
                table: "orderAddressess",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_orders_OrderId",
                table: "orderDetails",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderDetails_products_ProductId",
                table: "orderDetails",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Productcategory_ProductCategoryId",
                table: "products",
                column: "ProductCategoryId",
                principalTable: "Productcategory",
                principalColumn: "ProductCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
