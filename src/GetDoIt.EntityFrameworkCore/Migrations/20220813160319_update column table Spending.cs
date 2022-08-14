using Microsoft.EntityFrameworkCore.Migrations;

namespace GetDoIt.Migrations
{
    public partial class updatecolumntableSpending : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdWarning",
                table: "Spending");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdWarning",
                table: "Spending",
                type: "int",
                nullable: true);
        }
    }
}
