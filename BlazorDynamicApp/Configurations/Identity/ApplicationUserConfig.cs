using BlazorDynamicApp.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace BlazorDynamicApp.Configurations.Identity
{
    public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var superAdmin = new ApplicationUser
            {
                Id = Guid.Parse("256AC0CC-C4B0-458D-957D-24CBFD49225B").ToString(),
                Email = "pirmatovalisher000@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER000@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher000@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER000@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var superAdminPasswordHash = PasswordHash(superAdmin, "Pirmatov_123");
            superAdmin.PasswordHash = superAdminPasswordHash;
            builder.HasData(superAdmin);


            var admin = new ApplicationUser
            {
                Id = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                Email = "pirmatovalisher2000@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER2000@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher2000@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER2000@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var adminPasswordHash = PasswordHash(admin, "Pirmatov_123");
            admin.PasswordHash = adminPasswordHash;
            builder.HasData(admin);


            var manager = new ApplicationUser
            {
                Id = Guid.Parse("D7EBD93D-0642-4AB9-8DA3-4B6B2046E540").ToString(),
                Email = "pirmatovalisher0000@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER0000@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher0000@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER0000@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var managerPasswordHash = PasswordHash(manager, "Pirmatov_123");
            manager.PasswordHash = managerPasswordHash;
            builder.HasData(manager);


            var member = new ApplicationUser
            {
                Id = Guid.Parse("2ADE9CC9-9152-4209-AE22-F2E9E57B09A7").ToString(),
                Email = "pirmatovalisher@gmail.com",
                NormalizedEmail = "PIRMATOVALISHER@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                UserName = "pirmatovalisher@gmail.com",
                NormalizedUserName = "PIRMATOVALISHER@GMAIL.COM",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var memberPasswordHash = PasswordHash(member, "Pirmatov_123");
            member.PasswordHash = memberPasswordHash;
            builder.HasData(member);
        }

        private string PasswordHash(ApplicationUser user, string password)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            return passwordHasher.HashPassword(user, password);
        }
    }
}
