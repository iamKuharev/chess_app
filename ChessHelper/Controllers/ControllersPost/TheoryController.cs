﻿using System;
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
    public class TheoryController : ControllerBase
    {
        private ITheoryRepository _ITheoryRepository;
        public TheoryController(ITheoryRepository theoryRepository)
        {
            _ITheoryRepository = theoryRepository;
        }

        [HttpGet]
        [Route("items")]
        public IActionResult GetAllVideoLessons()
        {
            return new OkObjectResult(_ITheoryRepository.GetAllTheory());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTheory(int id)
        {
            return new OkObjectResult(_ITheoryRepository.GetTheory(id));
        }

        [HttpPost]
        [Route("del/{id}")]
        public async Task<IActionResult> DeleteTheory(int id)
        {
            if (await _ITheoryRepository.DeleteTheory(id))
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
        public async Task<IActionResult> AddTheory(Theory theory)
        {
            if (await _ITheoryRepository.AddTheory(theory))
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
        public async Task<IActionResult> UpdateTheory(Theory theory)
        {
            if (await _ITheoryRepository.UpdateTheory(theory))
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
