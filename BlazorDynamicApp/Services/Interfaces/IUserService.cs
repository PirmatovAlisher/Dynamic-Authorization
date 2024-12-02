using BlazorDynamicApp.Models.Identity;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IUserService
	{
		Task<List<ApplicationUser>> GetAllUserListAsync();
		Task<ApplicationUser> GetUserByIdAsync(string Id);
		Task CreateUserAsync(ApplicationUser user);
		Task<bool> DeleteUserAsync(ApplicationUser user);

	}
}
