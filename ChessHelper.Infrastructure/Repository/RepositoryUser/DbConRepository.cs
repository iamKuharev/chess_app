using System;
using System.Collections.Generic;
using System.Text;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class DbConRepository
    {
        protected readonly UserContext DbContext;

        public DbConRepository(UserContext context)
        {
            DbContext = context;
        }
    }
}
