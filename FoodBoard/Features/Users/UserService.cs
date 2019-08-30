
using FoodBoard.Models;
using Microsoft.AspNetCore.Identity;

namespace FoodBoard.Features.Users
{
    public interface IUserService
    {
        string PostUser(LoginUser user, string password);
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

        public string PostUser(LoginUser user, string password)
        {
            _userManager.CreateAsync(user, password);
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
