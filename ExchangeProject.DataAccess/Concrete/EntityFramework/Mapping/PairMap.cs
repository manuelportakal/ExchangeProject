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
    public class PairMap : IEntityTypeConfiguration<Pair>
    {
        public void Configure(EntityTypeBuilder<Pair> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.CoinPairs).WithOne(x => x.Pair).HasForeignKey(x => x.PairId);
        }
    }
}
