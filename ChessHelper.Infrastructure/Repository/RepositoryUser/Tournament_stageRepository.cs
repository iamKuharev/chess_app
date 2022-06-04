using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryUser
{
    public class Tournament_stageRepository : DbConRepository, ITournament_stageRepository
    {
        public Tournament_stageRepository(UserContext context) : base(context)
        {
        }

        public async Task<bool> AddTournament_stageAsync(Tournament_stage tournament_stage)
        {
            try
            {
                await DbContext.Tournament_stage.AddAsync(tournament_stage);
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

        public async Task<bool> DeleteTournament_stageAsync(int id)
        {
            Tournament_stage tournament_stage = DbContext.Tournament_stage.FirstOrDefault(p => p.Id == id);
            if (tournament_stage != null)
            {
                try
                {
                    DbContext.Tournament_stage.Remove(tournament_stage);
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

        public IList<Tournament_stage> GetAllTournament_stage()
        {
            return DbContext.Tournament_stage.Include(t => t.Tournament).ToList();
        }

        public Tournament_stage GetTournament_stage(int id)
        {
            return DbContext.Tournament_stage.Include(t => t.Tournament).FirstOrDefault(x => x.Id == id);
        }

        public async Task<bool> UpdateTournament_stageAsync(Tournament_stage tournament_stage)
        {
            try
            {
                DbContext.Tournament_stage.Update(tournament_stage);
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
