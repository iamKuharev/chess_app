
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    public class Tournament_stage
    {
        public int Id { get; set; }
        public string Stage_type { get; set; }
        public int Id_Tournament { get; set; }
    }
}
