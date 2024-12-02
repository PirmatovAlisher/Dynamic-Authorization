using BlazorDynamicApp.Models.Identity;

namespace BlazorDynamicApp.Services.Interfaces
{
	public interface IRoleService
	{
		Task<Tuple<bool, string?>> CreateRoleAsync(ApplicationRole role);
		Task<bool> DeleteRoleAsync(ApplicationRole role);
		Task<List<ApplicationRole>> GetAllRolesAsync();
		Task<ApplicationRole> GetRoleByIdAsync(string Id);
		Task<bool> UpdateRoleAsync(ApplicationRole role);
	}
}