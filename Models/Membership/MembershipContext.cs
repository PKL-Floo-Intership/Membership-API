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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=FAUZANAR-PC,FAUZAN;Database=membership_floo;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.HasAnnotation("ProductVersion","2.2.6-servicing-10079");
            modelBuilder.Entity<Articles>(entity =>
            {
                entity.ToTable("ARTICLES");

                entity.Property(e => e.ArticlesId)
                    .IsRequired()
                    .HasColumnName("ARTICLES_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.ArticlesTitle)
                    .IsRequired()
                    .HasColumnName("ARTICLES_TITLE")
                    .IsUnicode(false)
                    .HasMaxLength(16);
                entity.Property(e => e.ArticlesContent)
                    .IsRequired()
                    .HasColumnName("ARTICLES_CONTENT")
                    .HasColumnType("text");
                entity.Property(e => e.ArticlesAuthorName)
                    .IsRequired()
                    .HasColumnName("ARTICLES_AUTHOR_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(15);
                entity.Property(e => e.ArticlesCreatedAt)
                    .HasColumnName("ARTICLES_CREATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.ArticlesCreatedByUsersId)
                    .HasColumnName("ARTICLES_CREATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.ArticlesCreatedByUsersName)
                    .HasColumnName("ARTICLES_CREATED_BY_USERS_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.ArticlesUpdatedAt)
                    .HasColumnName("ARTICLES_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.ArticlesUpdatedByUsersId)
                    .HasColumnName("ARTICLES_UPDATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.ArticlesUpdatedByUsersName)
                    .HasColumnName("ARTICLES_UPDATED_BY_USERS_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.ArticlesDeletedAt)
                    .HasColumnName("ARTICLES_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.ArticlesDeletedByUsersId)
                    .HasColumnName("ARTICLES_DELETED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.ArticlesDeletedByUsersName)
                    .HasColumnName("ARTICLES_DELETED_BY_USERS_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Promotions>(entity => 
            {
                entity.ToTable("PROMOTIONS");

                entity.Property(e => e.PromotionsId)
                    .IsRequired()
                    .HasColumnName("PROMOTIONS_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.PromotionsTitle)
                    .IsRequired()
                    .HasColumnName("PROMOTIONS_TITLE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsDescription)
                    .IsRequired()
                    .HasColumnName("PROMOTIONS_DESCRIPTION")
                    .HasMaxLength(255)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsIcon)
                    .HasColumnName("PROMOTIONS_ICON")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsExpiredAt)
                    .HasColumnName("PROMOTIONS_EXPIRED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.PromotionsCreatedAt)
                    .HasColumnName("PROMOTIONS_CRETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.PromotionsCreatedByUsersId)
                    .HasColumnName("PROMOTIONS_CREATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.PromotionsCreatedByUsersName)
                    .HasColumnName("PROMOTIONS_CREATED_BY_USERS_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.PromotionsUpdatedAt)
                    .HasColumnName("PROMOTIONS_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.PromotionsUpdatedByUsersId)
                    .HasColumnName("PROMOTIONS_UPDATED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsUpdatedByUsersName)
                    .HasColumnName("PROMOTIONS_UPDATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsDeletedAt)
                    .HasColumnName("PROMOTIONS_DELETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.PromotionsDeletedByUsersId)
                    .HasColumnName("PROMOTIONS_DELETED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsDeletedByUsersName)
                    .HasMaxLength(50)
                    .HasColumnName("PROMOTIONS_DELETED_BY_USERS_NAME")
                    .IsUnicode(false);
                entity.Property(e => e.PromotionsIsActive)
                    .HasColumnName("PROMOTIONS_IS_ACTIVE")
                    .HasColumnType("bit");
            });

            modelBuilder.Entity<Rewards>(entity => {
                entity.ToTable("REWARDS");

                entity.Property(e => e.RewardsId)
                    .IsRequired()
                    .HasColumnName("REWARDS_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.RewardsName)
                    .IsRequired()
                    .HasColumnName("REWARDS_NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.RewardsDescription)
                    .HasColumnName("REWARDS_DESCRIPTION")
                    .HasColumnType("text");
                entity.Property(e => e.RewardsIcon)
                    .HasColumnName("REWARDS_ICON")
                    .IsUnicode(false)
                    .HasMaxLength(100);
                entity.Property(e => e.RewardsCreatedAt)
                    .HasColumnName("REWARDS_CREATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.RewardsCreatedByUsersId)
                    .HasColumnName("REWARDS_CREATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.RewardsCreatedByUsersName)
                    .HasColumnName("REWARDS_CREATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.RewardsUpdatedAt)
                    .HasColumnName("REWARDS_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.RewardsUpdatedByUsersId)
                    .HasColumnName("REWARDS_UPDATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.RewardsUpdatedByUsersName)
                    .HasColumnName("REWARDS_UPDATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.RewardsDeletedAt)
                    .HasColumnName("REWARDS_DELETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.RewardsDeletedByUsersId)
                    .HasColumnName("REWARDS_DELETED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.RewardsDeletedByUsersName)
                    .HasColumnName("REWARDS_DELETED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.RewardsIsActive)
                    .HasColumnName("REWARDS_IS_ACTIVE")
                    .HasColumnType("bit");
            });

            modelBuilder.Entity<UserPoints> (entity => {
                entity.ToTable("USER_POINTS");

                entity.Property(e => e.UserPointsId)
                    .IsRequired()
                    .HasColumnName("USER_POINTS_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.UsersId)
                    .IsRequired()
                    .HasColumnName("USERS_ID");
                entity.Property(e => e.UserPointsCredit)
                    .HasColumnName("USER_POINTS_CREDIT");
                entity.Property(e => e.UserPointsDebet)
                    .HasColumnName("USER_POINTS_DEBET");
                entity.Property(e => e.UserPointsBalance)
                    .HasColumnName("USER_POINTS_BALANCE");
                entity.Property(e => e.UserPointsCreatedAt)
                    .HasColumnName("USER_POINTS_CREATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserPointsCreatedByUsersId)
                    .HasColumnName("USER_POINTS_CREATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UserPointsCreatedByUsersName)
                    .HasColumnName("USER_POINTS_CREATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserPointsUpdatedAt)
                    .HasColumnName("USER_POINTS_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserPointsUpdatedByUsersId)
                    .HasColumnName("USER_POINTS_UPDATED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserPointsUpdatedByUsersName)
                    .HasColumnName("USER_POINTS_UPDATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserPointsDeletedAt)
                    .HasColumnName("USER_POINTS_DELETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserPointsDeletedByUsersId)
                    .HasColumnName("USER_POINTS_DELETED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserPointsDeletedByUsersName)
                    .HasColumnName("USER_POINTS_DELETED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}