using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
    {
        private ITournamentRepository _tournamentRepository;

        public TournamentController(ITournamentRepository tournamentRepository)
        {
            _tournamentRepository = tournamentRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllTournament()
        {
            return new OkObjectResult(_tournamentRepository.GetAllTournament());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTournament(int id)
        {
            return new OkObjectResult(_tournamentRepository.GetTournament(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddTournamentAsync(Tournament tournament)
        {
            if (await _tournamentRepository.AddTournamentAsync(tournament))
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
        public async Task<IActionResult> UpdateTournamentAsync(Tournament tournament)
        {
            if (await _tournamentRepository.UpdateTournamentAsync(tournament))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteTournamentAsync(int id)
        {
            if (await _tournamentRepository.DeleteTournamentAsync(id))
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
