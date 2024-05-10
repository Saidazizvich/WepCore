using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class OrderConfiguration :BaseConfiguration<Order>
	{
		public override void Configure(EntityTypeBuilder<Order> builder)
		{
			base.Configure(builder);
		}
	}
}
