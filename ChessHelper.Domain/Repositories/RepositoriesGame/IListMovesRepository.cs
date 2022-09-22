using ChessHelper.Domain.Entities.EntitiesGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesGame
{
    public interface IListMovesRepository
    {
        Task<List<ListMoves>> GetAllMovesListAsync();

        Task<ListMoves> GetMovesListAsync(string id);

        Task<List<ListMoves>> GetMovesListByIdGame(string id);

        Task<bool> Create(ListMoves game);

        Task<bool> Update(ListMoves game);

        Task<bool> Remove(string id);
    }
}
