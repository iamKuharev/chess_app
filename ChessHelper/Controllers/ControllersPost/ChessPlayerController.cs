using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChessPlayerController : ControllerBase
    {
        static private IChessPlayerRepository _chessPlayerRepository;
        public ChessPlayerController(IChessPlayerRepository chessPlayerRepository)
        {
            _chessPlayerRepository = chessPlayerRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllChessPlaeyrs()
        {
            return new OkObjectResult(_chessPlayerRepository.GetAllChessPlayers());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetChessPlaeyrs(int id)
        {
            return new OkObjectResult(_chessPlayerRepository.GetChessPlayer(id));
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteChessPlaeyr(int id)
        {
            if (await _chessPlayerRepository.DeleteChessPlaeyr(id))
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
        public async Task<IActionResult> AddChessPlaeyrAsync(ChessPlayer chessPlayer)
        {
            if(await _chessPlayerRepository.AddChessPlayer(chessPlayer))
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
        public async Task<IActionResult> UpdateChessPlayer(ChessPlayer chessPlayer)
        {
            if (await _chessPlayerRepository.UpdateChessPlayer(chessPlayer))
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
