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
    public class AppUserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                new AppUser
                {
                    Id = new Guid("8e445865-a24d-4543-a6c6-9443d048cdb9"),
                    FirstName = "Yavuz",
                    LastName = "Emilli",
                    Email = "yavuzemilli@gmail.com",
                    UserName = "manuelportakal",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd1")
                },
                new AppUser
                {
                    Id = new Guid("d776cec2-4120-4d88-b8a5-ece32765a970"),
                    FirstName = "Eren",
                    LastName = "Ozder",
                    Email = "erenozder@gmail.com",
                    UserName = "erno",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd2")
                }
            );
        }
    }
}