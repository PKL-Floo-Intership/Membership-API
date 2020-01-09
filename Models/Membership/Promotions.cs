using System;

namespace membership_api.Models
{
    public partial class Promotions
    {
        public int PromotionsId { get; set; }
        public String PromotionsTitle { get; set; }
        public String PromotionsDescription { get; set; }
        public String PromotionsIcon { get; set; }
        public DateTime PromotionsExpiredAt { get; set; }
        public DateTime PromotionsCreatedAt { get; set; }
        public String PromotionsCreatedByUsersId { get; set; }
        public String PromotionsCreatedByUsersName { get; set; }
        public DateTime PromotionsUpdatedAt { get; set; }
        public String PromotionsUpdatedByUsersId { get; set; }
        public String PromotionsUpdatedByUsersName { get; set; }
        public DateTime? PromotionsDeletedAt { get; set; }
        public String PromotionsDeletedByUsersId { get; set; }
        public String PromotionsDeletedByUsersName { get; set; }
        public Boolean PromotionsIsActive { get; set; }
        
    }
}