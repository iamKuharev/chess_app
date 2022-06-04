﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    [Table("rank")]
    public class Rank
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string Title { get; set; }
    }
}
