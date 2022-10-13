using BusinnessLayer.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var cars = _carService.GetAll();
            if (cars.Success)
            {
                return Ok(cars);
            }
            return BadRequest(cars);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var cars = _carService.GetById(id);
            if (cars.Success)
            {
                return Ok(cars);
            }
            return BadRequest(cars);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var cars=_carService.Add(car);
            if (cars.Success)
            {
                return Ok(cars);
            }
            return BadRequest(cars);
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var cars=_carService.Update(car);
            if (cars.Success)
            {
                return Ok(cars);
            }
            return BadRequest(cars);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var cars = _carService.Delete(car);
            if (cars.Success)
            {
                return Ok(cars);
            }
            return BadRequest(cars);
        }


    }
}
