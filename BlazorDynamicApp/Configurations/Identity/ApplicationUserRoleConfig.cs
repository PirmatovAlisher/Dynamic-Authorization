using BlazorDynamicApp.Models.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.Identity
{
    public class ApplicationUserRoleConfig : IEntityTypeConfiguration<ApplicationUserRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserRole> builder)
        {
            builder.HasData(
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("256AC0CC-C4B0-458D-957D-24CBFD49225B").ToString(),
                    RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("256AC0CC-C4B0-458D-957D-24CBFD49225B").ToString(),
                    RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("256AC0CC-C4B0-458D-957D-24CBFD49225B").ToString(),
                    RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("256AC0CC-C4B0-458D-957D-24CBFD49225B").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },

                new ApplicationUserRole
                {
                    UserId = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                    RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                    RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("BB49CE85-C5C9-41D9-9665-321D430B7E2E").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },

                new ApplicationUserRole
                {
                    UserId = Guid.Parse("D7EBD93D-0642-4AB9-8DA3-4B6B2046E540").ToString(),
                    RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
                },
                new ApplicationUserRole
                {
                    UserId = Guid.Parse("D7EBD93D-0642-4AB9-8DA3-4B6B2046E540").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                },

                new ApplicationUserRole
                {
                    UserId = Guid.Parse("2ADE9CC9-9152-4209-AE22-F2E9E57B09A7").ToString(),
                    RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
                }

                );
        }
    }
}
