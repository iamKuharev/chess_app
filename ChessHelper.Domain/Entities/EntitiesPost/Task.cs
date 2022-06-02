using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    [Table("task")]
    public class Task
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("id_theory")]
        public int TheoryId { get; set; }
        public Theory Theory { get; set; }

        [Column("id_game(NoSQL)")]
        public int Id_Game { get; set; }
    }
}