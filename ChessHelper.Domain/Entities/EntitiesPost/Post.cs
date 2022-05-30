using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Id_ChessPlayer { get; set; }
        public int Id_VideoLesson { get; set; }
        public int Id_HistoricalParty { get; set; }
        public int Id_Theory { get; set; }
    }
}
