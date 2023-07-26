using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebStore.Data.Migrations
{
    public partial class AddedRelationBetweenUserAndProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationUserId",
                table: "IndividualProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualProducts_ApplicationUserId",
                table: "IndividualProducts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualProducts_AspNetUsers_ApplicationUserId",
                table: "IndividualProducts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualProducts_AspNetUsers_ApplicationUserId",
                table: "IndividualProducts");

            migrationBuilder.DropIndex(
                name: "IX_IndividualProducts_ApplicationUserId",
                table: "IndividualProducts");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "IndividualProducts");
        }
    }
}
