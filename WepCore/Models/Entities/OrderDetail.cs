namespace WepCore.Models.Entities
{
	public class OrderDetail : BaseEntity
	{
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        // baglanti

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
