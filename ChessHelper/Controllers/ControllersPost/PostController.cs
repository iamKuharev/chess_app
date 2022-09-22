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
    public class PostController : ControllerBase
    {
        private IPostRepository _PostRepository;
        public PostController(IPostRepository PostRepository)
        {
            _PostRepository = PostRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllPost()
        {
            return new OkObjectResult(_PostRepository.GetAllPost());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetPost(int id)
        {
            return new OkObjectResult(_PostRepository.GetPost(id));
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeletePost(int id)
        {
            if (await _PostRepository.DeletePost(id))
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
        public async Task<IActionResult> AddPost(Post post)
        {
            if (await _PostRepository.AddPost(post))
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
        public async Task<IActionResult> UpdatePost(Post post)
        {
            if (await _PostRepository.UpdatePost(post))
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
