using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class ProductConfiguration : BaseConfiguration<Product>
	{
		public override void Configure(EntityTypeBuilder<Product> builder)
		{
			base.Configure(builder);
			builder.Property(x => x.UnitPrice).HasColumnType("money");

		}
	}
}
