using ChessHelper.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public interface ITournamentRepository
    {
        Tournament GetTournament(int id);

        IList<Tournament> GetAllTournament();

        Task<bool> AddTournamentAsync(Tournament tournament);

        Task<bool> UpdateTournamentAsync(Tournament tournament);

        Task<bool> DeleteTournamentAsync(int id);
    }
}
