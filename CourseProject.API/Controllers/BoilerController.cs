using CourseProject.BLL.Interfaces;
using CourseProject.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CourseProject.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoilerController : ControllerBase
    {
        private readonly IBoilerService _service;

        public BoilerController(IBoilerService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllBoilers());
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id)
        {
            var boiler = _service.GetBoilerById(id);
            if (boiler == null) return NotFound();
            return Ok(boiler);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Boiler boiler)
        {
            _service.AddBoiler(boiler);
            return CreatedAtAction(nameof(GetById), new { id = boiler.Id }, boiler);
        }

        [HttpPut("{id:guid}")]
        public IActionResult Update(Guid id, [FromBody] Boiler boiler)
        {
            if (id != boiler.Id) return BadRequest();
            _service.UpdateBoiler(boiler);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _service.DeleteBoiler(id);
            return NoContent();
        }
    }
}