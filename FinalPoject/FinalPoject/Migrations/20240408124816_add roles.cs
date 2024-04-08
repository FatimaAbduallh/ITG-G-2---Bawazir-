using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZon.Migrations
{
    public partial class addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9adf4698-f040-4b4e-b43a-4fd5839902fe", "277eb254-346d-482d-a226-50c47409b879", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c523edcc-7e13-4ff3-8133-b7283a0b8f4d", "fc588312-55b1-4c47-998e-2f2f21a6a483", "Admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9adf4698-f040-4b4e-b43a-4fd5839902fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c523edcc-7e13-4ff3-8133-b7283a0b8f4d");
        }
    }
}
