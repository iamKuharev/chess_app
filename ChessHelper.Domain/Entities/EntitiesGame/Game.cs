using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesGame
{
    public class Game
    {
        public int Id { get; set; }
        public int Id_PlayerWhite { get; set; }
        public int Id_PlayerBlack { get; set; }
        public int Id_Win { get; set; }
        public int Id_TournamentStage { get; set; }
    }
}
