using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodBoard.Models
{
    public class FoodBoardContext : IdentityDbContext<User>
    {
        public FoodBoardContext(DbContextOptions<FoodBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }
        //public DbSet<User> FoodBoardUsers { get; set; }
        public DbSet<Groceries> Groceries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
        }
    }
}
