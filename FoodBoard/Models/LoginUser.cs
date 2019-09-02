using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodBoard.Models
{
    public class LoginUser : IdentityUser
    {
        [StringLength(5)]
        public string ZIPNumber { get; set; }

        [StringLength(100)]
        public string Place { get; set; }

        [StringLength(100)]
        public string Street { get; set; }

        [StringLength(20)]
        public string AddressNumber { get; set; }

        public virtual ICollection<Offer> Offers { get; set; }
    }
}
