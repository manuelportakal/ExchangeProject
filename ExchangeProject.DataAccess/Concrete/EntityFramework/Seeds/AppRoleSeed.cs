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
    public class AppRoleSeed : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole { Id = new Guid("aa835070-6a78-42c6-99df-c14682615666"), Name = "Admin" },
                new AppRole { Id = new Guid("f7f50d37-b8d5-4cf4-9c3b-427463a871b8"), Name = "Member" });
        }
    }
}