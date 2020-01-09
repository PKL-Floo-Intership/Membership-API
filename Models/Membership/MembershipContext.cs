using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace membership_api.Models
{
    public partial class MembershipContext : DbContext
    {
        public MembershipContext(){}

        public MembershipContext(DbContextOptions<MembershipContext> options)
            :base(options){}

        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<Promotions> Promotions { get; set; }
        public virtual DbSet<Rewards> Rewards { get; set; }
        public virtual DbSet<UserPoints> UserPoints { get; set; }
        public virtual DbSet<UserRewards> UserRewards { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        
    }
}