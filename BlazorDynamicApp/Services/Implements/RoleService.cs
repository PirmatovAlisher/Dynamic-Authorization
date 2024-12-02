using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace BlazorDynamicApp.Services.Implements
{
	public class RoleService : IRoleService
	{
		private readonly RoleManager<ApplicationRole> _roleManager;

		public RoleService(RoleManager<ApplicationRole> roleManager)
		{
			_roleManager = roleManager;
		}

		public async Task<List<ApplicationRole>> GetAllRolesAsync()
		{
			var result = await _roleManager.Roles.ToListAsync();
			if (result.Any())
			{
				return result;
			}
			return new List<ApplicationRole>();
		}

		public async Task<ApplicationRole> GetRoleByIdAsync(string Id)
		{
			var result = await _roleManager.FindByIdAsync(Id);
			if (result != null)
			{
				return result;
			}
			else
			{
				return new ApplicationRole();
			}
		}

		public async Task<Tuple<bool, string?>> CreateRoleAsync(ApplicationRole role)
		{
			try
			{
				if (!role.Name.Trim().IsNullOrEmpty())
				{
					var roleExists = await _roleManager.RoleExistsAsync(role.Name!);

					if (!roleExists)
					{
						var result = await _roleManager.CreateAsync(role);
						if (result.Succeeded)
						{
							return new Tuple<bool, string?>(true, "");
						}
						else
						{
							return new Tuple<bool, string?>(false, $"{result.Errors}");
						}
					}
					return new Tuple<bool, string?>(false, "Role already exists!");
				}
				return new Tuple<bool, string?>(false, "Occur an error while creating the role!");
			}
			catch (Exception ex)
			{
				return new Tuple<bool, string?>(false, ex.Message);
			}
		}

		public async Task<bool> DeleteRoleAsync(ApplicationRole role)
		{
			var result = await _roleManager.DeleteAsync(role);
			if (result.Succeeded)
			{
				return true;
			}
			return false;
		}

		public async Task<bool> UpdateRoleAsync(ApplicationRole role)
		{
			if (role != null)
			{
				var result = await _roleManager.UpdateAsync(role);
				if (result.Succeeded)
				{
					return true;
				}
				return false;
			}
			else
			{
				return false;
			}

		}
	}
}
