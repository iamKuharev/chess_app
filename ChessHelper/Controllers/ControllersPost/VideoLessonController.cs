using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesPost;
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
    }
}
