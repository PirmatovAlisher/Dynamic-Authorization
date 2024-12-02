using BlazorDynamicApp.Models.Permission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.Permissions
{
	public class RolePermissionConfig : IEntityTypeConfiguration<RolePermission>
	{
		public void Configure(EntityTypeBuilder<RolePermission> builder)
		{
			builder.HasData(
				//SuperAdmin Role permissions

				//Employee permissions
				new RolePermission
				{
					Id = 1,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 1
				},
				new RolePermission
				{
					Id = 2,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 2
				},
				new RolePermission
				{
					Id = 3,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 3
				},
				new RolePermission
				{
					Id = 4,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 4
				},
				//Product permissions
				new RolePermission
				{
					Id = 5,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 5
				},
				new RolePermission
				{
					Id = 6,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 6
				},
				new RolePermission
				{
					Id = 7,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 7
				},
				new RolePermission
				{
					Id = 8,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 8
				},
				//Role permissions
				new RolePermission
				{
					Id = 9,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 9
				},
				new RolePermission
				{
					Id = 10,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 10
				},
				new RolePermission
				{
					Id = 11,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 11
				},
				new RolePermission
				{
					Id = 12,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 12
				},
				new RolePermission
				{
					Id = 13,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 13
				},
				new RolePermission
				{
					Id = 14,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 14
				},
				new RolePermission
				{
					Id = 15,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 15
				},
				//User permissions
				new RolePermission
				{
					Id = 16,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 16
				},
				new RolePermission
				{
					Id = 17,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 17
				},
				new RolePermission
				{
					Id = 18,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 18
				},
				new RolePermission
				{
					Id = 19,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 19
				},
				new RolePermission
				{
					Id = 20,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 20
				},
				new RolePermission
				{
					Id = 21,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 21
				},
				new RolePermission
				{
					Id = 22,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 22
				},
				//UserRole permissions
				new RolePermission
				{
					Id = 23,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 23
				},
				new RolePermission
				{
					Id = 24,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 24
				},
				new RolePermission
				{
					Id = 25,
					RoleId = Guid.Parse("DE820986-A707-4CC5-8306-776812617837").ToString(),
					PermissionId = 25
				},

				//Admin Role permissions
				//Employee permissions
				new RolePermission
				{
					Id = 26,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 1
				},
				new RolePermission
				{
					Id = 27,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 2
				},
				new RolePermission
				{
					Id = 28,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 3
				},
				new RolePermission
				{
					Id = 29,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 4
				},
				//Product permissions
				new RolePermission
				{
					Id = 30,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 5
				},
				new RolePermission
				{
					Id = 31,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 6
				},
				new RolePermission
				{
					Id = 32,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 7
				},
				new RolePermission
				{
					Id = 33,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 8
				},
				//Role permissions
				new RolePermission
				{
					Id = 34,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 9
				},
				new RolePermission
				{
					Id = 35,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 10
				},
				new RolePermission
				{
					Id = 36,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 11
				},
				new RolePermission
				{
					Id = 37,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 12
				},
				new RolePermission
				{
					Id = 38,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 13
				},
				//User permissions
				new RolePermission
				{
					Id = 39,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 16
				},
				new RolePermission
				{
					Id = 40,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 17
				},
				new RolePermission
				{
					Id = 41,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 18
				},
				new RolePermission
				{
					Id = 42,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 19
				},
				new RolePermission
				{
					Id = 43,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 20
				},
				//UserRole permissions
				new RolePermission
				{
					Id = 44,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 23
				},
				new RolePermission
				{
					Id = 45,
					RoleId = Guid.Parse("8815F0D6-DB8E-4606-8ACB-12844E7B796B").ToString(),
					PermissionId = 24
				},

				//Manager Role permissions
				//Employee permissions
				new RolePermission
				{
					Id = 46,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 1
				},
				new RolePermission
				{
					Id = 47,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 2
				},
				new RolePermission
				{
					Id = 48,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 3
				},
				new RolePermission
				{
					Id = 49,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 4
				},
				//Product permissions
				new RolePermission
				{
					Id = 50,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 5
				},
				new RolePermission
				{
					Id = 51,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 6
				},
				new RolePermission
				{
					Id = 52,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 7
				},
				new RolePermission
				{
					Id = 53,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 8
				},
				//Role permissions
				new RolePermission
				{
					Id = 54,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 12
				},
				//User permissions
				new RolePermission
				{
					Id = 55,
					RoleId = Guid.Parse("11C174C2-94CC-4615-8D46-4655DEE45EA7").ToString(),
					PermissionId = 19
				},

				//Member Role permissions
				//Employee permissions
				new RolePermission
				{
					Id = 56,
					RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
					PermissionId = 4
				},
				//Product permissions
				new RolePermission
				{
					Id = 57,
					RoleId = Guid.Parse("D140EB54-ED6E-4FF2-9199-71FCBE722EF7").ToString(),
					PermissionId = 8
				}
				);
		}
	}
}
