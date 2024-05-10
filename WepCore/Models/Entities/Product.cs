namespace WepCore.Models.Entities
{
	public class Product : BaseEntity
	{
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        // baglanti
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
