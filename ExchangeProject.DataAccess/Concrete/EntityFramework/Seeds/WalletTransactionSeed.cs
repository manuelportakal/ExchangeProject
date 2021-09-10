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
    public class WalletTransactionSeed : IEntityTypeConfiguration<WalletTransaction>
    {
        public void Configure(EntityTypeBuilder<WalletTransaction> builder)
        {
            builder.HasData(
                new WalletTransaction { Id = new Guid("6a05d346-411a-4ca8-972f-d8ce354d4070"), WalletId = new Guid("83d8f26c-e7d3-4480-bdd5-500d700e2ec9"), TransactionId = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), TransactionRole = TransactionRole.Sender, Amount = decimal.Parse("-1") },
                new WalletTransaction { Id = new Guid("6cd1257e-f45f-4872-9379-2e1882597562"), WalletId = new Guid("621d80cf-cb97-46b2-9f0c-64e68031c859"), TransactionId = new Guid("04aeaea9-713d-4519-9c8f-eef4acced9cf"), TransactionRole = TransactionRole.Receiver, Amount = decimal.Parse("1") });
        }
    }
}