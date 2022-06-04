using System;
using System.Collections.Generic;
using System.Text;

namespace ChessHelper.Domain.Entities
{
    public class Tournament
    {
        public int Id { get; set; }

        public int Title { get; set; }

        public string Description { get; set; }
        
        public DateTime StartDate { get; set; }

        public string Reward { get; set; }

    }
}
