using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities
{
    [Table("user")]
    public class User
    {
        [Column("id")]
        public int? Id { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("surname")]
        public string Surname { get; set; }
        
        [Column("login")]
        public string Login { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("task_rate")]
        public int TaskRate { get; set; }

        [Column("id_avatar")]
        public int AvatarId { get; set; }

        [Column("id_rank")]
        public int RankId { get; set; }

        [Column("id_role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
