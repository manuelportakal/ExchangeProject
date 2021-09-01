using ExchangeProject.Entities.Concrete;
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
        public DbSet<Coin> Coins { get; set; }
        public DbSet<Pair> Pairs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExchangeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AppUser>().HasOne(a => a.Wallet).WithOne(a => a.AppUser).HasForeignKey<Wallet>(c => c.AppUserId);

            builder.Entity<Coin>().HasMany(x => x.CoinPairs).WithOne(x => x.Coin).HasForeignKey(x => x.CoinId);
            builder.Entity<Pair>().HasMany(x => x.CoinPairs).WithOne(x => x.Pair).HasForeignKey(x => x.PairId);
            builder.Entity<CoinPair>().HasKey(x => new { x.PairId, x.CoinId });

            builder.Entity<Asset>().HasMany(x => x.AssetCoins).WithOne(x => x.Asset).HasForeignKey(x => x.AssetId);
            builder.Entity<Coin>().HasMany(x => x.AssetCoins).WithOne(x => x.Coin).HasForeignKey(x => x.CoinId);
            builder.Entity<AssetCoin>().HasKey(x => new { x.CoinId, x.AssetId });

            base.OnModelCreating(builder);
        }
    }
}
