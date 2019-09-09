using FoodBoard.Models;
using System.Linq;

namespace FoodBoard.Features.Groceries
{
    public interface IGrocerieService
    {
        Grocerie[] GetAllGroceries();
    }

    public class GrocerieService : IGrocerieService
    {
        private readonly FoodBoardContext _context;

        public GrocerieService(FoodBoardContext context)
        {
            _context = context;
        }

        public Grocerie[] GetAllGroceries()
        {
            return _context.Groceries.ToArray();
        }
    }
}
