using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesGame
{
    public class ListMoves
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("id_game")]
        public string Id_Game { get; set; }
        public Game game { get; set; }

        [BsonElement("figure_color")]
        public string FigureColor { get; set; }

        [BsonElement("figure_name")]
        public string FigureName { get; set; }

        [BsonElement("from_point")]
        public string FromPoint { get; set; }

        [BsonElement("to_point")]
        public string ToPoint { get; set; }
    }
}
