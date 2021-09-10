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
    public class IdentityUserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
                new IdentityUserRole<Guid> { RoleId = new Guid("aa835070-6a78-42c6-99df-c14682615666"), UserId = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9") },
                new IdentityUserRole<Guid> { RoleId = new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), UserId = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970") });

        }
    }
}