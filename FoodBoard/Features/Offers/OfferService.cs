using FoodBoard.Models;
using System.Linq;

namespace FoodBoard.Features.Offers
{
    public interface IOfferService
    {
        Offer[] GetAllOffers();
        int PostOffer(Offer offer);
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
            return _context.Offers.ToArray();
        }

        public int PostOffer(Offer offer)
        {
            _context.Add(offer);
            _context.SaveChanges();
            return offer.Id;
        }
    }
}
