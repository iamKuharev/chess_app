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
        public int Id_ChessPlayer { get; set; }
        [Column("id_video_lesson")]
        public int Id_VideoLesson { get; set; }
        [Column("id_historial_chess_game")]
        public int Id_HistoricalParty { get; set; }
        [Column("id_theory")]
        public int Id_Theory { get; set; }
    }
}
