
using FoodBoard.Models;

namespace FoodBoard.Features.Users
{
    public interface IUserService
    {
        string PostUser(LoginUser user);
    }

    public class UserService : IUserService
    {
        private readonly FoodBoardContext _context;

        public UserService(FoodBoardContext context)
        {
            _context = context;
        }

        public string PostUser(LoginUser user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
