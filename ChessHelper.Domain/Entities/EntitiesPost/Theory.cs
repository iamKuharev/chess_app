using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    public class Theory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Id_TypeTheory { get; set; }
    }
}
