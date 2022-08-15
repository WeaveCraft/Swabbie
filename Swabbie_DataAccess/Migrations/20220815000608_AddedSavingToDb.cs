using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swabbie_DataAccess.Migrations
{
    public partial class AddedSavingToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Savings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Savings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
