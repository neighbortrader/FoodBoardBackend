using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodBoard.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nickname { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }

    }
}
