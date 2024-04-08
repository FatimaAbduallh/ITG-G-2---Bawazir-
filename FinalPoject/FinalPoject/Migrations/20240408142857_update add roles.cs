using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZon.Migrations
{
    public partial class updateaddroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9adf4698-f040-4b4e-b43a-4fd5839902fe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c523edcc-7e13-4ff3-8133-b7283a0b8f4d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "70d2cba4-b509-49a6-8c34-e1f0df2b96ae", "53c9f198-f59f-4bbc-9826-ff7ca12702a2", "Admin", "admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "adafa587-0720-4f45-9e3a-b46bc6c204ca", "f56d9fcc-0ec0-43dc-bd90-0ada994c2192", "User", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70d2cba4-b509-49a6-8c34-e1f0df2b96ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adafa587-0720-4f45-9e3a-b46bc6c204ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9adf4698-f040-4b4e-b43a-4fd5839902fe", "277eb254-346d-482d-a226-50c47409b879", "User", "user" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c523edcc-7e13-4ff3-8133-b7283a0b8f4d", "fc588312-55b1-4c47-998e-2f2f21a6a483", "Admin", "admin" });
        }
    }
}
