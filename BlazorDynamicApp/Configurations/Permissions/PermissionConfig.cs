using BlazorDynamicApp.Models.Permission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.Permissions
{
	public class PermissionConfig : IEntityTypeConfiguration<Permission>
	{
		public void Configure(EntityTypeBuilder<Permission> builder)
		{
			builder.HasData(
				new Permission
				{
					Id = 1,
					Name = "Create",
					Resource = ResourceType.Employee,
				},
				new Permission
				{
					Id = 2,
					Name = "Edit",
					Resource = ResourceType.Employee,
				},
				new Permission
				{
					Id = 3,
					Name = "Delete",
					Resource = ResourceType.Employee
				},
				new Permission
				{
					Id = 4,
					Name = "View",
					Resource = ResourceType.Employee,
				},
				new Permission
				{
					Id = 5,
					Name = "Create",
					Resource = ResourceType.Product,
				},
				new Permission
				{
					Id = 6,
					Name = "Edit",
					Resource = ResourceType.Product,
				},
				new Permission
				{
					Id = 7,
					Name = "Delete",
					Resource = ResourceType.Product,
				},
				new Permission
				{
					Id = 8,
					Name = "View",
					Resource = ResourceType.Product,
				},
				new Permission
				{
					Id = 9,
					Name = "Create",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 10,
					Name = "Edit",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 11,
					Name = "Delete",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 12,
					Name = "View",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 13,
					Name = "ViewRolePermissions",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 14,
					Name = "AddPermissionToRole",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 15,
					Name = "RemovePermissionFromRole",
					Resource = ResourceType.Role,
				},
				new Permission
				{
					Id = 16,
					Name = "Create",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 17,
					Name = "Edit",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 18,
					Name = "Delete",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 19,
					Name = "View",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 20,
					Name = "ViewUserPermissions",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 21,
					Name = "AddPermissionToUser",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 22,
					Name = "RemovePermissionFromUser",
					Resource = ResourceType.User,
				},
				new Permission
				{
					Id = 23,
					Name = "ViewUserRoles",
					Resource = ResourceType.UserRole,
				},
				new Permission
				{
					Id = 24,
					Name = "AddRoleToUser",
					Resource = ResourceType.UserRole,
				},
				new Permission
				{
					Id = 25,
					Name = "RemoveRoleFromUser",
					Resource = ResourceType.UserRole,
				}
				);
		}
	}
}
