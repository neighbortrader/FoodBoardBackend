using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodBoard.Models
{
    public class Offer
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime ExpireDate { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual LoginUser User { get; set; }

        [ForeignKey(nameof(Groceries))]
        public int? GrocerieId { get; set; }

        public virtual Grocerie Groceries { get; set; }
    }
}
