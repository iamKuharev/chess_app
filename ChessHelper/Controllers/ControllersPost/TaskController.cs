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

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            if (await _TaskRepository.DeleteTask(id))
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
        public async Task<IActionResult> AddTask(Domain.Entities.EntitiesPost.Task task)
        {
            if (await _TaskRepository.AddTask(task))
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
        public async Task<IActionResult> UpdateTask(Domain.Entities.EntitiesPost.Task task)
        {
            if (await _TaskRepository.UpdateTask(task))
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
