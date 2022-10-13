using BusinnessLayer.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var colors=_colorService.GetAll();
            if (colors.Success)
            {
                return Ok(colors);
            }
            return BadRequest(colors);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var colors=_colorService.GetByColorId(id);
            if (colors.Success)
            {
                return Ok(colors);
            }
            return BadRequest(colors);
        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var colors = _colorService.Add(color);
            if (colors.Success)
            {
                return Ok(colors);
            }
            return BadRequest(colors);
        }
        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var colors = _colorService.Update(color);
            if (colors.Success)
            {
                return Ok(colors);
            }
            return BadRequest(colors);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var colors=_colorService.Delete(color);
            if (colors.Success)
            {
                return Ok(colors);
            }
            return BadRequest(colors);
        }
    }
}
