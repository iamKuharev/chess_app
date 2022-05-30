using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    public class HistoricalParty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Data { get; set; }
        public int Id_Game { get; set; }
        public int Id_FirstChessPlayer { get; set; }
        public int Id_SecondChessPlayer { get; set; }
    }
}
