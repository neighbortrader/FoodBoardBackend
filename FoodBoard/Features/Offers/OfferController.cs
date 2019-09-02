using AutoMapper;
using FoodBoard.Features.Offers;
using FoodBoard.Features.Offers.Representation;
using FoodBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodBoard.Controllers
{
    [Route("api/[controller]")]
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;
        private readonly IMapper _mapper;

        public OfferController(IOfferService offerService, IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetAllOffers()
        {
            return Ok(_offerService.GetAllOffers());
        }

        [HttpPost]
        public IActionResult CreateNewOffer([FromBody]OfferWriteViewModel offerWriteViewModel)
        {
            var offer = _mapper.Map<Offer>(offerWriteViewModel);
            var result = _offerService.PostOffer(offer);
            return Ok(result);
        }
    }
}
