using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesGame
{
    public class Game
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id_user_white")]
        public int Id_PlayerWhite { get; set; }
        //public User PlayerWhite { get; set; }

        [BsonElement("id_user_black")]
        public int Id_PlayerBlack { get; set; }
        //public User PlayerBlack { get; set; }

        [BsonElement("match_winner")]
        public int Id_Win { get; set; }
        public User PlayerWin { get; set; }

        [BsonElement("id_tournament_stage")]
        public int Id_TournamentStage { get; set; }
        //public Tournament_stage TournamentStage { get; set; }

        [BsonElement("time")]
        public string Time { get; set; }
    }
}
