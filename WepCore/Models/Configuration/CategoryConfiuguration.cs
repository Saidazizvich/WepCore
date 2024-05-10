using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class CategoryConfiuguration : BaseConfiguration<Category>
	{
		public override void Configure(EntityTypeBuilder<Category> builder)
		{
			base.Configure(builder);
		}
	}
}
