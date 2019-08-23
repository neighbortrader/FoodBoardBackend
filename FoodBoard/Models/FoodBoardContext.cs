using Microsoft.EntityFrameworkCore;

namespace FoodBoard.Models
{
    public class FoodBoardContext : DbContext
    {
        public FoodBoardContext(DbContextOptions<FoodBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Groceries> Groceries { get; set; }
    }
}
