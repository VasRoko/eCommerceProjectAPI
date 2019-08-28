using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineStore.Persistance.Migrations
{
    public partial class ProductTableAmends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitsOnOrder",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "Tag",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Products");

            migrationBuilder.AddColumn<short>(
                name: "UnitsOnOrder",
                table: "Products",
                nullable: true);
        }
    }
}
