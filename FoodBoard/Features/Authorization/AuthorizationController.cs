using FoodBoard.Features.Authorization.Representations;
using FoodBoard.Features.Users;
using Microsoft.AspNetCore.Mvc;

namespace FoodBoard.Features.Authorization
{
    [Route("api/[controller]")]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IUserService _userService;

        public AuthorizationController(IAuthorizationService authorizationService, ITokenGenerator tokenGenerator, IUserService userService)
        {
            _authorizationService = authorizationService;
            _userService = userService;
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost]
        public IActionResult Login([FromBody]AuthorizationWriteViewModel loginViewModel)
        {
            var valid = _authorizationService.ValidCredentials(loginViewModel.Username, loginViewModel.Password);
            string token = "";
            if (valid)
            {
                var userId = _userService.GetUserByName(loginViewModel.Username).Id;
                token = _tokenGenerator.GenerateToken(userId);
            }
            return Ok(token);
        }
    }
}
