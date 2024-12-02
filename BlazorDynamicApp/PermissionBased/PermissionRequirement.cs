using Microsoft.AspNetCore.Authorization;
using System.Security.AccessControl;

namespace BlazorDynamicApp.PermissionBased
{
	public class PermissionRequirement : IAuthorizationRequirement
	{
		public PermissionRequirement(string permissionName, Models.Permission.ResourceType resourceType)
		{
			PermissionName = permissionName;
			ResourceType = resourceType;
		}

		public string PermissionName { get; }
		public Models.Permission.ResourceType ResourceType { get; }
	}
}
