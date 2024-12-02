using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace BlazorDynamicApp.Services.Implements
{
	public class UserRoleService : IUserRoleService
	{
		private readonly IUserService _userService;
		private readonly IRoleService _roleService;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public UserRoleService(IUserService userService, IRoleService roleService, IServiceScopeFactory serviceScopeFactory)
		{
			_userService = userService;
			_roleService = roleService;
			_serviceScopeFactory = serviceScopeFactory;
		}

		public async Task<List<ApplicationRole>> GetAllUserRolesAsync(string userId)
		{
			var user = await _userService.GetUserByIdAsync(userId);
			var userRoles = new List<ApplicationRole>();
			IList<string> userRoleNames;
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				userRoleNames = await userManager.GetRolesAsync(user);

				foreach (var userRoleName in userRoleNames)
				{
					using (var scope2 = _serviceScopeFactory.CreateScope())
					{
						var roleManager = scope2.ServiceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
						var role = await roleManager.FindByNameAsync(userRoleName);
						userRoles.Add(role);
					}
				}
				return userRoles;
			}
		}

		public async Task<IList<ApplicationUser>> GetAllRoleUsersAsync(ApplicationRole role)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var result = await userManager.GetUsersInRoleAsync(role.Name!);
				if (result != null)
				{
					return result;
				}
				return new List<ApplicationUser>();
			}


		}

		public async Task<List<ApplicationRole>> GetAvailableRolesAsync(ApplicationUser user)
		{
			var availableRoles = await _roleService.GetAllRolesAsync();
			var userRoles = await GetAllUserRolesAsync(user.Id);
			foreach (var role in userRoles)
			{
				availableRoles.Remove(role);
			}
			return availableRoles;
		}

		public async Task<bool> AssignRoleToUserAsync(ApplicationUser user, ApplicationRole role)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var result = await userManager.AddToRoleAsync(user, role.Name!);
				if (result.Succeeded)
				{
					return true;
				}
				return false;
			}

		}

		public async Task<bool> RemoveRoleFromUserAsync(ApplicationUser user, ApplicationRole role)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var result = await userManager.RemoveFromRoleAsync(user, role.Name!);
				if (result.Succeeded)
				{
					return true;
				}
				return false;
			}
		}

		public async Task<bool> UserInRoleAsync(ApplicationUser user, ApplicationRole role)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var result = await userManager.IsInRoleAsync(user, role.Name!);
				if (result)
				{
					return true;
				}
				return false;
			}

		}
	}
}
