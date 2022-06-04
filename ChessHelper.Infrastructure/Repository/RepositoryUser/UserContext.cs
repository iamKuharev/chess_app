using System;
using System.Collections.Generic;
using System.Text;
using ChessHelper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class UserContext : DbContext
    {
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Avatar> Avatars { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Tournament> Tournament { get; set; }
        public DbSet<Tournament_stage> Tournament_stage { get; set; }
        public DbSet<User> User { get; set; }

        public UserContext(DbContextOptions<UserContext> options) 
            : base(options)
        {

        }
    }
}
