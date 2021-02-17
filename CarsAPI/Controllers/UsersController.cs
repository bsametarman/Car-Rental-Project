using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        IUserService _iUserService;
        public UsersController(IUserService userService)
        {
            _iUserService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _iUserService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _iUserService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            var result = _iUserService.Add(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(User user)
        {
            var result = _iUserService.Update(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete]
        public IActionResult Delete(User user)
        {
            var result = _iUserService.Delete(user);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
