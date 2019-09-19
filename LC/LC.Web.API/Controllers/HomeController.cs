using System;
using AutoMapper;
using LC.Application.Service.Base;
using LC.Web.API.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LC.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IDeckService _deckService;
        private readonly IMapper _mapper;
        public HomeController(IDeckService deckService, IMapper mapper)
        {
            _deckService = deckService;
            _mapper = mapper;
        }
        
        [HttpGet("deck")]
        public IActionResult Get()
        {
            var deck = _deckService.GetDeck(Guid.Empty);
            var deckViewModel = _mapper.Map<DeckViewModel>(deck);
            return Ok(deckViewModel);
        }
    }
}