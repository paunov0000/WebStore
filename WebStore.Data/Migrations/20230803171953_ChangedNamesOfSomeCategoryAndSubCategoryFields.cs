using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Data.Migrations
{
    public partial class ChangedNamesOfSomeCategoryAndSubCategoryFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubCategoryImageURL",
                table: "SubCategories",
                newName: "ImageURL");

            migrationBuilder.RenameColumn(
                name: "CategoryImageURL",
                table: "Categories",
                newName: "ImageURL");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "SubCategories",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "SubCategories");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "SubCategories",
                newName: "SubCategoryImageURL");

            migrationBuilder.RenameColumn(
                name: "ImageURL",
                table: "Categories",
                newName: "CategoryImageURL");
        }
    }
}
