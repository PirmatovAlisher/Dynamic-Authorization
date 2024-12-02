using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Models.Permission;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IRolePermissionService
	{
		Task<bool> AddPermissionToRoleAsync(ApplicationRole role, Permission permission);
		Task<List<Permission>> GetAllPermissionAsync();
		Task<List<Permission>> GetAvailablePermissionsAsync(string roleId);
		Task<Permission> GetPermissionByIdAsync(int Id);
		Task<RolePermission> GetRolePermissionAsync(string roleId, int permissionId);
		Task<List<RolePermission>> GetRolePermissionsAsync(string roleId);
		Task<bool> RemovePermissionFromRoleAsync(ApplicationRole role, Permission permission);
		Task<bool> RoleHasPermissionAsync(ApplicationRole role, Permission permission);

	}
}