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
                entity.HasMany(d => d.UserRewards)
                    .WithOne(p => p.Rewards)
                    .OnDelete(DeleteBehavior.ClientSetNull);
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
                entity.HasOne(d => d.Users)
                    .WithOne(p => p.UserPoints)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserRewards>(entity => {
                entity.ToTable("USER_REWARDS");

                entity.Property(e => e.UserRewardsId)
                    .IsRequired()
                    .HasColumnName("USER_REWARDS_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.UsersId)
                    .IsRequired()
                    .HasColumnName("USERS_ID");
                entity.Property(e => e.RewardsId)
                    .IsRequired()
                    .HasColumnName("REWARDS_ID");
                entity.Property(e => e.UserRewardsCreatedAt)
                    .HasColumnName("USER_REWARDS_CREATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserRewardsCreatedByUsersId)
                    .HasColumnName("USER_REWARDS_CREATED_BY_USERS_ID")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UserRewardsCreatedByUsersName)
                    .HasColumnName("USER_REWARDS_CREATED_BY_USERS_NAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UserRewardsUpdatedAt)
                    .HasColumnName("USER_REWARDS_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserRewardsUpdatedByUsersId)
                    .HasColumnName("USER_REWARDS_UPDATED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserRewardsUpdatedByUsersName)
                    .HasColumnName("USER_REWARDS_UPDATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserRewardsDeletedAt)
                    .HasColumnName("USER_REWARDS_DELETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UserRewardsDeletedByUsersId)
                    .HasColumnName("USER_REWARDS_DELETED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UserRewardsDeletedByUsersName)
                    .HasColumnName("USER_REWARDS_DELETED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.HasOne(d => d.Rewards)
                    .WithMany(p => p.UserRewards)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Users)
                    .WithMany(p => p.UserRewards)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Users>(entity => {
                entity.ToTable("USERS");

                entity.Property(e => e.UsersId)
                    .IsRequired()
                    .HasColumnName("USERS_ID")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.UsersCardNumber)
                    .IsRequired()
                    .HasColumnName("USERS_CARDS_NUMBER");
                entity.Property(e => e.UsersCardBarcodePicture)
                    .HasColumnName("USERS_CARD_BARCODE_PICTURE")
                    .IsUnicode(false)
                    .HasMaxLength(100);
                entity.Property(e => e.UsersCardExpiredAt)
                    .HasColumnName("USERS_CARD_EXPIRED")
                    .HasColumnType("datetime");
                entity.Property(e => e.UsersCardIsExpired)
                    .IsRequired()
                    .HasColumnName("USERS_CARD_IS_EXPIRED")
                    .HasColumnType("bit")
                    .ValueGeneratedOnAdd();
                entity.Property(e => e.UsersIdentityNumber)
                    .HasColumnName("USERS_IDENTITY_NUMBER")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UsersFirstname)
                    .IsRequired()
                    .HasColumnName("USERS_FIRSTNAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UsersLastname)
                    .IsRequired()
                    .HasColumnName("USERS_LASTNAME")
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UsersUsername)
                    .HasColumnName("USERS_USERNAME")
                    .IsRequired()
                    .IsUnicode(false)
                    .HasMaxLength(50);
                entity.Property(e => e.UsersPhoneNumber)
                    .HasColumnName("USERS_PHONE_NUMBER")
                    .IsUnicode(false)
                    .HasMaxLength(14);
                entity.Property(e => e.UsersEmail)
                    .HasColumnName("USERS_EMAIL")
                    .IsUnicode(false)
                    .HasMaxLength(64);
                entity.Property(e => e.UsersPassword)
                    .IsRequired()
                    .HasColumnName("USERS_PASSWORD")
                    .IsUnicode(false)
                    .HasMaxLength(64);
                entity.Property(e => e.UsersGender)
                    .HasColumnName("USERS_GENDER")
                    .IsUnicode(false)
                    .HasMaxLength(9);
                entity.Property(e => e.UsersPicture)
                    .HasColumnName("USERS_PICTURE")
                    .IsUnicode(false)
                    .HasMaxLength(100);
                entity.Property(e => e.UsersBornDate)
                    .HasColumnName("USERS_BORN_DATE")
                    .HasColumnType("datetime");
                entity.Property(e => e.UsersCreatedAt)
                    .HasColumnName("USERS_CREATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UsersCreatedByUsersId)
                    .HasColumnName("USERS_CREATED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersCreatedbyUsersName)
                    .HasColumnName("USERS_CREATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersUpdatedAt)
                    .HasColumnName("USERS_UPDATED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UsersUpdatedByUsersId)
                    .HasColumnName("USERS_UPDATED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersUpdatedByUsersName)
                    .HasColumnName("USERS_UPDATED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersDeletedAt)
                    .HasColumnName("USERS_DELETED_AT")
                    .HasColumnType("datetime");
                entity.Property(e => e.UsersDeletedByUsersId)
                    .HasColumnName("USERS_DELETED_BY_USERS_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersDeletedByUsersName)
                    .HasColumnName("USERS_DELETED_BY_USERS_NAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.UsersIsBanned)
                    .HasColumnName("USERS_IS_BANNED")
                    .HasColumnType("bit");
                entity.HasOne(d => d.UserPoints)
                    .WithOne(p => p.Users)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasMany(d => d.UserRewards)
                    .WithOne(p => p.Users)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Articles>().HasQueryFilter(p => p.ArticlesDeletedAt == null);
            modelBuilder.Entity<Promotions>().HasQueryFilter(p => p.PromotionsDeletedAt == null);
            modelBuilder.Entity<Rewards>().HasQueryFilter(p => p.RewardsDeletedAt == null);
            modelBuilder.Entity<UserPoints>().HasQueryFilter(p => p.UserPointsDeletedAt == null);
            modelBuilder.Entity<UserRewards>().HasQueryFilter(p => p.UserRewardsDeletedAt == null);
            modelBuilder.Entity<Users>().HasQueryFilter(p => p.UsersDeletedAt == null);
        }
    }
}