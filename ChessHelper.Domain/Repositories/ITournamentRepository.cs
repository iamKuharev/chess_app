using System;
using System.Collections.Generic;
using System.Text;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories
{
    public interface ITournamentRepository
    {
        bool AddTournament(Tournament tournament);
    }
}
