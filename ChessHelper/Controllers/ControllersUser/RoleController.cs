using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private IRoleRepository _roleRepository;

        public RoleController(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        [HttpGet]
        [Route("role_user/{id}")]
        public IActionResult GetRoleUserById(int id)
        {
            return new OkObjectResult(_roleRepository.GetRoleUserById(id));
        }

        [HttpPost]
        [Route("set_role_user/{id_user}/{id_role}")]
        public async Task<IActionResult> SetRoleUserById(int id_user, int id_role)
        {
            if (await _roleRepository.SetRoleUserById(id_user, id_role))
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
