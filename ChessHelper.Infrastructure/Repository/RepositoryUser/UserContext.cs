using System;
using System.Collections.Generic;
using System.Text;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.EntityFrameworkCore;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class UserContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Tournament_stage> Tournament_Stages { get; set; }
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //  .HasMany(u => u.Achievements)
            //  .WithMany(a => a.Users);

            /*            modelBuilder.Entity<User>()
                       .HasMany(c => c.Achievements)
                       .WithMany(p => p.Users)
                       .UsingEntity( j => j.ToTable("user-achievement"));*/
/*
            modelBuilder.Entity<User>()
              .HasMany(u => u.Achievements)
              .WithMany(a => a.Users)
                .UsingEntity<UserAchievement>(
                    j => j
                    .HasOne(pt => pt.User)
                    .WithMany(t => t.UserAchievements)
                    .HasForeignKey(pt => pt.UserId),
                j => j
                    .HasOne(pt => pt.Achievement)
                    .WithMany(p => p.UserAchievements)
                    .HasForeignKey(pt => pt.AchievementId),
                j =>
                {
                    j.HasKey(t => new { t.UserId, t.AchievementId });
                    j.ToTable("Enrollments");
                });

*/

        }
    }
}
