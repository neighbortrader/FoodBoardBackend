using System;
using AutoMapper;
using FoodBoard.Features.Users.Representation;
using FoodBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodBoard.Features.Users
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        

        [HttpPost]
        public IActionResult CreateNewUser([FromBody]UserWriteViewModel userWriteView)
        {
            var user = _mapper.Map<LoginUser>(userWriteView);
            var createdUserId = _userService.PostUser(user);
            return Ok(createdUserId);
        }
    }
}
