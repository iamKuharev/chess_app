using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class HistoricalPartyRepository : IHistoricalPartyRepository
    {
        private PostContext DbContext;
        public HistoricalPartyRepository(PostContext context)
        {
            DbContext = context;
        }

        public async Task<bool> AddHistoricalParty(HistoricalParty historicalParty)
        {
            try
            {
                await DbContext.HistoricalParties.AddAsync(historicalParty);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<bool> UpdateHistoricalParty(HistoricalParty historicalParty)
        {
            try
            {
                DbContext.HistoricalParties.Update(historicalParty);
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

        public async Task<bool> DeleteHistoricalParty(int id)
        {
            HistoricalParty user = DbContext.HistoricalParties.FirstOrDefault(p => p.Id == id);
            if (user != null)
            {
                try
                {
                    DbContext.HistoricalParties.Remove(user);
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

        public IList<HistoricalParty> GetAllHistoricalParty()
        {
            return DbContext.HistoricalParties.ToList();
        }

        public HistoricalParty GetHistoricalParty(int id)
        {
            return DbContext.HistoricalParties.FirstOrDefault(x => x.Id == id);
        }
    }
}
