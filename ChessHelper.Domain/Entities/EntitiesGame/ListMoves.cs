using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesGame
{
    public class ListMoves
    {
        public int Id { get; set; }
        public string NameFigure { get; set; }
        public string FromWhere { get; set; }
        public string ToWhere { get; set; }
        public DateTime RunningTimeStamp { get; set; }
        public int Id_Game { get; set; }
    }
}
