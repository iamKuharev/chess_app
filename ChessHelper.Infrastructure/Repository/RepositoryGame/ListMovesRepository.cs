using ChessHelper.Domain.Entities.EntitiesGame;
using ChessHelper.Domain.Repositories.RepositoriesGame;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryGame
{
    public class ListMovesRepository : IListMovesRepository
    {
        protected readonly GameServices GameDB;
        protected readonly UserContext userContext;

        public ListMovesRepository(GameServices context, UserContext userContext)
        {
            GameDB = context;
            this.userContext = userContext;
        }

        // получаем один документ по id
        public async Task<ListMoves> GetMovesListAsync(string id)
        {
            var listMoves = await GameDB.ListMoves.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();

            GameRepository gameRepository = new GameRepository(GameDB, userContext);

            listMoves.game = await gameRepository.GetGameAsync(listMoves.Id_Game);

            return listMoves;
        }


        public async Task<List<ListMoves>> GetMovesListByIdGame(string id)
        {
            List<ListMoves> listMoves = new List<ListMoves>();

            var filter = new BsonDocument("id_game", id);

            GameRepository gameRepository = new GameRepository(GameDB, userContext);

            listMoves = GameDB.ListMoves.Find(filter).ToList();

            for (int i = 0; i < listMoves.Count; i++)
            {
                listMoves[i].game = await gameRepository.GetGameAsync(listMoves[i].Id_Game);
            }

            return listMoves;
        }

        // добавление документа
        public async Task<bool> Create(ListMoves listMoves)
        {
            try
            {
                await GameDB.ListMoves.InsertOneAsync(listMoves);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }
        // обновление документа
        public async Task<bool> Update(ListMoves listMoves)
        {
            try
            {
                await GameDB.ListMoves.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(listMoves.Id)), listMoves);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }
        // удаление документа
        public async Task<bool> Remove(string id)
        {
            try
            {
                await GameDB.ListMoves.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public async Task<List<ListMoves>> GetAllMovesListAsync()
        {
            List<ListMoves> listMoves = new List<ListMoves>();

            listMoves = GameDB.ListMoves.Find(_ => true).ToList();

            return listMoves;
        }
    }
}
