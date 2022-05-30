using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    public class ChessPlayer
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PathPicture { get; set; }
    }
}
