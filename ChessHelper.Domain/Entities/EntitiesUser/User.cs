using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesUser;

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
        public int Task_rate { get; set; }

        [Column("id_avatar")]
        public int AvatarId { get; set; }
        [MaybeNull]
        public Avatar Avatar { get; set; }

        [Column("id_rank")]
        public int RankId { get; set; }
        [MaybeNull]
        public Rank Rank { get; set; }

        [Column("id_role")]
        public int RoleId { get; set; }
        [MaybeNull]
        public Role Role { get; set;  }

        //[Table("")]
        public List<Achievement> Achievements { get; set; } = new List<Achievement>();

       // public List<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
    }
}
