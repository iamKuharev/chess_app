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
    public class TypeTheoryController : ControllerBase
    {
        private ITypeTheoryRepository _ITypeTheoryRepository;
        public TypeTheoryController(ITypeTheoryRepository typeTheoryRepository)
        {
            _ITypeTheoryRepository = typeTheoryRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_ITypeTheoryRepository.GetAllTypeTheory());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTypeTheory(int id)
        {
            return new OkObjectResult(_ITypeTheoryRepository.GetTypeTheory(id));
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteTypeTheory(int id)
        {
            if (await _ITypeTheoryRepository.DeleteTypeTheory(id))
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
        public async Task<IActionResult> AddTypeTheory(TypeTheory typeTheory)
        {
            if (await _ITypeTheoryRepository.AddTypeTheory(typeTheory))
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
        public async Task<IActionResult> UpdateTheory(TypeTheory typeTheory)
        {
            if (await _ITypeTheoryRepository.UpdateTypeTheory(typeTheory))
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
