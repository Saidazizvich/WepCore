using Microsoft.AspNetCore.Identity;
using WepCore.Models.Enums;
using WepCore.Models.Interfaces;

namespace WepCore.Models.Entities
{
    public class AppUserRole : IdentityUserRole<int>, IEntity
    {
        public AppUserRole()
        {
            CreatedDate = DateTime.Now;
            DataStatus = DataStatus.Intersed;
        }

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }   
        public DateTime? ModefiedDate {get; set; }
        public DateTime? DeletedDate { get; set; }  
        public DataStatus DataStatus { get; set; }

        // baglanti


    }
}
