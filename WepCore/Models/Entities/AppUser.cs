namespace WepCore.Models.Entities
{
	public class AppUser : BaseEntity
	{
        public string UserName { get; set; }
        public string Password { get; set; }

        //baglanti

        public virtual AppUserProfile AppUserProfile { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
