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
    public class AchievementController : ControllerBase
    {
        private IAchievementRepository _achievementRepository;

        public AchievementController(IAchievementRepository achievementRepository)
        {
            _achievementRepository = achievementRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllAchievements()
        {
            return new OkObjectResult(_achievementRepository.GetAllAchievements());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAchievement(int id)
        {
            return new OkObjectResult(_achievementRepository.GetAchievement(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddAchievement(Achievement achievement)
        {
            if(await _achievementRepository.AddAchievementAsync(achievement))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteAchievement(int id)
        {
            if(await _achievementRepository.DeleteAchievementAsync(id))
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
        public async Task<IActionResult> UpdateAchievement(Achievement achievement)
        {
            if(await _achievementRepository.UpdateAchievementAsync(achievement))
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
