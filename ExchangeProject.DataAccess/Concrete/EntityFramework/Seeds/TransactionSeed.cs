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
    public class TransactionSeed : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasData(
                new Transaction { Id = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), CoinId = new Guid("4c69b0b4-4633-45e6-b461-48684bc23011"), Status = Status.True, TransactionTime = DateTime.UtcNow });
        }
    }
}