using AutoMapper;
using FoodBoard.Features.Users.Representation;
using FoodBoard.Models;

namespace FoodBoard.Features.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserWriteViewModel, LoginUser>();
        }
    }
}
