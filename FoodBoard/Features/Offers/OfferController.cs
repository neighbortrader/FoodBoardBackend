using AutoMapper;
using FoodBoard.Features.Offers;
using FoodBoard.Features.Offers.Representation;
using FoodBoard.Features.Users;
using FoodBoard.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FoodBoard.Controllers
{
    [Route("api/[controller]")]
    public class OfferController : Controller
    {
        private readonly IOfferService _offerService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public OfferController(IOfferService offerService, IMapper mapper, IUserService userService)
        {
            _offerService = offerService;
            _userService = userService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public IActionResult GetAllOffers()
        {
            var offer = _offerService.GetAllOffers();
            var offerReadView = offer.Select(o => _mapper.Map<OfferReadViewModel>(o));
            return Ok(offerReadView);
        }

        [Authorize]
        [HttpPost]
        public IActionResult CreateNewOffer([FromBody]OfferWriteViewModel offerWriteViewModel)
        {
            var test = GetUserIdFromToken();
            var offer = _mapper.Map<Offer>(offerWriteViewModel);
            var result = _offerService.PostOffer(offer);
            return Ok(result);
        }

        private LoginUser GetUserIdFromToken()
        {
            var test = User.Claims;
            if (User.Claims.FirstOrDefault() == null) { return null; };
            var TokenOfUser = User.Claims.FirstOrDefault().Value;
            return _userService.GetUserById(TokenOfUser);
        }
    }
}
