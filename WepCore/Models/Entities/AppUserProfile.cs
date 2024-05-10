namespace WepCore.Models.Entities
{
	public class AppUserProfile : BaseEntity
	{
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // baglanti ozelikler

        public virtual AppUser AppUser { get; set; }
    }
}
