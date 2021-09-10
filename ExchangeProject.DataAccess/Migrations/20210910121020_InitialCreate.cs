using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExchangeProject.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wallet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallet_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    TransactionTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transaction_Coins_CoinId",
                        column: x => x.CoinId,
                        principalTable: "Coins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoinPair",
                columns: table => new
                {
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PairId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinPair", x => new { x.PairId, x.CoinId });
                    table.ForeignKey(
                        name: "FK_CoinPair_Coins_CoinId",
                        column: x => x.CoinId,
                        principalTable: "Coins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoinPair_Pairs_PairId",
                        column: x => x.PairId,
                        principalTable: "Pairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_Coins_CoinId",
                        column: x => x.CoinId,
                        principalTable: "Coins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Asset_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WalletTransaction",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WalletId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionRole = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalletTransaction", x => new { x.WalletId, x.TransactionId });
                    table.ForeignKey(
                        name: "FK_WalletTransaction_Transaction_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WalletTransaction_Wallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "Wallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("aa835070-6a78-42c6-99df-c14682615666"), "5ea4efa9-881d-4e4c-9521-3d0276ec1a5a", "Admin", null },
                    { new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), "3be5fc7f-99e2-489d-b2c8-36167e6682d0", "Member", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9"), 0, "4e9541db-062d-4500-9ccb-e4934c796310", "yavuzemilli@gmail.com", false, "Yavuz", "Emilli", false, null, null, null, "AQAAAAEAACcQAAAAEEzeMnkmc8zXnSN+hfIpdeAe36X4H0Kw+4jBJeDO2DoxR7Pt7O8x5Cz3tBP62hNo5w==", null, false, null, false, "manuelportakal" },
                    { new Guid("d776cec2-4120-4d88-b8a5-ece32765a970"), 0, "01b5b35b-6e67-4fe3-a509-c65a76c3a5d6", "erenozder@gmail.com", false, "Eren", "Ozder", false, null, null, null, "AQAAAAEAACcQAAAAEGzUl5shPCNtw+RIuvqRntpKe79RQPcl0H7/OcSwLdaMZdRGTVlohHMgwxQOjfCGww==", null, false, null, false, "erno" }
                });

            migrationBuilder.InsertData(
                table: "Coins",
                columns: new[] { "Id", "Code", "Name", "Symbol" },
                values: new object[,]
                {
                    { new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), "BTC", "Bitcoin", null },
                    { new Guid("e1493a7f-5c0e-4f53-97a5-745222430809"), "ETH", "Ethereum", null },
                    { new Guid("41ec3edd-12a6-47dd-beef-6ea0cd5c5788"), "ADA", "Cardano", null },
                    { new Guid("68c216d0-bb53-416f-b65d-7066be83c744"), "BNB", "Binance Coin", null },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), "USDT", "Tether", null },
                    { new Guid("21ce2213-fd86-43c5-bb0a-c5f0ef6439e5"), "SOL", "Solana", null }
                });

            migrationBuilder.InsertData(
                table: "Pairs",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9"), "BTC-USDT", 51317.89m },
                    { new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b"), "ETH-USDT", 3772.04m },
                    { new Guid("77033d4b-0933-43ec-978f-2387f3f0a702"), "ADA-USDT", 2.64m },
                    { new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301"), "BNB-USDT", 479.59m },
                    { new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a"), "SOLANA-USDT", 182.94m }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("aa835070-6a78-42c6-99df-c14682615666"), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                    { new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") }
                });

            migrationBuilder.InsertData(
                table: "CoinPair",
                columns: new[] { "CoinId", "PairId", "Id" },
                values: new object[,]
                {
                    { new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9"), new Guid("7d1e7831-af96-42df-b768-8647a324cbbf") },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9"), new Guid("7d1e7831-af96-42df-b768-8647a324cbbf") },
                    { new Guid("e1493a7f-5c0e-4f53-97a5-745222430809"), new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b"), new Guid("7683f95c-5b64-45fb-bd14-e308dd29aee7") },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b"), new Guid("7683f95c-5b64-45fb-bd14-e308dd29aee7") },
                    { new Guid("41ec3edd-12a6-47dd-beef-6ea0cd5c5788"), new Guid("77033d4b-0933-43ec-978f-2387f3f0a702"), new Guid("b69b0f5a-9e96-4a21-9461-1af0a37957b4") },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), new Guid("77033d4b-0933-43ec-978f-2387f3f0a702"), new Guid("b69b0f5a-9e96-4a21-9461-1af0a37957b4") },
                    { new Guid("68c216d0-bb53-416f-b65d-7066be83c744"), new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301"), new Guid("a4b6d863-2b21-4011-8e3c-adbe99423bda") },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301"), new Guid("a4b6d863-2b21-4011-8e3c-adbe99423bda") },
                    { new Guid("21ce2213-fd86-43c5-bb0a-c5f0ef6439e5"), new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a"), new Guid("4cd794ba-572c-4014-b6aa-9d9d7c701b21") },
                    { new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a"), new Guid("4cd794ba-572c-4014-b6aa-9d9d7c701b21") }
                });

            migrationBuilder.InsertData(
                table: "Transaction",
                columns: new[] { "Id", "CoinId", "Status", "TransactionTime" },
                values: new object[] { new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), (byte)1, new DateTime(2021, 9, 10, 12, 10, 19, 433, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "AppUserId" },
                values: new object[,]
                {
                    { new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                    { new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") }
                });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "Amount", "CoinId", "WalletId" },
                values: new object[,]
                {
                    { new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), 9999m, new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9") },
                    { new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), 1m, new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859") }
                });

            migrationBuilder.InsertData(
                table: "WalletTransaction",
                columns: new[] { "TransactionId", "WalletId", "Amount", "Id", "TransactionRole" },
                values: new object[,]
                {
                    { new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), -1m, new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), 1 },
                    { new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), 1m, new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_CoinId",
                table: "Asset",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_Asset_WalletId",
                table: "Asset",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_CoinPair_CoinId",
                table: "CoinPair",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CoinId",
                table: "Transaction",
                column: "CoinId");

            migrationBuilder.CreateIndex(
                name: "IX_Wallet_AppUserId",
                table: "Wallet",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WalletTransaction_TransactionId",
                table: "WalletTransaction",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "CoinPair");

            migrationBuilder.DropTable(
                name: "WalletTransaction");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pairs");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "Wallet");

            migrationBuilder.DropTable(
                name: "Coins");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
