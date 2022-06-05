using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Entities.EntitiesGame;
using ChessHelper.Domain.Repositories.RepositoriesAnalytics;
using ChessHelper.Infrastructure.Repository.RepositoryGame;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using ChessHelper.Infrastructure.Repository.RepositoryUser;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryAnalytics
{
    public class AnalyticsRepository : IAnalyticsRepository
    {
        private readonly UserContext userContext;
        protected readonly GameServices GameDB;

        public AnalyticsRepository(UserContext context, GameServices gameDB)
        {
            userContext = context;
            GameDB = gameDB;
        }

        public int count_games_user_common(int id)
        {
            var result = 0;

            List<Game> games1 = new List<Game>();
            List<Game> games2 = new List<Game>();

            UserRepository userRepository = new UserRepository(userContext);
            Tournament_stageRepository tournament_stageRepository = new Tournament_stageRepository(userContext);

            var filter1 = new BsonDocument("id_user_white", id);
            var filter2 = new BsonDocument("id_user_black", id);

            games1 = GameDB.Games.Find(filter1).ToList();
            games2 = GameDB.Games.Find(filter2).ToList();

            var games3 = games1.Concat(games2)
                                    .ToList();

            if (games3 != null)
                result += games3.Count;

            return result;
        }

        public int count_games_user_win(int id)
        {
            var result = 0;

            List<Game> games1 = new List<Game>();

            UserRepository userRepository = new UserRepository(userContext);
            Tournament_stageRepository tournament_stageRepository = new Tournament_stageRepository(userContext);

            var filter1 = new BsonDocument("match_winner", id);

            games1 = GameDB.Games.Find(filter1).ToList();

            if (games1 != null)
                result += games1.Count;

            return result;
        }

        public int count_games_user_loss(int id)
        {
            return count_games_user_common(id) - count_games_user_win(id);
        }
    }
}
