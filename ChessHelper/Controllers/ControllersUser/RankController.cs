using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        private IRankRepository _rankRepository;

        public RankController(IRankRepository rankRepository)
        {
            _rankRepository = rankRepository;
        }

        [Authorize]
        [HttpGet]
        [Route("items")]
        public IActionResult GetAllRanks()
        {
            return new OkObjectResult(_rankRepository.GetAllRanks());
        }

        [Authorize(Roles = "Админ")]
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRank(int id)
        {
            return new OkObjectResult(_rankRepository.GetRank(id));
        }
    }
}
