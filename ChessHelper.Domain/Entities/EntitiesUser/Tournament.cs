using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ChessHelper.Domain.Entities
{
    [Table("tournament")]
    public class Tournament
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        public string Title { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("start_data")]
        public DateTime StartDate { get; set; }

        [Column("reward")]
        public string Reward { get; set; }

    }
}
