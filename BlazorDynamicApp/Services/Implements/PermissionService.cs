using BlazorDynamicApp.Context;
using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorDynamicApp.Services.Implements
{
	public class PermissionService : IPermissionService
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IUserPermissionService _userPermissionService;

		public PermissionService(IUserPermissionService userPermissionService, IServiceProvider serviceProvider)
		{
			_userPermissionService = userPermissionService;
			_serviceProvider = serviceProvider;
		}

		private async Task<Permission?> GetPermissionByNameAsync(string permissionName, ResourceType resourceType)
		{
			using (var scope = _serviceProvider.CreateScope())
			{
				var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
				var permission = await context.Permissions.FirstOrDefaultAsync(x => x.Name == permissionName && x.Resource == resourceType);
				if (permission != null)
				{
					return permission;
				}
				else
				{
					return null;
				}
			}
		}

		public async Task<bool> HasPermissionAsync(ApplicationUser user, string permissionName, ResourceType resourceType)
		{
			var permission = await GetPermissionByNameAsync(permissionName, resourceType);
			if (permission != null)
			{
				var result = await _userPermissionService.HasPermissionAsync(user, permission);
				return result;
			}
			return false;
		}
	}
}
