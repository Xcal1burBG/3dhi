using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3dhi.Migrations
{
    public partial class AddingCountPeopleInListing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MainPhoto",
                table: "Listings",
                newName: "MainPhotoPath");

            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "PhotoPaths",
                type: "nvarchar(200)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "placesAdults",
                table: "Listings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "placesChildren",
                table: "Listings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "PhotoPaths");

            migrationBuilder.DropColumn(
                name: "placesAdults",
                table: "Listings");

            migrationBuilder.DropColumn(
                name: "placesChildren",
                table: "Listings");

            migrationBuilder.RenameColumn(
                name: "MainPhotoPath",
                table: "Listings",
                newName: "MainPhoto");
        }
    }
}
