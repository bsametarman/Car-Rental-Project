using Business.Abstract;
using Business.Concrete;
using Core.Constants;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarsAPI.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _iCarService;

        public CarsController(ICarService carService)
        {
            _iCarService = carService;
        }
        
        
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _iCarService.GetAll();
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _iCarService.GetCarsByBrandId(id);
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }
        
        [HttpPost]
        public IActionResult Add(Car car)
        {
            var result = _iCarService.Add(car);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut]
        public IActionResult Update(Car car)
        {
            var result = _iCarService.Update(car);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete]
        public IActionResult delete(Car car)
        {
            var result = _iCarService.Delete(car);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
