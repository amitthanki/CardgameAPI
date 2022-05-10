using CardPlayGame.Interfaces;
using CardPlayGame.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CardPlayGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICard card;

        public CardsController(ICard _card)
        {
            card = _card;
        }
        [HttpPost]
        public IActionResult SortResult([FromBody] List<string> str)
        {
            try
            {
                var randomCards = card.GetSortedResult(str);
                return Ok(randomCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
