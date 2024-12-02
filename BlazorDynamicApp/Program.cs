using BlazorDynamicApp.Context;
using BlazorDynamicApp.Data;
using BlazorDynamicApp.Models.Identity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Radzen;
using System;
using Microsoft.AspNetCore.Identity;
using BlazorDynamicApp.Services.Interfaces;
using BlazorDynamicApp.Services.Implements;
using BlazorDynamicApp.Extensions.Identity;
using Microsoft.AspNetCore.Authorization;
using BlazorDynamicApp.PermissionBased;

namespace BlazorDynamicApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseSqlServer(connectionString);
				options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			});
			builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
			options.SignIn.RequireConfirmedAccount = true)
				.AddRoles<ApplicationRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>();
			builder.Services.AddRadzenComponents();
			builder.Services.AddScoped<IUserService, UserService>();
			builder.Services.AddScoped<IRoleService, RoleService>();
			builder.Services.AddScoped<IUserRoleService, UserRoleService>();
			builder.Services.AddScoped<IRolePermissionService, RolePermissionService>();
			builder.Services.AddScoped<IUserPermissionService, UserPermissionService>();
			builder.Services.AddScoped<IPermissionService, PermissionService>();
			builder.Services.LoadPermissionExtensions(builder.Configuration, connectionString);
			builder.Services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
			//builder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler>();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}
