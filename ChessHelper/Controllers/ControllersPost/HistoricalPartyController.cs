using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities.EntitiesPost;
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

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteHistoricalParty(int id)
        {
            if (await _historicalParty.DeleteHistoricalParty(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddHistoricalParty(HistoricalParty historicalParty)
        {
            if (await _historicalParty.AddHistoricalParty(historicalParty))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> UpdateHistoricalParty(HistoricalParty historicalParty)
        {
            if (await _historicalParty.UpdateHistoricalParty(historicalParty))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
