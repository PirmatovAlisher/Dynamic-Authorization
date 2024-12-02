using BlazorDynamicApp.Models.Permission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.Permissions
{
	public class UserPermissionConfig : IEntityTypeConfiguration<UserPermission>
	{
		public void Configure(EntityTypeBuilder<UserPermission> builder)
		{
			builder.HasData(
				new UserPermission
				{
					Id = 1,
					UserId = Guid.Parse("D7EBD93D-0642-4AB9-8DA3-4B6B2046E540").ToString(),
					PermissionId = 23
				}
				);
		}
	}
}
