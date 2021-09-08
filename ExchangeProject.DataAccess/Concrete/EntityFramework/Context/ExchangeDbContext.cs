using ExchangeProject.DataAccess.Concrete.EntityFramework.Mapping;
using ExchangeProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework.Context
{
    public class ExchangeDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExchangeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ExchangeDbContext).Assembly);
            builder.Entity<Coin>().HasData(
                new Coin { Id = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), Name = "Bitcoin", Code = "BTC" },
                new Coin { Id = new Guid("e1493a7f-5c0e-4f53-97a5-745222430809"), Name = "Ethereum", Code = "ETH" },
                new Coin { Id = new Guid("41ec3edd-12a6-47dd-beef-6ea0cd5c5788"), Name = "Cardano", Code = "ADA" },
                new Coin { Id = new Guid("68c216d0-bb53-416f-b65d-7066be83c744"), Name = "Binance Coin", Code = "BNB" },
                new Coin { Id = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), Name = "Tether", Code = "USDT" },
                new Coin { Id = new Guid("21ce2213-fd86-43c5-bb0a-c5f0ef6439e5"), Name = "Solana", Code = "SOL" });

            builder.Entity<Pair>().HasData(
                new Pair { Id = new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9"), Name = "BTC-USDT", Price = decimal.Parse("51317,89") },
                new Pair { Id = new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b"), Name = "ETH-USDT", Price = decimal.Parse("3772,04") },
                new Pair { Id = new Guid("77033d4b-0933-43ec-978f-2387f3f0a702"), Name = "ADA-USDT", Price = decimal.Parse("2,64") },
                new Pair { Id = new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301"), Name = "BNB-USDT", Price = decimal.Parse("479,59") },
                new Pair { Id = new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a"), Name = "SOLANA-USDT", Price = decimal.Parse("182,94") });


            builder.Entity<CoinPair>().HasData(
                new CoinPair { Id = new Guid("7d1e7831-af96-42df-b768-8647a324cbbf"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), PairId = new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9") },
                new CoinPair { Id = new Guid("7d1e7831-af96-42df-b768-8647a324cbbf"), CoinId = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), PairId = new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9") },
                new CoinPair { Id = new Guid("7683f95c-5b64-45fb-bd14-e308dd29aee7"), CoinId = new Guid("e1493a7f-5c0e-4f53-97a5-745222430809"), PairId = new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b") },
                new CoinPair { Id = new Guid("7683f95c-5b64-45fb-bd14-e308dd29aee7"), CoinId = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), PairId = new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b") },
                new CoinPair { Id = new Guid("b69b0f5a-9e96-4a21-9461-1af0a37957b4"), CoinId = new Guid("41ec3edd-12a6-47dd-beef-6ea0cd5c5788"), PairId = new Guid("77033d4b-0933-43ec-978f-2387f3f0a702") },
                new CoinPair { Id = new Guid("b69b0f5a-9e96-4a21-9461-1af0a37957b4"), CoinId = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), PairId = new Guid("77033d4b-0933-43ec-978f-2387f3f0a702") },
                new CoinPair { Id = new Guid("a4b6d863-2b21-4011-8e3c-adbe99423bda"), CoinId = new Guid("68c216d0-bb53-416f-b65d-7066be83c744"), PairId = new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301") },
                new CoinPair { Id = new Guid("a4b6d863-2b21-4011-8e3c-adbe99423bda"), CoinId = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), PairId = new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301") },
                new CoinPair { Id = new Guid("4cd794ba-572c-4014-b6aa-9d9d7c701b21"), CoinId = new Guid("21ce2213-fd86-43c5-bb0a-c5f0ef6439e5"), PairId = new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a") },
                new CoinPair { Id = new Guid("4cd794ba-572c-4014-b6aa-9d9d7c701b21"), CoinId = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), PairId = new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a") });

            var hasher = new PasswordHasher<AppUser>();
            builder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9"),
                    FirstName = "Yavuz",
                    LastName = "Emilli",
                    Email = "yavuzemilli@gmail.com",
                    UserName = "manuelportakal",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd1")
                },
                new AppUser
                {
                    Id = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970"),
                    FirstName = "Eren",
                    LastName = "Ozder",
                    Email = "erenozder@gmail.com",
                    UserName = "erno",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd2")
                }
            );

            builder.Entity<AppRole>().HasData(
                new AppRole { Id = new Guid("aa835070-6a78-42c6-99df-c14682615666"), Name = "Admin" },
                new AppRole { Id = new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), Name = "Member" });

            builder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid> { RoleId = new Guid("aa835070-6a78-42c6-99df-c14682615666"), UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                new IdentityUserRole<Guid> { RoleId = new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), UserId = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") });

            builder.Entity<Wallet>().HasData(
                new Wallet { Id = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), AppUserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                new Wallet { Id = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), AppUserId = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") });

            builder.Entity<Asset>().HasData(
                new Asset { Id = new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), WalletId = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), Amount = decimal.Parse("9999") },
                new Asset { Id = new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), WalletId = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), Amount = decimal.Parse("1") });

            builder.Entity<Transaction>().HasData(
                new Transaction { Id = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), Status = Status.True, TransactionTime = DateTime.UtcNow });

            builder.Entity<WalletTransaction>().HasData(
                new WalletTransaction { Id = new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), WalletId = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), TransactionId = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), TransactionRole = TransactionRole.Sender, Amount = decimal.Parse("-1") },
                new WalletTransaction { Id = new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), WalletId = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), TransactionId = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), TransactionRole = TransactionRole.Receiver, Amount = decimal.Parse("1") });

            base.OnModelCreating(builder);
        }

        public DbSet<Coin> Coins { get; set; }
        public DbSet<Pair> Pairs { get; set; }
    }
}
