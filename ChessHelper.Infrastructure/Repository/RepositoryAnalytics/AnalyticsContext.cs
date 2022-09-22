using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ChessHelper.Domain.Entities.Analytics;
using ChessHelper.Domain.Entities.EntitiesPost;
using Microsoft.EntityFrameworkCore;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class AnalyticsContext : DbContext
    {
        public DbSet<Analytics> Analytics { get; set; }

        public AnalyticsContext(DbContextOptions<PostContext> options)
            : base(options)
        {

        }
    }

}
