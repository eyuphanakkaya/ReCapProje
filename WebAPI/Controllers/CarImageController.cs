using BusinnessLayer.Abstract;
using Core.Utilities.Helpers.FileHelpers;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImageController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImageController(ICarImageService carImageService)
        {
            _carImageService = carImageService; 
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var carImage=_carImageService.GetAll();
            if (carImage.Success)
            {
                return Ok(carImage);
            }
            return BadRequest(carImage);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var carImage=_carImageService.GetByCarImageId(id);
            if (carImage.Success)
            {
                return Ok(carImage);
            }
            return BadRequest(carImage);
        }
        [HttpPost("add")]
        public IActionResult Add(IFormFile file,CarImage carImage)
        {
            var carImage2 = _carImageService.Add(file,carImage);
            if (carImage2.Success)
            {
                return Ok(carImage2);
            }
            return BadRequest(carImage2);
        }
        [HttpPost("update")]
        public IActionResult Update(IFormFile file,CarImage carImage)
        {
            var carImage2=_carImageService.Update(file,carImage);
            if (carImage2.Success)
            {
                return Ok(carImage2);
            }
            return BadRequest(carImage2);
        }


    }
}
