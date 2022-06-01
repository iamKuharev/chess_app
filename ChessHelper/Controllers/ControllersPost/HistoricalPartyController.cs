using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersPost
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistoricalPartyController : ControllerBase
    {
        private IHistoricalPartyRepository _historicalParty;
        public HistoricalPartyController(IHistoricalPartyRepository historicalParty)
        {
            _historicalParty = historicalParty;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_historicalParty.GetAllHistoricalParty());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetHistoricalParty(int id)
        {
            return new OkObjectResult(_historicalParty.GetHistoricalParty(id));
        }
    }
}
