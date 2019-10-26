using AutoMapper;
using FoodBoard.Features.Offers.Representation;
using FoodBoard.Models;
using System;

namespace FoodBoard.Features.Offers
{
    public class OfferProfile : Profile
    {
        public OfferProfile()
        {
            CreateMap<OfferWriteViewModel, Offer>()
                .ForMember(offer => offer.ExpireDate, opt => opt.MapFrom(src => src.ExpirationDate))
                .ForMember(offer => offer.CreationDate, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<Offer, OfferReadViewModel>();
        }
    }
}
