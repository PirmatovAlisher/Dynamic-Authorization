using BlazorDynamicApp.Models.Identity;
using BlazorDynamicApp.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace BlazorDynamicApp.PermissionBased
{
	public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IServiceScopeFactory _serviceScopeFactory;

		public PermissionAuthorizationHandler(IServiceScopeFactory serviceScopeFactory, IServiceProvider serviceProvider)
		{
			_serviceScopeFactory = serviceScopeFactory;
			_serviceProvider = serviceProvider;
		}

		protected override async Task<Task> HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
		{
			var user = GetUserViaUserManager(context);

			var result = await PermissionCheck(context, requirement);

			if (result)
				context.Succeed(requirement);

			return Task.CompletedTask;
		}

		private ApplicationUser GetUserViaUserManager(AuthorizationHandlerContext context)
		{
			using (var scope = _serviceScopeFactory.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
				var user = userManager.FindByNameAsync(context.User.Identity.Name).Result;
				return user;
			}
		}

		private Task<bool> PermissionCheck(AuthorizationHandlerContext context, PermissionRequirement requirement)
		{
			var user = GetUserViaUserManager(context);

			using (var scope = _serviceProvider.CreateScope())
			{
				var permissionService = scope.ServiceProvider.GetRequiredService<IPermissionService>();
				var result = permissionService
					.HasPermissionAsync(user, requirement.PermissionName, (Models.Permission.ResourceType)requirement.ResourceType);
				return result;
			}
		}
	}
}
