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
    public class RentalsController : ControllerBase
    {
        private IRentalService _iRentalService;

        public RentalsController(IRentalService rentalService)
        {
            _iRentalService = rentalService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _iRentalService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("get")]
        public IActionResult Get(int carId)
        {
            var result = _iRentalService.GetById(carId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _iRentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPut("update")] //Güncellee için piyasada çoğunlukla post işlemi kullanılıyor
        public IActionResult Update(Rental rental)
        {
            var result = _iRentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")] //Delete için piyasada çoğunlukla post işlemi kullanılıyor
        public IActionResult Delete(Rental rental)
        {
            var result = _iRentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
