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
    public class CoinPairMap : IEntityTypeConfiguration<CoinPair>
    {
        public void Configure(EntityTypeBuilder<CoinPair> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasKey(x => new { x.PairId, x.CoinId });
        }
    }
}
