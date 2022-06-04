
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    [Table("tournament_stage")]
    public class Tournament_stage
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("stage_type")]
        public string Stage_type { get; set; }

        [Column("id_tournament")]
        public int TournamentId { get; set; }
        public Tournament Tournament { get; set; }
    }
}
