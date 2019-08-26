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
        
        public int ZIPNumber { get; set; }

        [StringLength(100)]
        public string Place { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        public int AddressNumber { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
