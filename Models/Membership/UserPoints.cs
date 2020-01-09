using System;

namespace membership_api
{
    public partial class UserPoints
    {
        public int UserPointsId { get; set; }
        public int UsersId { get; set; }
        public int UserPointsCredit { get; set; }
        public int UserPointsDebet { get; set; }
        public int UserPointsBalance { get; set; }
        public DateTime UserPointsCreatedAt { get; set; }
        public String UserPointsCreatedByUsersId { get; set; }
        public String UserPointsCreatedByUsersName { get; set; }
        public DateTime UserPointsUpdatedAt { get; set; }
        public String UserPointsUpdatedByUsersId { get; set; }
        public String UserPointsUpdatedByUsersName { get; set; }
        public DateTime? UserPointsDeletedAt { get; set; }
        public String UserPointsDeletedByUsersId { get; set; }
        public String UserPointsDeletedByUsersName { get; set; }
    }
}