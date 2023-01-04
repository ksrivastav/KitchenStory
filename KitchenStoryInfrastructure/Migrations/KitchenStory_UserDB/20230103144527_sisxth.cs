using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations.KitchenStoryUserDB
{
    /// <inheritdoc />
    public partial class sisxth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d052e4c3-b7f7-4626-96f2-b70e69128208", "da3f7c4a-f6cd-4e2e-9ce8-d21595a3226a", "Customer", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "79669e7b-8c4f-477a-b59e-2e78c75bb0a6", 0, "ioioio", null, "delhi", "fdb0e586-c08e-480e-bbb6-00fe9dbf7fe3", "india", "kartikayaemail", false, false, null, null, null, "803bd65441cc811070ad7391f855454b4953cbbd5c15f4757658e32bb6377ce0", null, false, "d3406c40-b99a-409a-a47b-b305f820933f", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d052e4c3-b7f7-4626-96f2-b70e69128208");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79669e7b-8c4f-477a-b59e-2e78c75bb0a6");
        }
    }
}
