using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insightflow_users_service.Src.DTOs;
using insightflow_users_service.Src.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace insightflow_users_service.Src.Controllers
{
    [ApiController]
    [Route("users/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = _service.Create(dto);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }        

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAll());

        [HttpGet("{id:guid}")]
        public IActionResult GetById(Guid id) => Ok(_service.GetById(id)); 


        [HttpDelete("{id:guid}")]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}