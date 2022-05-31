using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    [Table("video_lesson")]
    public class VideoLesson
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("link")]
        public string Link { get; set; }
    }
}