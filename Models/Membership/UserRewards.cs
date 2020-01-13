using System;

namespace membership_api.Models
{
    public partial class UserRewards
    {
        public int UserRewardsId { get; set; }
        public int UsersId { get; set; }
        public int RewardsId { get; set; }
        public DateTime UserRewardsCreatedAt { get; set; }
        public String UserRewardsCreatedByUsersId { get; set; }
        public String UserRewardsCreatedByUsersName { get; set; }
        public DateTime UserRewardsUpdatedAt { get; set; }
        public String UserRewardsUpdatedByUsersId { get; set; }
        public String UserRewardsUpdatedByUsersName { get; set; }
        public DateTime? UserRewardsDeletedAt { get; set; }
        public String UserRewardsDeletedByUsersId { get; set; }
        public String UserRewardsDeletedByUsersName { get; set; }

        public virtual Users Users { get; set; }
        public virtual Rewards Rewards { get; set; }
    }
}