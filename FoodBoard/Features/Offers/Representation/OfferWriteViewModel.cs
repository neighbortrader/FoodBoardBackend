using System;

namespace FoodBoard.Features.Offers.Representation
{
    public class OfferWriteViewModel
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string UserId { get; set; }
        public int GrocerieId { get; set; }
    }
}
