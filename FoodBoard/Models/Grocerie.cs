using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodBoard.Models
{
    public class Grocerie
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

    }
}
