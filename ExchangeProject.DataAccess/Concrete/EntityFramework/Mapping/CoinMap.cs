using ExchangeProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework.Mapping
{
    public class CoinMap : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.CoinPairs).WithOne(x => x.Coin).HasForeignKey(x => x.CoinId);
            builder.HasMany(x => x.AssetCoins).WithOne(x => x.Coin).HasForeignKey(x => x.CoinId);
            builder.HasMany(x => x.Transactions).WithOne(x => x.Coin).HasForeignKey(x => x.CoinId);
        }
    }
}
