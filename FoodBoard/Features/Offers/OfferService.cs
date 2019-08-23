using FoodBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodBoard.Features.Offers
{
    public interface IOfferService
    {
        Offer[] GetAllOffers();
    }

    public class OfferService : IOfferService
    {
        private readonly FoodBoardContext _context;

        public OfferService(FoodBoardContext context)
        {
            _context = context;
        }

        public Offer[] GetAllOffers()
        {
            return new[]
            {
                new Offer(),
                new Offer()
            };
        }
    }
}
