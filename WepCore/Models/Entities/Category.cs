namespace WepCore.Models.Entities
{
	public class Category : BaseEntity
	{
        public string CategoryName { get; set; }
        public string Descripation { get; set; }

        // baglanti

        public virtual List<Product> Products { get; set; }
    }
}
