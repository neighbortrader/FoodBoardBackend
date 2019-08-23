using FoodBoard.Features.Offers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FoodBoard.Controllers
{
    [Route("api/[controller]")]
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;

        public OfferController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        
        [HttpGet]
        public IActionResult GetAllOffers()
        {
            return Ok(_offerService.GetAllOffers());
        }
    }
}
