using System;
using System.Collections.Generic;
using System.Text;

namespace ChessHelper.Domain.Repositories.RepositoriesAnalytics
{
    public interface IAnalyticsRepository
    {
        public int count_games_user_common(int id);
        public int count_games_user_win(int id);
        public int count_games_user_loss(int id);
    }
}
