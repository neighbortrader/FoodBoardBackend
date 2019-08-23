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

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }

        public virtual User User { get; set; }

        [ForeignKey(nameof(Groceries))]
        public int? GrocerieId { get; set; }

        public virtual Groceries Groceries { get; set; }
    }
}
