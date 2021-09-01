using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeProject.DataAccess.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallet_AspNetUsers_AppUserId",
                table: "Wallet");

            migrationBuilder.DropIndex(
                name: "IX_Wallet_AppUserId",
                table: "Wallet");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Wallet");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Wallet_AspNetUsers_UserId",
                table: "Wallet",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wallet_AspNetUsers_UserId",
                table: "Wallet");

            migrationBuilder.DropIndex(
                name: "IX_Wallet_UserId",
                table: "Wallet");

            migrationBuilder.AddColumn<Guid>(
                name: "AppUserId",
                table: "Wallet",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_AppUserId",
                table: "Wallet",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wallet_AspNetUsers_AppUserId",
                table: "Wallet",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
