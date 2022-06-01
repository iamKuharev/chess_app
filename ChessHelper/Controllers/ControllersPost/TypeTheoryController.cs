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
    }
}
