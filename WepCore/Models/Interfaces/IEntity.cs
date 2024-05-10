using WepCore.Models.Enums;

namespace WepCore.Models.Interfaces
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModefiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus DataStatus { get; set; }
    }
}
