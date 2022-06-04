using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesAnalytics;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryAnalytics
{
    public class AnalyticsRepository : IAnalyticsRepository
    {
        private UserContext DbContext;
        public AnalyticsRepository(UserContext context)
        {
            DbContext = context;
        }


        public int count_users_in_app()
        {
            return DbContext.User.Count();
        }
    }
}
