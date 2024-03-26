using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameZon.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameDevices",
                table: "GameDevices");

            migrationBuilder.DropColumn(
                name: "IdDevice",
                table: "GameDevices");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameDevices",
                table: "GameDevices",
                columns: new[] { "IdGame", "DeviceId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GameDevices",
                table: "GameDevices");

            migrationBuilder.AddColumn<int>(
                name: "IdDevice",
                table: "GameDevices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameDevices",
                table: "GameDevices",
                columns: new[] { "IdGame", "IdDevice" });
        }
    }
}
