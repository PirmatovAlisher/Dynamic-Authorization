using BlazorDynamicApp.Models.WebApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlazorDynamicApp.Configurations.WebApp
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData(
				new Product
				{
					Id = 1,
					Name = "Pumpkin",
					Description = "Sweet one",
					Price = 9990
				}, new Product
				{
					Id = 2,
					Name = "Tomato",
					Description = "Juicy tomato",
					Price = 5990
				}
				, new Product
				{
					Id = 3,
					Name = "Coca-Cola",
					Description = "Zero sugar",
					Price = 12990
				}
				, new Product
				{
					Id = 4,
					Name = "Orange",
					Description = "From Vietnam",
					Price = 7190
				}
				, new Product
				{
					Id = 5,
					Name = "Cucumber",
					Description = "Small one",
					Price = 3990
				}
				, new Product
				{
					Id = 6,
					Name = "Pear",
					Description = "Green one",
					Price = 5990
				}
				, new Product
				{
					Id = 7,
					Name = "Peach",
					Description = "Double peach",
					Price = 7790
				}
				);
		}
	}
}
