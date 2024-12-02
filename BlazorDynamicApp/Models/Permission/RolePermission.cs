using BlazorDynamicApp.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace BlazorDynamicApp.Models.Permission
{
	public class RolePermission
	{
		public int Id { get; set; }

		public string RoleId { get; set; }
		public ApplicationRole Role { get; set; }

		public int PermissionId { get; set; }
		public Permission Permission { get; set; }
	}
}
