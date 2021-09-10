using ExchangeProject.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject.DataAccess.Concrete.EntityFramework.Seeds
{
    public class AssetSeed : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {
            builder.HasData(
                new Asset { Id = new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), WalletId = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), Amount = decimal.Parse("9999") },
                new Asset { Id = new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), WalletId = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), Amount = decimal.Parse("1") });
        }
    }
}