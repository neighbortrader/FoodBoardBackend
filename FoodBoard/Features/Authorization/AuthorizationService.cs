using FoodBoard.Models;
using Microsoft.AspNetCore.Identity;

namespace FoodBoard.Features.Authorization
{
    public interface IAuthorizationService
    {
        bool ValidCredentials(string username, string password);
    }

    public class AuthorizationService : IAuthorizationService
    {
        private readonly UserManager<LoginUser> _userManager;

        public AuthorizationService(UserManager<LoginUser> userManager)
        {
            _userManager = userManager;
        }

        public bool ValidCredentials(string username, string password)
        {
            var user = GetUserByUsername(username);
            var valid = _userManager.CheckPasswordAsync(user, password).Result;
            return valid;
        }

        private LoginUser GetUserByUsername(string username)
        {
            var user = _userManager.FindByNameAsync(username);
            return user.Result;
        }
    }
}
