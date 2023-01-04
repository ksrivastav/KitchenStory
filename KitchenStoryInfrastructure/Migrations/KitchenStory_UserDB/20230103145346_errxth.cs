using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KitchenStoryInfrastructure.Migrations.KitchenStoryUserDB
{
    /// <inheritdoc />
    public partial class errxth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7657a6d-8d42-491b-b463-874da1adbf92", "ed539942-dc8b-4722-a6f5-3e81ec91598c", "Customer", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dc7287a1-e6a7-4427-be85-48265cb75bc9", 0, "ioioio", null, "delhi", "3a6a55cd-290a-464c-9ece-b170d94f7845", "india", "kartikayaemail", false, false, null, null, null, "803bd65441cc811070ad7391f855454b4953cbbd5c15f4757658e32bb6377ce0", null, false, "296d9709-8290-4fe9-baae-b77970f56f88", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7657a6d-8d42-491b-b463-874da1adbf92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc7287a1-e6a7-4427-be85-48265cb75bc9");
        }
    }
}
