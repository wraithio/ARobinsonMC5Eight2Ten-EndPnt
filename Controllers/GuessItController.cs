using ARobinsonMC5Eight2Ten_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC5Eight2Ten_EndPnt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("EasygoGuessIt/{guessInt}")]
        public string goGuessIt(int guessInt)
        {
            return _guessItServices.EasygoGuessIt(guessInt);
        }

        [HttpGet]
        [Route("MediumgoGuessIt/{guessInt}")]
        public string MediumgoGuessIt(int guessInt)
        {
            return _guessItServices.EasygoGuessIt(guessInt);
        }

        [HttpGet]
        [Route("HardgoGuessIt/{guessInt}")]
        public string HardgoGuessIt(int guessInt)
        {
            return _guessItServices.EasygoGuessIt(guessInt);
        }
    }
}