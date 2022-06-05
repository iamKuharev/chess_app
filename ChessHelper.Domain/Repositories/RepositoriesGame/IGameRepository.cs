using ChessHelper.Domain.Entities.EntitiesGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Repositories.RepositoriesGame
{
    public interface IGameRepository
    {
        List<Game> GetAllGame();

        Task<Game> GetGameAsync(string id);

        Task<bool> Create(Game game);

        Task<bool> Update(Game game);

        Task<bool> Remove(string id);
    }
}
