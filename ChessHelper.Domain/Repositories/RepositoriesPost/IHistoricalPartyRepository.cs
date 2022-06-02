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

        Task<bool> AddHistoricalParty(HistoricalParty historicalParty);

        Task<bool> UpdateHistoricalParty(HistoricalParty historicalParty);

        Task<bool> DeleteHistoricalParty(int id);
    }
}
