using System.ComponentModel.DataAnnotations;

namespace FoodBoard.Models
{
    public class Groceries
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
