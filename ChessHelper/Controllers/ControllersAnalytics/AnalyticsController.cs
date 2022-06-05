using ChessHelper.Domain.Repositories.RepositoriesAnalytics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersAnalytics
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private IAnalyticsRepository _AnalyticsRepository;
        public AnalyticsController(IAnalyticsRepository AnalyticsRepository)
        {
            _AnalyticsRepository = AnalyticsRepository;
        }


        [HttpGet]
        [Route("count_games_user_common/{id}")]
        public IActionResult count_games_user_common(int id)
        {
            return new OkObjectResult(_AnalyticsRepository.count_games_user_common(id));
        }

        [HttpGet]
        [Route("count_games_user_win/{id}")]
        public IActionResult count_games_user_win(int id)
        {
            return new OkObjectResult(_AnalyticsRepository.count_games_user_win(id));
        }

        [HttpGet]
        [Route("count_games_user_loss/{id}")]
        public IActionResult count_games_user_loss(int id)
        {
            return new OkObjectResult(_AnalyticsRepository.count_games_user_loss(id));
        }
    }
}
