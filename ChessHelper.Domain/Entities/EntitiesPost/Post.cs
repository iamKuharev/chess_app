using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    [Table("post")]
    public class Post
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }

        [Column("id_chess_player")]
        public int? ChessPlayerId { get; set; }
        public ChessPlayer ChessPlayer { get; set; }

        [Column("id_video_lesson")]
        public int? VideoLessonId { get; set; }
        public VideoLesson VideoLesson { get; set; }

        [Column("id_historical_chess_game")]
        public int? HistoricalPartyId { get; set; }
        public HistoricalParty HistoricalParty { get; set; }

        [Column("id_theory")]
        public int? TheoryId { get; set; }
        public Theory Theory { get; set; }
    }
}
