using AutoMapper;
using FoodBoard.Features.Offers.Representation;
using FoodBoard.Models;

namespace FoodBoard.Features.Offers
{
    public class OfferProfile : Profile
    {
        public OfferProfile()
        {
            CreateMap<OfferWriteViewModel, Offer>();
        }
    }
}
