using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public class AppUserConfiguration : BaseConfiguration<AppUser>
	{
		public override void Configure(EntityTypeBuilder<AppUser> builder)
		{
			base.Configure(builder);
			builder.HasOne(x => x.AppUserProfile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(z => z.Id);
		}
	}
}
