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
    public class Tournament_stageController : ControllerBase
    {
        private ITournament_stageRepository _tournament_stageRepository;

        public Tournament_stageController(ITournament_stageRepository tournament_stageRepository)
        {
            _tournament_stageRepository = tournament_stageRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllTournament_stage()
        {
            return new OkObjectResult(_tournament_stageRepository.GetAllTournament_stage());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTournament_stage(int id)
        {
            return new OkObjectResult(_tournament_stageRepository.GetTournament_stage(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddTournament_stageAsync(Tournament_stage tournament_stage)
        {
            if (await _tournament_stageRepository.AddTournament_stageAsync(tournament_stage))
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
        public async Task<IActionResult> UpdateTournament_stageAsync(Tournament_stage tournament_stage)
        {
            if (await _tournament_stageRepository.UpdateTournament_stageAsync(tournament_stage))
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
        public async Task<IActionResult> DeleteTournament_stageAsync(int id)
        {
            if (await _tournament_stageRepository.DeleteTournament_stageAsync(id))
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
