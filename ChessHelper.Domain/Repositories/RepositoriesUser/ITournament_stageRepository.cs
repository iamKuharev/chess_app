using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface ITournament_stageRepository
    {
        Tournament_stage GetTournament_stage(int id);

        IList<Tournament_stage> GetAllTournament_stage();

        Task<bool> AddTournament_stageAsync(Tournament_stage tournament_stage);

        Task<bool> UpdateTournament_stageAsync(Tournament_stage tournament_stage);

        Task<bool> DeleteTournament_stageAsync(int id);
    }
}
