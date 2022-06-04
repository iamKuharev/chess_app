using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class RankRepository : DbConRepository, IRankRepository
    {
        public RankRepository(UserContext context) : base(context)
        {
        }

        public IList<Rank> GetAllRanks()
        {
            return DbContext.Ranks.ToList();
        }

        public Rank GetRank(int id)
        {
            return DbContext.Ranks.FirstOrDefault();
        }

        public Task<bool> AddRankAsync(Rank rank)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRankAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateRankAsync(Rank rank)
        {
            throw new NotImplementedException();
        }
    }
}
