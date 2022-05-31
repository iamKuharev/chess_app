using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class ChessPlayerRepository : IChessPlayerRepository
    {
        private PostContext DbContext;
        public ChessPlayerRepository(PostContext context)
        {
            DbContext = context;

/*            bool isCreated = DbContext.Database.EnsureCreated();
            // bool isCreated2 = await db.Database.EnsureCreatedAsync();
            if (isCreated)
            {
                Debug.WriteLine("База данных была создана");
                DbContext.Database.EnsureDeleted();
            }
            else Debug.WriteLine("База данных уже существует");*/
        }

        public bool AddChessPlayer(ChessPlayer chessPlayer)
        {
            
            throw new NotImplementedException();
        }

        public bool DeleteChessPlaeyr(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ChessPlayer> GetAllChessPlayers()
        { 
            return DbContext.ChessPlayers.ToList();
        }

        public ChessPlayer GetChessPlayer(int id)
        {
            return DbContext.ChessPlayers.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateChessPlayer(ChessPlayer chessPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
