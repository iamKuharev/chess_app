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
    public class AchievementRepository : IAchievementRepository
    {
        private readonly UserContext DbContext;

        public AchievementRepository(UserContext context)
        {
            DbContext = context;
        }

        public Achievement GetAchievement(int id)
        {
            return DbContext.Achievements.FirstOrDefault(p => p.Id == id);
        }

        public IList<Achievement> GetAllAchievements()
        {
            return DbContext.Achievements.ToList();
        }

        public async Task<bool> AddAchievementAsync(Achievement achievement)
        {
            try
            {
                await DbContext.Achievements.AddAsync(achievement);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;   
            }

        }

        public async Task<bool> DeleteAchievementAsync(int id)
        {
            Achievement achievement = DbContext.Achievements.FirstOrDefault(p => p.Id == id);
            if(achievement != null)
            {
                try
                {
                    DbContext.Achievements.Remove(achievement);
                    await DbContext.SaveChangesAsync();
                    return true;
                }
                catch(Exception ex)
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

        public async Task<bool> UpdateAchievementAsync(Achievement achievement)
        {
            try
            {
                DbContext.Achievements.Update(achievement);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex)
            {
                Debug.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                Console.WriteLine("\n\n\n" + ex.Message + "\n\n\n");
                return false;
            }
        }
    }
}
