using BusinnessLayer.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            if (users.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var users = _userService.GetByUserId(id);
            if (users.Success)
            {
                return Ok(users);

            }
            return BadRequest(users);
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var users=_userService.Add(user);
            if (users.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }
        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var users = _userService.Update(user);
            if (users.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }
        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var users= _userService.Delete(user);
            if (users.Success)
            {
                return Ok(users);
            }
            return BadRequest(users);
        }


    }
}
