using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace membership_api.Models
{
    public enum UsersGender
        {
            Pria, Perempuan
        }
    public partial class Users
    {

        public Users()
        {
            UserRewards = new HashSet<UserRewards>();
        }
        public int UsersId { get; set;}
        public int UsersCardNumber { get; set; }
        public String UsersCardBarcode { get; set; }
        public DateTime UsersCardExpiredAt { get; set; }
        public bool UsersCardIsExpired { get; set; }
        public String UsersIdentityNumber { get; set; }
        public String UsersFirstname { get; set; }
        public String UsersLastname { get; set; }
        public String UsersUsername { get; set; }
        public String UsersPhoneNumber { get; set; }
        public String UsersEmail { get; set; }
        [JsonIgnore]
        public String UsersPassword { get; set; }
        private String UsersPasswordAlternateSetter
        {
            set { UsersPassword = value; }
        }
        public UsersGender? UsersGender { get; set; }
        public String UsersPicture { get; set; }
        public DateTime UsersBornDate { get; set; }
        public DateTime UsersCreatedAt { get; set; }
        public String UsersCreatedByUsersId { get; set; }
        public String UsersCreatedbyUsersName { get; set; }
        public DateTime UsersUpdatedAt { get; set; }
        public String UsersUpdatedByUsersId { get; set; }
        public String UsersUpdatedByUsersName { get; set; }
        public DateTime? UsersDeletedAt { get; set; }
        public String UsersDeletedByUsersId { get; set; }
        public String UsersDeletedByUsersName { get; set; }
        public bool UsersIsBanned { get; set; }

        public virtual UserPoints UserPoints { get; set; }
        public virtual ICollection<UserRewards> UserRewards { get; set; }
    }
}