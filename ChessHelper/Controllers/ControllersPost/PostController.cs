using ChessHelper.Domain.Repositories.RepositoriesPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersPost
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private IPostRepository _PostRepository;
        public PostController(IPostRepository PostRepository)
        {
            _PostRepository = PostRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_PostRepository.GetAllPost());
        }
    }
}
