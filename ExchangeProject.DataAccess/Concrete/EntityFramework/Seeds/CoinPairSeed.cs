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
    public class CoinPairSeed : IEntityTypeConfiguration<CoinPair>
    {
        public void Configure(EntityTypeBuilder<CoinPair> builder)
        {
            builder.HasData(
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
        }
    }
}