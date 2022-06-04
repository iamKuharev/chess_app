using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    { 
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllUsers()
        {
            return new OkObjectResult(_userRepository.GetAllUsers());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetUser(int id)
        {
            return new OkObjectResult(_userRepository.GetUser(id));
        }

        [HttpGet]
        [Route("{login}")]
        public IActionResult FindUserByLogin(string login)
        {
            return new OkObjectResult(_userRepository.FindUserByLogin(login));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddUserAsync(User user)
        {
            if (await _userRepository.AddUserAsync(user))
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
        public async Task<IActionResult> UpdateUserAsync(User user)
        {
            if (await _userRepository.UpdateUserAsync(user))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            if (await _userRepository.DeliteUserAsync(id))
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
