using BlazorDynamicApp.Context;
using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace BlazorDynamicApp.Services.Implements
{
	public class RolePermissionService : IRolePermissionService
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IServiceScopeFactory _serviceScopeFactory;
		private readonly IRoleService _roleService;

		public RolePermissionService(IRoleService roleService, IServiceProvider serviceProvider, IServiceScopeFactory serviceScopeFactory)
		{
			_roleService = roleService;
			_serviceProvider = serviceProvider;
			_serviceScopeFactory = serviceScopeFactory;
		}

		public async Task<List<Permission>> GetAllPermissionAsync()
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var permissions = await context.Permissions.ToListAsync();
				if (permissions.Any())
				{
					return permissions;
				}
				return new List<Permission>();
			}
		}

		public async Task<Permission> GetPermissionByIdAsync(int Id)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var permission = await context.Permissions.FindAsync(Id);
				if (permission != null)
				{
					return permission;
				}
				return new Permission();
			}

		}

		public async Task<List<RolePermission>> GetRolePermissionsAsync(string roleId)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var rolePermissions = await context.RolePermissions.Where(x => x.RoleId == roleId)
								.Include(x => x.Permission)
								.ToListAsync();

				if (rolePermissions.Any())
				{
					return rolePermissions;
				}
				return new List<RolePermission>();
			}
		}

		public async Task<RolePermission> GetRolePermissionAsync(string roleId, int permissionId)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var rolePermission = await context.RolePermissions
								.Include(x => x.Permission)
								.Include(x => x.Role)
								.FirstAsync(x => x.RoleId == roleId && x.PermissionId == permissionId);
				if (rolePermission != null)
				{
					return rolePermission;
				}
				return new RolePermission();
			}

		}

		public async Task<List<Permission>> GetAvailablePermissionsAsync(string roleId)
		{
			var availablePermissions = await GetAllPermissionAsync();
			var rolePermissions = await GetRolePermissionsAsync(roleId);

			foreach (var rolePermission in rolePermissions)
			{
				var permission = await GetPermissionByIdAsync(rolePermission.PermissionId);

				if (availablePermissions.Contains(permission))
				{
					availablePermissions.Remove(permission);
				}
			}
			return availablePermissions;
		}

		public async Task<bool> AddPermissionToRoleAsync(ApplicationRole role, Permission permission)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var rolePermission = new RolePermission
				{
					RoleId = role.Id,
					//Role = role,
					PermissionId = permission.Id,
					//Permission = permission
				};

				await context.RolePermissions.AddAsync(rolePermission);
				await context.SaveChangesAsync();

				return true;
			}
		}

		public async Task<bool> RemovePermissionFromRoleAsync(ApplicationRole role, Permission permission)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var rolePermission = await GetRolePermissionAsync(role.Id, permission.Id);

				if (rolePermission != null)
				{
					context.RolePermissions.Remove(rolePermission);
					await context.SaveChangesAsync();
					return true;
				}
				return false;
			}
		}

		public async Task<bool> RoleHasPermissionAsync(ApplicationRole role, Permission permission)
		{
			var rolePermissions = await GetRolePermissionsAsync(role.Id);
			foreach (var rolePermission in rolePermissions)
			{
				if (rolePermission.PermissionId == permission.Id)
				{
					return true;
				}
			}
			return false;
		}

	}
}
