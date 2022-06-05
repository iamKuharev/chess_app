using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Entities.EntitiesGame;
using ChessHelper.Domain.Repositories.RepositoriesGame;
using ChessHelper.Domain.Repositories.RepositoriesUser;
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
    public class GameRepository : IGameRepository
    {
        protected readonly GameServices GameDB;
        protected readonly UserContext userContext;

        public GameRepository(GameServices context, UserContext userContext)
        {
            GameDB = context;
            this.userContext = userContext;
        }



        // получаем один документ по id
        public async Task<Game> GetGameAsync(string id)
        {
            UserRepository userRepository = new UserRepository(userContext);
            Tournament_stageRepository tournament_stageRepository = new Tournament_stageRepository(userContext);

            var Game = await GameDB.Games.Find(new BsonDocument("_id", new ObjectId(id))).FirstOrDefaultAsync();
            
            Game.PlayerWhite = userRepository.GetUser(Game.Id_PlayerWhite);
            Game.PlayerBlack = userRepository.GetUser(Game.Id_PlayerBlack);
            Game.PlayerWin = userRepository.GetUser(Game.Id_Win);
            Game.TournamentStage = tournament_stageRepository.GetTournament_stage(Game.Id_TournamentStage);

            return Game;

        }
        // добавление документа
        public async Task<bool> Create(Game game)
        {
            try
            {
                await GameDB.Games.InsertOneAsync(game);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }
        // обновление документа
        public async Task<bool> Update(Game game)
        {
            try
            {
                await GameDB.Games.ReplaceOneAsync(new BsonDocument("_id", new ObjectId(game.Id)), game);
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
                await GameDB.Games.DeleteOneAsync(new BsonDocument("_id", new ObjectId(id)));
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public List<Game> GetAllGame()
        {
            List<Game> games = new List<Game>();

            UserRepository userRepository = new UserRepository(userContext);
            Tournament_stageRepository tournament_stageRepository = new Tournament_stageRepository(userContext);

            games = GameDB.Games.Find(_ => true).ToList();

            for (int i = 0; i < games.Count; i++)
            {
                games[i].PlayerWhite = userRepository.GetUser(games[i].Id_PlayerWhite);
                games[i].PlayerBlack = userRepository.GetUser(games[i].Id_PlayerBlack);
                games[i].PlayerWin = userRepository.GetUser(games[i].Id_Win);
                games[i].TournamentStage = tournament_stageRepository.GetTournament_stage(games[i].Id_TournamentStage);
            }
            return games;
        }
    }
}
