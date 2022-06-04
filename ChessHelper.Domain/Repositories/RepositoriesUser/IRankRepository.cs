using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface IRankRepository
    {
        Rank GetRank(int id);

        IList<Rank> GetAllRanks();

        Task<bool> AddRankAsync(Rank rank);

        Task<bool> UpdateRankAsync(Rank rank);

        Task<bool> DeleteRankAsync(int id);
    }
}
