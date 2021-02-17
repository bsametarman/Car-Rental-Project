using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandAPI.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {

        IBrandService _iBrandService;

        public BrandsController(IBrandService brandService)
        {
            _iBrandService = brandService;
        }


        [HttpGet("getall")]
        public IActionResult Get()
        {            
            var result = _iBrandService.GetAll();
            if(result.Success)
            {
                return Ok(result.Data); 
            }
            return BadRequest(result.Message);
        }
        
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _iBrandService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Data);
        }

        [HttpPost]
        public IActionResult Add(Brand brand)
        {
            var result = _iBrandService.Add(brand);
            if(result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPut]
        public IActionResult Update(Brand brand)
        {
            var result = _iBrandService.Update(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpDelete]
        public IActionResult delete(Brand brand)
        {
            var result = _iBrandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }


    }
}
