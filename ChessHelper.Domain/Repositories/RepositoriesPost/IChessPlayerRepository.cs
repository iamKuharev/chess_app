using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities.EntitiesPost;

namespace ChessHelper.Domain.Repositories.RepositoriesPost
{
    public interface IChessPlayerRepository
    {
        ChessPlayer GetChessPlayer(int id);

        IList<ChessPlayer> GetAllChessPlayers();

        Task<bool> AddChessPlayer(ChessPlayer chessPlayer);

        Task<bool> UpdateChessPlayer(ChessPlayer chessPlayer);

        Task<bool> DeleteChessPlaeyr(int id);
    }
}
