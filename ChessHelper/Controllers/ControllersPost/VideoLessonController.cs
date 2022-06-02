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
    public class VideoLessonController : ControllerBase
    {
        private IVideoLessonRepository _videoLessonRepository;
        public VideoLessonController(IVideoLessonRepository videoLessonRepository)
        {
            _videoLessonRepository = videoLessonRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_videoLessonRepository.GetAllVideoLessons());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetVideoLesson(int id)
        {
            return new OkObjectResult(_videoLessonRepository.GetVideoLesson(id));
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteVideoLesson(int id)
        {
            if (await _videoLessonRepository.DeleteVideoLesson(id))
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
        public async Task<IActionResult> AddVideoLesson(VideoLesson videoLesson)
        {
            if (await _videoLessonRepository.AddVideoLesson(videoLesson))
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
        public async Task<IActionResult> UpdateVideoLesson(VideoLesson videoLesson)
        {
            if (await _videoLessonRepository.UpdateVideoLesson(videoLesson))
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
