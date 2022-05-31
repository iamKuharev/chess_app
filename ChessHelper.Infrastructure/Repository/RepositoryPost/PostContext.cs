using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChessHelper.Domain.Entities.EntitiesPost;
using Microsoft.EntityFrameworkCore;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class PostContext : DbContext
    {
        public DbSet<ChessPlayer> chessplayers { get; set; }

        public PostContext(DbContextOptions<PostContext> options)
            : base(options)
        {

        }

/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasDefaultSchema("public");
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties().Configure
    (c => c.HasColumnName(c.ClrPropertyInfo.Name.ToUpper()));
        }*/
    }

}
