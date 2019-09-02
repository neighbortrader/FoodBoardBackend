using FoodBoard.Features.Authorization.Representations;
using Microsoft.AspNetCore.Mvc;

namespace FoodBoard.Features.Authorization
{
    [Route("api/[controller]")]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly ITokenGenerator _tokenGenerator;

        public AuthorizationController(IAuthorizationService authorizationService, ITokenGenerator tokenGenerator)
        {
            _authorizationService = authorizationService;
            _tokenGenerator = tokenGenerator;
        }

        [HttpPost]
        public IActionResult Login([FromBody]AuthorizationWriteViewModel loginViewModel)
        {
            var valid = _authorizationService.ValidCredentials(loginViewModel.Username, loginViewModel.Password);
            string token = "";
            if (valid)
            {
                token = _tokenGenerator.GenerateToken();
            }
            return Ok(token);
        }
    }
}
