using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace membership_api.Models
{
    public partial class Articles
    {
         public int ArticlesId { get; set; }
         public String ArticlesTitle { get; set; }
         public String ArticlesContent { get; set; }
         public String ArticlesAuthorName { get; set; }
         public DateTime ArticlesCreatedAt { get; set; }
         public String ArticlesCreatedByUsersId { get; set; }
         public String ArticlesCreatedByUsersName { get; set; }
         public DateTime ArticlesUpdatedAt { get; set; }
         public String ArticlesUpdatedByUsersId { get; set; }
         public String ArticlesUpdatedByUsersName { get; set; }
         public DateTime? ArticlesDeletedAt { get; set; }
         public String ArticlesDeletedByUsersId { get; set; }
         public String ArticlesDeletedByUsersName { get; set; }
         
    }
}