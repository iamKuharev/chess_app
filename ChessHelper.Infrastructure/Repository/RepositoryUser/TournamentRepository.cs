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
    public class TournamentRepository : DbConRepository, ITournamentRepository
    {
        public TournamentRepository(UserContext context) : base(context)
        {
        }

        public async Task<bool> AddTournamentAsync(Tournament tournament)
        {
            try
            {
                await DbContext.Tournaments.AddAsync(tournament);
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

        public async Task<bool> DeleteTournamentAsync(int id)
        {
            Tournament tournament = DbContext.Tournaments.FirstOrDefault(p => p.Id == id);
            if (tournament != null)
            {
                try
                {
                    DbContext.Tournaments.Remove(tournament);
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

        public IList<Tournament> GetAllTournament()
        {
            return DbContext.Tournaments.ToList();
        }

        public Tournament GetTournament(int id)
        {
            return DbContext.Tournaments.FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateTournamentAsync(Tournament tournament)
        {
            try
            {
                DbContext.Tournaments.Update(tournament);
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
