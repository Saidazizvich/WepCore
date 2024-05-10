using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
	{
		public override void Configure(EntityTypeBuilder<OrderDetail> builder)
		{
			base.Configure(builder);
			builder.Ignore(z => z.OrderId);
			builder.HasKey(v => new
			{
				v.OrderId,	
				v.ProductId
			});

		}
	}
}
