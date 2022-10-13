using BusinnessLayer.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var brands=_brandService.GetAll();
            if (brands.Success)
            {
                return Ok(brands);
            }
            return BadRequest(brands);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var brands = _brandService.GetByBrandId(id);
            if (brands.Success)
            {
                return Ok(brands);
            }
            return BadRequest(brands);
        }
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var brands= _brandService.Add(brand);
            if (brands.Success)
            {
                return Ok(brands);
            }
            return BadRequest(brands);
        }
        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var brands= _brandService.Update(brand);
            if (brands.Success)
            {
                return Ok(brands);
            }
            return BadRequest(brands);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Brand  brand)
        {
            var brands= _brandService.Delete(brand);
            if (brands.Success)
            {
                return Ok(brands);
            }
            return BadRequest(brands);
        }
    }
}
