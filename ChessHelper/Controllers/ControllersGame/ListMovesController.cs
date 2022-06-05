using ChessHelper.Domain.Entities.EntitiesGame;
using ChessHelper.Domain.Repositories.RepositoriesGame;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChessHelper.Controllers.ControllersGame
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListMovesController : ControllerBase
    {
        private IListMovesRepository _listMovesRepository;

        public ListMovesController(IListMovesRepository listMovesRepository)
        {
            _listMovesRepository = listMovesRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllMovesList()
        {
            return new OkObjectResult(_listMovesRepository.GetAllMovesListAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetGameAsync(string id)
        {
            return new OkObjectResult(await _listMovesRepository.GetMovesListAsync(id));
        }

        [HttpGet]
        [Route("game/{id}")]
        public async Task<IActionResult> GetMovesListByIdGame(string id)
        {
            return new OkObjectResult(await _listMovesRepository.GetMovesListByIdGame(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create(ListMoves listMoves)
        {
            if (await _listMovesRepository.Create(listMoves))
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
            if (await _listMovesRepository.Remove(id))
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
        public async Task<IActionResult> Update(ListMoves listMoves)
        {
            if (await _listMovesRepository.Update(listMoves))
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
