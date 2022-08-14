using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GetDoIt.Migrations
{
    public partial class updatecolumntableStatusStatusSpending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                table: "StatusSpending");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "StatusSpending");

            migrationBuilder.DropColumn(
                name: "IsActived",
                table: "StatusSpending");

            migrationBuilder.DropColumn(
                name: "LastModificationTime",
                table: "StatusSpending");

            migrationBuilder.DropColumn(
                name: "LastModifierUserId",
                table: "StatusSpending");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "StatusSpending",
                newName: "ColorCode");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "StatusSpending",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "StatusSpending",
                newName: "CODE");

            migrationBuilder.AddColumn<string>(
                name: "BorderColorCode",
                table: "StatusSpending",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorderColorCode",
                table: "StatusSpending");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "StatusSpending",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "ColorCode",
                table: "StatusSpending",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CODE",
                table: "StatusSpending",
                newName: "Description");

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                table: "StatusSpending",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "StatusSpending",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActived",
                table: "StatusSpending",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModificationTime",
                table: "StatusSpending",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "LastModifierUserId",
                table: "StatusSpending",
                type: "bigint",
                nullable: true);
        }
    }
}
