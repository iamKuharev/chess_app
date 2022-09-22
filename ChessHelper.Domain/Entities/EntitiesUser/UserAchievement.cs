using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ChessHelper.Domain.Entities;

namespace ChessHelper.Domain.Repositories.RepositoriesUser
{
    public class UserAchievement
    {
        [Column("id_user")]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Column("id_achievement")] 
        public int AchievementId { get; set; }
        public Achievement? Achievement { get; set; }
    }
}
