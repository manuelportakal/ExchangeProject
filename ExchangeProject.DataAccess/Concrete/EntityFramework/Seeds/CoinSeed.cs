using ExchangeProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework.Seeds
{
    public class CoinSeed : IEntityTypeConfiguration<Coin>
    {
        public void Configure(EntityTypeBuilder<Coin> builder)
        {
            builder.HasData(
                new Coin { Id = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), Name = "Bitcoin", Code = "BTC" },
                new Coin { Id = new Guid("e1493a7f-5c0e-4f53-97a5-745222430809"), Name = "Ethereum", Code = "ETH" },
                new Coin { Id = new Guid("41ec3edd-12a6-47dd-beef-6ea0cd5c5788"), Name = "Cardano", Code = "ADA" },
                new Coin { Id = new Guid("68c216d0-bb53-416f-b65d-7066be83c744"), Name = "Binance Coin", Code = "BNB" },
                new Coin { Id = new Guid("5aa4cd28-38a4-4b55-a9f5-e03a0569a1a9"), Name = "Tether", Code = "USDT" },
                new Coin { Id = new Guid("21ce2213-fd86-43c5-bb0a-c5f0ef6439e5"), Name = "Solana", Code = "SOL" });
        }
    }
}