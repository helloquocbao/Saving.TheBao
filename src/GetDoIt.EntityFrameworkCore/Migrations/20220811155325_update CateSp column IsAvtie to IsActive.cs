using Microsoft.EntityFrameworkCore.Migrations;

namespace GetDoIt.Migrations
{
    public partial class updateCateSpcolumnIsAvtietoIsActive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActie",
                table: "CategorySpending",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "CategorySpending",
                newName: "IsActie");
        }
    }
}
