using ChessHelper.Domain.Entities.EntitiesGame;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    [Table("historical_chess_game")]
    public class HistoricalParty
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("date")]
        public DateTime Data { get; set; }

        [Column("id_game(NoSQL)")]
        public string GameId{ get; set; }
        public Game game { get; set;  }

        [Column("id_chess_player_1")]
        public int FirstChessPlayerId { get; set; }
        public ChessPlayer FirstChessPlayer { get; set; }

        [Column("id_chess_player_2")]
        public int SecondChessPlayerId { get; set; }
        public ChessPlayer SecondChessPlayer { get; set; }
    }
}