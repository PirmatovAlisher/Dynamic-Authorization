using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlazorDynamicApp.Services.Implements
{
	public class UserService : IUserService
	{
		protected readonly UserManager<ApplicationUser> _userManager;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public UserService(UserManager<ApplicationUser> userManager, IServiceScopeFactory serviceScopeFactory)
		{
			_userManager = userManager;
			_serviceScopeFactory = serviceScopeFactory;
		}

		public async Task<List<ApplicationUser>> GetAllUserListAsync()
		{
			var result = await _userManager.Users.ToListAsync();
			if (result.Any())
			{
				return result;
			}

			else
			{
				return new List<ApplicationUser>();
			}
		}

		public async Task<ApplicationUser> GetUserByIdAsync(string Id)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var result = await userManager.FindByIdAsync(Id);
				if (result != null)
				{
					return result;
				}
				else
				{
					return new ApplicationUser();
				}
			}

		}

		public async Task CreateUserAsync(ApplicationUser user)
		{
			var result = await _userManager.CreateAsync(user);
		}

		public async Task<bool> DeleteUserAsync(ApplicationUser user)
		{
			var result = await _userManager.DeleteAsync(user);
			if (result.Succeeded)
			{
				return true;
			}
			return false;
		}
	}
}
