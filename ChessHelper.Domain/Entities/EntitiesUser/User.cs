using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Task_rate { get; set; }
        public int Id_avatar { get; set; }
        public int Id_rank { get; set; }
        public int Id_role { get; set; }
    }
}
