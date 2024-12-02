using BlazorDynamicApp.Models.WebApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.WebApp
{
	public class EmployeeConfig : IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee> builder)
		{
			builder.HasData(
				new Employee
				{
					Id = 1,
					Name = "Arjun",
					Department = "DMA",
					PhoneNumber = "+998943619925",
					DateOfBirth = new DateTime(1994, 01, 04),
					Age = 31
				},
				new Employee
				{
					Id = 2,
					Name = "Satya",
					Department = "Welding FD",
					PhoneNumber = "+998943568941",
					DateOfBirth = new DateTime(1983, 09, 12),
					Age = 42
				},
				new Employee
				{
					Id = 3,
					Name = "Prashant",
					Department = "LCS",
					PhoneNumber = "+998939784578",
					DateOfBirth = new DateTime(1979, 06, 21),
					Age = 46
				},
				new Employee
				{
					Id = 4,
					Name = "Test4",
					Department = "LCS",
					PhoneNumber = "+998939784578",
					DateOfBirth = new DateTime(1979, 06, 21),
					Age = 56
				},
				new Employee
				{
					Id = 5,
					Name = "Test5",
					Department = "LCS",
					PhoneNumber = "+998939784578",
					DateOfBirth = new DateTime(1979, 06, 21),
					Age = 22
				},
				new Employee
				{
					Id = 6,
					Name = "Test6",
					Department = "LCS",
					PhoneNumber = "+998939784578",
					DateOfBirth = new DateTime(1979, 06, 21),
					Age = 26
				},
				new Employee
				{
					Id = 7,
					Name = "Test7",
					Department = "LCS",
					PhoneNumber = "+998939784578",
					DateOfBirth = new DateTime(1979, 06, 21),
					Age = 31
				}
				);
		}
	}
}
