using System;

namespace FoodBoard.Features.Offers.Representation
{
    public class OfferReadViewModel
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreationDate { get; set; }
        public string UserId { get; set; }
        public int GrocerieId { get; set; }
    }
}
