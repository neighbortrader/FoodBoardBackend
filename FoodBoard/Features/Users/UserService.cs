
using FoodBoard.Models;

namespace FoodBoard.Features.Users
{
    public interface IUserService
    {
        string PostUser(User user);
    }

    public class UserService : IUserService
    {
        private readonly FoodBoardContext _context;

        public UserService(FoodBoardContext context)
        {
            _context = context;
        }

        public string PostUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
