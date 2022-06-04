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
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Tournament_stage> Tournament_Stages { get; set; }
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) 
            : base(options)
        {

        }
    }
}
