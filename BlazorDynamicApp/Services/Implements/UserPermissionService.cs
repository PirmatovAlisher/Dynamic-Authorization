using BlazorDynamicApp.Context;
using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorDynamicApp.Services.Implements
{
	public class UserPermissionService : IUserPermissionService
	{
		private readonly IUserRoleService _userRoleService;
		private readonly IRolePermissionService _rolePermissionService;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public UserPermissionService(
			IUserRoleService userRoleService,
			IRolePermissionService rolePermissionService,
			IServiceScopeFactory serviceScopeFactory)
		{
			_userRoleService = userRoleService;
			_rolePermissionService = rolePermissionService;
			_serviceScopeFactory = serviceScopeFactory;
		}


		public async Task<bool> HasPermissionAsync(ApplicationUser user, Permission permission)
		{
			var userRolePermission = await UserRolesHasPermissionAsync(user, permission);
			if (userRolePermission)
			{
				return true;
			}

			var userPermission = await UserHasPermissionAsync(user, permission);
			if (userPermission)
			{
				return true;
			}

			return false;
		}

		public async Task<bool> UserRolesHasPermissionAsync(ApplicationUser user, Permission permission)
		{
			var userRoles = await _userRoleService.GetAllUserRolesAsync(user.Id);

			foreach (var userRole in userRoles)
			{
				var roleHasPermission = await _rolePermissionService.RoleHasPermissionAsync(userRole, permission);
				if (roleHasPermission)
				{
					return true;
				}
			}
			return false;
		}
		public async Task<bool> UserHasPermissionAsync(ApplicationUser user, Permission permission)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var userPermissions = await context.UserPermissions.Where(x => x.UserId == user.Id).ToListAsync();

				foreach (var userPermission in userPermissions)
				{
					if (userPermission.PermissionId == permission.Id)
					{
						return true;
					}
				}
				return false;
			}

		}

		public async Task<bool> AssignPermissionToUserAsync(ApplicationUser user, Permission permission)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var userPermission = new UserPermission
				{
					PermissionId = permission.Id,
					//Permission = permission,
					UserId = user.Id,
					//User = user					
				};

				await context.UserPermissions.AddAsync(userPermission);
				await context.SaveChangesAsync();

				return true;
			}

		}
		public async Task<bool> RemovePermissionFromUserAsync(ApplicationUser user, Permission permission)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var userPermission = await context.UserPermissions.
								FirstOrDefaultAsync(x => x.UserId == user.Id && x.PermissionId == permission.Id);

				if (userPermission != null)
				{
					context.UserPermissions.Remove(userPermission);
					await context.SaveChangesAsync();
					return true;
				}
				return false;
			}
		}

	}
}
