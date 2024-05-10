using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class AppUserProfileConfiguration : BaseConfiguration<AppUserProfile>
	{
		public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
		{
			base.Configure(builder);
		}
	}
}
