using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _iColorService;
        public ColorsController(IColorService colorService)
        {
            _iColorService = colorService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _iColorService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _iColorService.GetById(id);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost]
        public IActionResult Add(Color color)
        {
            var result = _iColorService.Add(color);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete]
        public IActionResult Delete(Color color)
        {
            var result = _iColorService.Delete(color);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Color color)
        {
            var result = _iColorService.Update(color);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

    }
}
