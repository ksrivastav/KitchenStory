using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orderAddressess_Orders_OrderId",
                table: "orderAddressess");

            migrationBuilder.DropForeignKey(
                name: "FK_orderAddressess_cities_CityId",
                table: "orderAddressess");

            migrationBuilder.DropForeignKey(
                name: "FK_orderContactDetails_orderAddressess_DeliveryAddressOrderAddressId",
                table: "orderContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_products_brands_BrandId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderContactDetails",
                table: "orderContactDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_brands",
                table: "brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orderAddressess",
                table: "orderAddressess");

            migrationBuilder.DropIndex(
                name: "IX_orderAddressess_CityId",
                table: "orderAddressess");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "orderAddressess");

            migrationBuilder.RenameTable(
                name: "orderContactDetails",
                newName: "OrderContactDetails");

            migrationBuilder.RenameTable(
                name: "brands",
                newName: "Brands");

            migrationBuilder.RenameTable(
                name: "orderAddressess",
                newName: "OrderAddresss");

            migrationBuilder.RenameColumn(
                name: "DeliveryAddressOrderAddressId",
                table: "OrderContactDetails",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderContactDetailsId",
                table: "OrderContactDetails",
                newName: "OrderContactDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_orderContactDetails_DeliveryAddressOrderAddressId",
                table: "OrderContactDetails",
                newName: "IX_OrderContactDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_orderAddressess_OrderId",
                table: "OrderAddresss",
                newName: "IX_OrderAddresss_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine1",
                table: "OrderAddresss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AddressLine2",
                table: "OrderAddresss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "OrderAddresss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "OrderAddresss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PinCode",
                table: "OrderAddresss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderContactDetails",
                table: "OrderContactDetails",
                column: "OrderContactDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brands",
                table: "Brands",
                column: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderAddresss",
                table: "OrderAddresss",
                column: "OrderAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderAddresss_Orders_OrderId",
                table: "OrderAddresss",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderContactDetails_Orders_OrderId",
                table: "OrderContactDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Brands_BrandId",
                table: "products",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderAddresss_Orders_OrderId",
                table: "OrderAddresss");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderContactDetails_Orders_OrderId",
                table: "OrderContactDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Brands_BrandId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderContactDetails",
                table: "OrderContactDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Brands",
                table: "Brands");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderAddresss",
                table: "OrderAddresss");

            migrationBuilder.DropColumn(
                name: "AddressLine1",
                table: "OrderAddresss");

            migrationBuilder.DropColumn(
                name: "AddressLine2",
                table: "OrderAddresss");

            migrationBuilder.DropColumn(
                name: "City",
                table: "OrderAddresss");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "OrderAddresss");

            migrationBuilder.DropColumn(
                name: "PinCode",
                table: "OrderAddresss");

            migrationBuilder.RenameTable(
                name: "OrderContactDetails",
                newName: "orderContactDetails");

            migrationBuilder.RenameTable(
                name: "Brands",
                newName: "brands");

            migrationBuilder.RenameTable(
                name: "OrderAddresss",
                newName: "orderAddressess");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "orderContactDetails",
                newName: "DeliveryAddressOrderAddressId");

            migrationBuilder.RenameColumn(
                name: "OrderContactDetailId",
                table: "orderContactDetails",
                newName: "OrderContactDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderContactDetails_OrderId",
                table: "orderContactDetails",
                newName: "IX_orderContactDetails_DeliveryAddressOrderAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderAddresss_OrderId",
                table: "orderAddressess",
                newName: "IX_orderAddressess_OrderId");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "orderAddressess",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderContactDetails",
                table: "orderContactDetails",
                column: "OrderContactDetailsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_brands",
                table: "brands",
                column: "BrandId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orderAddressess",
                table: "orderAddressess",
                column: "OrderAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_orderAddressess_CityId",
                table: "orderAddressess",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_orderAddressess_Orders_OrderId",
                table: "orderAddressess",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderAddressess_cities_CityId",
                table: "orderAddressess",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orderContactDetails_orderAddressess_DeliveryAddressOrderAddressId",
                table: "orderContactDetails",
                column: "DeliveryAddressOrderAddressId",
                principalTable: "orderAddressess",
                principalColumn: "OrderAddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_brands_BrandId",
                table: "products",
                column: "BrandId",
                principalTable: "brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
