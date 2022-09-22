using ChessHelper.Domain.Entities.EntitiesGame;
using ChessHelper.Domain.Repositories.RepositoriesGame;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChessHelper.Controllers.ControllersGame
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllGameAsync()
        {
            return new OkObjectResult(_gameRepository.GetAllGame());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetGameAsync(string id)
        {
            return new OkObjectResult(await _gameRepository.GetGameAsync(id));
        }

        [HttpGet]
        [Route("user/{id}")]
        public IActionResult GamesParticipated(int id)
        {
            return new OkObjectResult(_gameRepository.GamesParticipated(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create(Game game)
        {
            if (await _gameRepository.Create(game))
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
        public async Task<IActionResult> Remove(string id)
        {
            if (await _gameRepository.Remove(id))
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
        public async Task<IActionResult> Update(Game game)
        {
            if (await _gameRepository.Update(game))
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
