using CardPlayGame.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardPlayGame.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class DeckController : ControllerBase
    {
        private readonly ICard card;
        public DeckController(ICard _card)
        {
            card = _card;
        }
        [HttpGet]
        public IActionResult GetCards()
        {
            try
            {
                var randomCards = card.GetRandomCard();
                return Ok(randomCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
