using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IUserPermissionService
	{
		Task<bool> AssignPermissionToUserAsync(ApplicationUser user, Permission permission);
		Task<bool> HasPermissionAsync(ApplicationUser user, Permission permission);
		Task<bool> RemovePermissionFromUserAsync(ApplicationUser user, Permission permission);
		Task<bool> UserHasPermissionAsync(ApplicationUser user, Permission permission);
		Task<bool> UserRolesHasPermissionAsync(ApplicationUser user, Permission permission);
	}
}