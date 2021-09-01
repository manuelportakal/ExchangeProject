using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeProject.DataAccess.Migrations
{
    public partial class InitialCreate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCoin_Asset_AssetsId",
                table: "AssetCoin");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetCoin_Coins_CoinsId",
                table: "AssetCoin");

            migrationBuilder.DropForeignKey(
                name: "FK_CoinPair_Coins_CoinsId",
                table: "CoinPair");

            migrationBuilder.DropForeignKey(
                name: "FK_CoinPair_Pairs_PairsId",
                table: "CoinPair");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoinPair",
                table: "CoinPair");

            migrationBuilder.DropIndex(
                name: "IX_CoinPair_PairsId",
                table: "CoinPair");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetCoin",
                table: "AssetCoin");

            migrationBuilder.DropIndex(
                name: "IX_AssetCoin_CoinsId",
                table: "AssetCoin");

            migrationBuilder.RenameColumn(
                name: "PairsId",
                table: "CoinPair",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CoinsId",
                table: "CoinPair",
                newName: "CoinId");

            migrationBuilder.RenameColumn(
                name: "CoinsId",
                table: "AssetCoin",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AssetsId",
                table: "AssetCoin",
                newName: "AssetId");

            migrationBuilder.AddColumn<Guid>(
                name: "PairId",
                table: "CoinPair",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CoinId",
                table: "AssetCoin",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoinPair",
                table: "CoinPair",
                columns: new[] { "PairId", "CoinId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetCoin",
                table: "AssetCoin",
                columns: new[] { "CoinId", "AssetId" });

            migrationBuilder.CreateIndex(
                name: "IX_CoinPair_CoinId",
                table: "CoinPair",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCoin_AssetId",
                table: "AssetCoin",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCoin_Asset_AssetId",
                table: "AssetCoin",
                column: "AssetId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCoin_Coins_CoinId",
                table: "AssetCoin",
                column: "CoinId",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoinPair_Coins_CoinId",
                table: "CoinPair",
                column: "CoinId",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoinPair_Pairs_PairId",
                table: "CoinPair",
                column: "PairId",
                principalTable: "Pairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssetCoin_Asset_AssetId",
                table: "AssetCoin");

            migrationBuilder.DropForeignKey(
                name: "FK_AssetCoin_Coins_CoinId",
                table: "AssetCoin");

            migrationBuilder.DropForeignKey(
                name: "FK_CoinPair_Coins_CoinId",
                table: "CoinPair");

            migrationBuilder.DropForeignKey(
                name: "FK_CoinPair_Pairs_PairId",
                table: "CoinPair");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CoinPair",
                table: "CoinPair");

            migrationBuilder.DropIndex(
                name: "IX_CoinPair_CoinId",
                table: "CoinPair");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AssetCoin",
                table: "AssetCoin");

            migrationBuilder.DropIndex(
                name: "IX_AssetCoin_AssetId",
                table: "AssetCoin");

            migrationBuilder.DropColumn(
                name: "PairId",
                table: "CoinPair");

            migrationBuilder.DropColumn(
                name: "CoinId",
                table: "AssetCoin");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CoinPair",
                newName: "PairsId");

            migrationBuilder.RenameColumn(
                name: "CoinId",
                table: "CoinPair",
                newName: "CoinsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AssetCoin",
                newName: "CoinsId");

            migrationBuilder.RenameColumn(
                name: "AssetId",
                table: "AssetCoin",
                newName: "AssetsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CoinPair",
                table: "CoinPair",
                columns: new[] { "CoinsId", "PairsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AssetCoin",
                table: "AssetCoin",
                columns: new[] { "AssetsId", "CoinsId" });

            migrationBuilder.CreateIndex(
                name: "IX_CoinPair_PairsId",
                table: "CoinPair",
                column: "PairsId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetCoin_CoinsId",
                table: "AssetCoin",
                column: "CoinsId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCoin_Asset_AssetsId",
                table: "AssetCoin",
                column: "AssetsId",
                principalTable: "Asset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AssetCoin_Coins_CoinsId",
                table: "AssetCoin",
                column: "CoinsId",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoinPair_Coins_CoinsId",
                table: "CoinPair",
                column: "CoinsId",
                principalTable: "Coins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CoinPair_Pairs_PairsId",
                table: "CoinPair",
                column: "PairsId",
                principalTable: "Pairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
