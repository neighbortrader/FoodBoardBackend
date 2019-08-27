
using FoodBoard.Models;

namespace FoodBoard.Features.Users
{
    public interface IUserService
    {
        int PostUser(User user);
    }

    public class UserService : IUserService
    {
        private readonly FoodBoardContext _context;

        public UserService(FoodBoardContext context)
        {
            _context = context;
        }

        public int PostUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
