using ChessHelper.Domain.Entities.EntitiesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface IHistoricalPartyRepository
    {
        HistoricalParty GetHistoricalParty(int id);

        IList<HistoricalParty> GetAllHistoricalParty();

        bool AddHistoricalParty(HistoricalParty historicalParty);

        bool UpdateHistoricalParty(HistoricalParty historicalParty);

        bool DeleteHistoricalParty(int id);
    }
}
