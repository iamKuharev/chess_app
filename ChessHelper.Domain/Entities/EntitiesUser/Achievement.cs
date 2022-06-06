using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesUser;

namespace ChessHelper.Domain.Entities
{
    [Table("achievement")]
    public class Achievement
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }

        public List<User> Users { get; set; } = new List<User>();
       // public List<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();

    }
}
