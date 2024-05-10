namespace WepCore.Models.Entities
{
	public class Order : BaseEntity
	{
        public string ShippedAddress { get; set; }

        public int? UserId { get; set; }

        // baglanti
        public virtual AppUser AppUser { get; set; }
		public virtual List<OrderDetail> OrderDetails  { get; set; }


    }
}
