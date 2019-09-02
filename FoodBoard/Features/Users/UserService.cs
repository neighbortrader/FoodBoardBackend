
using FoodBoard.Models;
using Microsoft.AspNetCore.Identity;

namespace FoodBoard.Features.Users
{
    public interface IUserService
    {
        bool PostUser(LoginUser user, string password);
        bool CheckPass();
    }

    public class UserService : IUserService
    {
        private readonly FoodBoardContext _context;
        private readonly UserManager<LoginUser> _userManager;

        public UserService(FoodBoardContext context, UserManager<LoginUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public bool PostUser(LoginUser user, string password)
        {
            var test = _userManager.CreateAsync(user, password).Result;
            return test.Succeeded;
        }

        public bool CheckPass()
        {
            return true;
        }
    }
}
