using System;
using System.Collections.Generic;

namespace membership_api.Models
{
    public partial class Rewards
    {
        public Rewards()
        {
            UserRewards = new HashSet<UserRewards>();
        }
        public int RewardsId { get; set; }
        public String RewardsName { get; set; }
        public String RewardsDescription { get; set; }
        public String RewardsIcon { get; set; }
        public DateTime RewardsCreatedAt { get; set; }
        public String RewardsCreatedByUsersId { get; set; }
        public String RewardsCreatedByUsersName { get; set; }
        public DateTime RewardsUpdatedAt { get; set; }
        public String RewardsUpdatedByUsersId { get; set; }
        public String RewardsUpdatedByUsersName { get; set; }
        public DateTime? RewardsDeletedAt { get; set; }
        public String RewardsDeletedByUsersId { get; set; }
        public String RewardsDeletedByUsersName { get; set; }
        public bool RewardsIsActive { get; set; }

        public virtual ICollection<UserRewards> UserRewards { get; set; }
    }
}