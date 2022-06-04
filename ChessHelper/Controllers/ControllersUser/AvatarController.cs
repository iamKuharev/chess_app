using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarController : ControllerBase
    {
        private IAvatarRepository _avatarRepository;

        public AvatarController(IAvatarRepository avatarRepository)
        {
            _avatarRepository = avatarRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllAvatar()
        {
            return new OkObjectResult(_avatarRepository.GetAllAvatars());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetAvatar(int id)
        {
            return new OkObjectResult(_avatarRepository.GetAvatar(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddAvatarAsync(Avatar avatar)
        {
            if (await _avatarRepository.AddAvatarAsync(avatar))
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
        public async Task<IActionResult> UpdateAvatarAsync(Avatar avatar)
        {
            if (await _avatarRepository.UpdateAvatarAsync(avatar))
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
        public async Task<IActionResult> DeleteAvatarAsync(int id)
        {
            if (await _avatarRepository.DeleteAvatarAsync(id))
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
