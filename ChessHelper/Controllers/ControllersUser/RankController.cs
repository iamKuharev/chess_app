﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChessHelper.Domain.Entities;
using ChessHelper.Domain.Repositories.RepositoriesUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChessHelper.Controllers.ControllersUser
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankController : ControllerBase
    {
        private IRankRepository _rankRepository;

        public RankController(IRankRepository rankRepository)
        {
            _rankRepository = rankRepository;
        }

        [Authorize]
        [HttpGet]
        [Route("items")]
        public IActionResult GetAllRanks()
        {
            return new OkObjectResult(_rankRepository.GetAllRanks());
        }

        [Authorize(Roles = "Админ")]
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetRank(int id)
        {
            return new OkObjectResult(_rankRepository.GetRank(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddRankAsync(Rank rank)
        {
            if (await _rankRepository.AddRankAsync(rank))
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
        public async Task<IActionResult> UpdateRankAsync(Rank rank)
        {
            if (await _rankRepository.UpdateRankAsync(rank))
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
        public async Task<IActionResult> DeleteRankAsync(int id)
        {
            if (await _rankRepository.DeleteRankAsync(id))
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
