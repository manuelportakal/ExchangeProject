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
    public class WalletSeed : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasData(
                new Wallet { Id = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), AppUserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                new Wallet { Id = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), AppUserId = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") });
        }
    }
}