using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        //static PostContext DbContext = PostContext.ChessPlayers;
        static private IChessPlayerRepository _chessPlayerRepository;
        public ChessPlayerController(IChessPlayerRepository chessPlayerRepository)
        {
            //DbContext = context;
            _chessPlayerRepository = chessPlayerRepository;
        }
        //private readonly static IChessPlayerRepository chessPlayerRepository = new ChessPlayerRepository(DbContext);



        [HttpGet]
        [Route("items")]
        public IActionResult GetAllChessPlaeyrs()
        {
            return new OkObjectResult(_chessPlayerRepository.GetAllChessPlayers());
        }
    }
}
