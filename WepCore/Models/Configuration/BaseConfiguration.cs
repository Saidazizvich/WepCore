using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WepCore.Models.Entities;

namespace WepCore.Models.Configuration
{
	public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
	{
		public virtual void Configure(EntityTypeBuilder<T> builder)
		{
			builder.Property(x => x.CreatedDate).HasColumnName("Yaratilma tarihi");

		}
	}
}
