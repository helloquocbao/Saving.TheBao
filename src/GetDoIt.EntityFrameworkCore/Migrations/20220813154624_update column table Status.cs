using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetDoIt.Migrations
{
    public partial class updatecolumntableStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Status",
                newName: "ColorCode");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Status",
                newName: "CODE");

            migrationBuilder.AddColumn<string>(
                name: "BorderColorCode",
                table: "Status",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Status",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "CreatorUserId",
                table: "Status",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Status",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorderColorCode",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "CreatorUserId",
                table: "Status");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Status");

            migrationBuilder.RenameColumn(
                name: "ColorCode",
                table: "Status",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CODE",
                table: "Status",
                newName: "Description");
        }
    }
}
