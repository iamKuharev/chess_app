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
        bool AddStage(Tournament_stage TournamentStage);

        bool DeliteStage(int id);
    }
}
