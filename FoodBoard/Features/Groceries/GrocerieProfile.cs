using AutoMapper;
using FoodBoard.Features.Groceries.Representation;
using FoodBoard.Models;

namespace FoodBoard.Features.Groceries
{
    public class GrocerieProfile : Profile
    {
        public GrocerieProfile()
        {
            CreateMap<Grocerie, GrocerieReadViewModel>();
        }
    }
}
