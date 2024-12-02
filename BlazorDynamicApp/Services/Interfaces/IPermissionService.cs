using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IPermissionService
	{
		Task<bool> HasPermissionAsync(ApplicationUser user, string permissionName, ResourceType resourceType);
	}
}