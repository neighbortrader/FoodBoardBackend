using AutoMapper;
using FoodBoard.Features.Groceries.Representation;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FoodBoard.Features.Groceries
{
    [Route("api/[controller]")]
    public class GrocerieController : ControllerBase
    {
        private readonly IGrocerieService _grocerieService;
        private readonly IMapper _mapper;

        public GrocerieController(IGrocerieService grocerieService, IMapper mapper)
        {
            _grocerieService = grocerieService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllGrocieries()
        {
            var grocerie = _grocerieService.GetAllGroceries();
            var readViewModel = grocerie.Select(g => _mapper.Map<GrocerieReadViewModel>(g));
            return Ok(readViewModel);
        }
    }
}
