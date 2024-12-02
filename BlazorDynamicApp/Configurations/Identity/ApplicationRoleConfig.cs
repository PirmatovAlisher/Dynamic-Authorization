using BlazorDynamicApp.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.Identity
{
    public class ApplicationRoleConfig : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(new ApplicationRole
            {
                Id = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            builder.HasData(new ApplicationRole
            {
                Id = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            builder.HasData(new ApplicationRole
            {
                Id = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            builder.HasData(new ApplicationRole
            {
                Id = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                Name = "Member",
                NormalizedName = "MEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString()

            });
        }
    }
}
