using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface IAchievementRepository
    {
        Achievement GetAchievement(int id);

        IList<Achievement> GetAllAchievements();

        Task<bool> AddAchievementAsync(Achievement achievement);

        Task<bool> UpdateAchievementAsync(Achievement achievement);

        Task<bool> DeleteAchievementAsync(int id);
    }
}
