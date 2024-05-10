using Microsoft.EntityFrameworkCore;
using WepCore.Models.Configuration;
using WepCore.Models.Entities;

namespace WepCore.Models.Context
{
	public class CoreContext : DbContext
	{
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {
            
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppUserConfiguration());
			modelBuilder.ApplyConfiguration(new AppUserProfileConfiguration());
			modelBuilder.ApplyConfiguration(new ProductConfiguration());
			modelBuilder.ApplyConfiguration(new CategoryConfiuguration());
			modelBuilder.ApplyConfiguration(new OrderConfiguration());
			modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
		}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles  { get; set; }
        public DbSet<Order> Orders  { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products  { get; set; }
        public DbSet<Category> Categories  { get; set; }
    }
}
