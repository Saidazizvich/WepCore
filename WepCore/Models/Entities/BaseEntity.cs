using WepCore.Models.Enums;
using WepCore.Models.Interfaces;

namespace WepCore.Models.Entities
{
	public abstract class BaseEntity : IEntity
	{
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModefiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus DataStatus { get; set; }

        public BaseEntity()
        {
            DataStatus = DataStatus.Intersed;
            CreatedDate = DateTime.Now;
        }
    }
}
