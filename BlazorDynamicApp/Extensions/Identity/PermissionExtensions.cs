using BlazorDynamicApp.Context;
using BlazorDynamicApp.Models.Permission;
using BlazorDynamicApp.PermissionBased;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;

namespace BlazorDynamicApp.Extensions.Identity
{
	public static class PermissionExtensions
	{
		public static IServiceCollection LoadPermissionExtensions(this IServiceCollection services, IConfiguration configuration, string connectionString)
		{
			var permissions = GetPermissions(connectionString);


			services.AddAuthorization(options =>
			{
				foreach (var permission in permissions)
				{
					string policyName = "Can" + $"{permission.Name}" + $"{permission.Resource}" + "Policy";

					options.AddPolicy(policyName, policy =>
						policy.Requirements.Add(
							new PermissionRequirement(permission.Name, permission.Resource)));
				}
			});

			return services;
		}

		private static List<Permission> GetPermissions(string connectionString)
		{
			var options = new DbContextOptionsBuilder<ApplicationDbContext>()
						  .UseSqlServer(connectionString)
						  .Options;
			using (var context = new ApplicationDbContext(options))
			{
				return context.Permissions.ToList();
			}
		}

	}
}
