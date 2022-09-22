﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChessHelper.Domain.Entities.EntitiesPost;
using Microsoft.EntityFrameworkCore;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class PostContext : DbContext
    {
        public DbSet<ChessPlayer> ChessPlayers { get; set; }
        public DbSet<HistoricalParty> HistoricalParties { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Theory> Theories { get; set; }
        public DbSet<TypeTheory> TypeTheories { get; set; }
        public DbSet<VideoLesson> VideoLessons { get; set; }

        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {

        }
    }

}
