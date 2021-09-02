using ExchangeProject.DataAccess.Concrete.EntityFramework.Mapping;
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
            builder.ApplyConfiguration(new AppRoleMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new AssetCoinMap());
            builder.ApplyConfiguration(new AssetMap());
            builder.ApplyConfiguration(new CoinMap());
            builder.ApplyConfiguration(new CoinPairMap());
            builder.ApplyConfiguration(new PairMap());
            builder.ApplyConfiguration(new WalletMap());
            builder.ApplyConfiguration(new TransactionMap());
            builder.ApplyConfiguration(new WalletTransactionMap());

            base.OnModelCreating(builder);
        }
    }
}
