using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return DbContext.Ranks.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> AddRankAsync(Rank rank)
        {
            try
            {
                await DbContext.Ranks.AddAsync(rank);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;
            }

        }

        public async Task<bool> DeleteRankAsync(int id)
        {
            Rank rank = DbContext.Ranks.FirstOrDefault(p => p.Id == id);
            if (rank != null)
            {
                try
                {
                    DbContext.Ranks.Remove(rank);
                    await DbContext.SaveChangesAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                    Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateRankAsync(Rank rank)
        {
            try
            {
                DbContext.Ranks.Update(rank);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;
            }
        }
    }
}
