using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _3dhi.Migrations
{
    public partial class ListingEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Users_FK_Listing_UserId",
                table: "Listings");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Listings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FK_Listing_UserId",
                table: "Listings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Users_FK_Listing_UserId",
                table: "Listings",
                column: "FK_Listing_UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listings_Users_FK_Listing_UserId",
                table: "Listings");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Listings",
                type: "nvarchar(200)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FK_Listing_UserId",
                table: "Listings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Listings_Users_FK_Listing_UserId",
                table: "Listings",
                column: "FK_Listing_UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
