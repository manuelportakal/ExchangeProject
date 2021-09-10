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
    public class PairSeed : IEntityTypeConfiguration<Pair>
    {
        public void Configure(EntityTypeBuilder<Pair> builder)
        {
            builder.HasData(
                new Pair { Id = new Guid("3fbf715a-e9b4-4324-987e-1459ad1435f9"), Name = "BTC-USDT", Price = decimal.Parse("51317,89") },
                new Pair { Id = new Guid("6d9b7d78-b560-4de1-9359-82c71848c42b"), Name = "ETH-USDT", Price = decimal.Parse("3772,04") },
                new Pair { Id = new Guid("77033d4b-0933-43ec-978f-2387f3f0a702"), Name = "ADA-USDT", Price = decimal.Parse("2,64") },
                new Pair { Id = new Guid("b1f5e042-2814-4633-95b9-5a9bd6161301"), Name = "BNB-USDT", Price = decimal.Parse("479,59") },
                new Pair { Id = new Guid("ac85e80e-f34f-4aae-80ce-39999aa8c56a"), Name = "SOLANA-USDT", Price = decimal.Parse("182,94") });
        }
    }
}