using Microsoft.AspNetCore.Mvc;
using Palisade.Service;
using Palisade.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palisade.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public ActionResult<UserDTO> Login([FromBody] UserDTO userDto) 
        {
            return _userService.Login(userDto); // CREATE FOR ISERVICE TOO
        }

        [HttpPost("registration")]
        public ActionResult<UserDTO> Register([FromBody] UserDTO userDto)
        {
            return _userService.Register(userDto);
        }

    }
}
