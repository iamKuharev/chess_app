using ChessHelper.Domain.Entities.EntitiesGame;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryGame
{
    public class GameServices
    {
        //public GameServices(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //}

        //public IConfiguration Configuration { get; }

        IGridFSBucket gridFS;   // файловое хранилище
        public IMongoCollection<Game> Games; // коллекция в базе данных
        public IMongoCollection<ListMoves> ListMoves; // коллекция в базе данных

        public GameServices()
        {
            // строка подключения
            string connectionString = "mongodb+srv://chessAdmin:chessAdmin@cluster0.ublgkwl.mongodb.net/chessDB";
            var connection = new MongoUrlBuilder(connectionString);
            // получаем клиента для взаимодействия с базой данных
            MongoClient client = new MongoClient(connectionString);
            // получаем доступ к самой базе данных
            IMongoDatabase database = client.GetDatabase(connection.DatabaseName);
            // получаем доступ к файловому хранилищу
            gridFS = new GridFSBucket(database);
            // обращаемся к коллекции Products
            Games = database.GetCollection<Game>("game");
            ListMoves = database.GetCollection<ListMoves>("moves_list");
        }
    }
}
