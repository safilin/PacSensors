﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PacSensors.Models;
using PacSensors.Repositories;

namespace PacSensors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GP_INSTController : ControllerBase
    {
        private readonly IGP_INST_Repository _repository;
        public GP_INSTController(IGP_INST_Repository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<GP_INST>> GetById(int id)
        {
            var obj = await _repository.GetById(id);
            if (obj == null) return NotFound();
            return Ok(obj);
        }

        [HttpGet("GetLast")]
        public async Task<ActionResult<GP_INST>> GetLast()
        {
            var obj = await _repository.GetLast();
            if (obj == null) return NotFound();
            return Ok(obj);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GP_INST>>> GetByDateTime(string dateTime)
        {
            var objs = await _repository.GetByDateTime(dateTime);
            if (objs == null) return NotFound();
            return Ok(objs);
        }

    }
}
