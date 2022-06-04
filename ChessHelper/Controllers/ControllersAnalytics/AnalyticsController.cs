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
        [Route("count_user")]
        public IActionResult Count_users_in_app()
        {
            return new OkObjectResult(_AnalyticsRepository.count_users_in_app());
        }
    }
}
