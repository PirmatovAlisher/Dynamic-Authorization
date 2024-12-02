using BlazorDynamicApp.Models.Identity;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IUserRoleService
	{
		Task<bool> AssignRoleToUserAsync(ApplicationUser user, ApplicationRole role);
		Task<IList<ApplicationUser>> GetAllRoleUsersAsync(ApplicationRole role);
		Task<List<ApplicationRole>> GetAllUserRolesAsync(string userId);
		Task<List<ApplicationRole>> GetAvailableRolesAsync(ApplicationUser user);
		Task<bool> RemoveRoleFromUserAsync(ApplicationUser user, ApplicationRole role);
		Task<bool> UserInRoleAsync(ApplicationUser user, ApplicationRole role);
	}
}