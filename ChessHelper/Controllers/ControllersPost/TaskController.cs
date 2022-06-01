using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using ChessHelper.Infrastructure.Repository.RepositoryPost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersPost
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskRepository _TaskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _TaskRepository = taskRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_TaskRepository.GetAllTask());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTask(int id)
        {
            return new OkObjectResult(_TaskRepository.GetTask(id));
        }
    }
}
