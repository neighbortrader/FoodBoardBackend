using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodBoard.Models
{
    public class FoodBoardContext : IdentityDbContext<LoginUser>
    {
        public FoodBoardContext(DbContextOptions<FoodBoardContext> options)
            : base(options)
        {
        }

        public DbSet<Offer> Offers { get; set; }
        public DbSet<Grocerie> Groceries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Grocerie>().HasData(
                new Grocerie() { Id = 1, Name = "Milchprodukt"},
                new Grocerie() { Id = 2, Name = "Fisch/Fleisch" },
                new Grocerie() { Id = 3, Name = "Obst/Gemüse" },
                new Grocerie() { Id = 4, Name = "Getreideprodukte" },
                new Grocerie() { Id = 5, Name = "Getränke" },
                new Grocerie() { Id = 6, Name = "Süßes/Nachtisch" }
            );
        }
    }
}
