using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodBoard.Models
{
    public class LoginUser : IdentityUser
    {
        [StringLength(50)]
        public string Nickname { get; set; }
        
        public int ZIPNumber { get; set; }

        [StringLength(100)]
        public string Place { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        public int AddressNumber { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
