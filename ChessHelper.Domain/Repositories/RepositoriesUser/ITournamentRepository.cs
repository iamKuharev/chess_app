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
        bool AddTournament(Tournament Tournament);
        bool DeliteTournament(int id);


    }
}
