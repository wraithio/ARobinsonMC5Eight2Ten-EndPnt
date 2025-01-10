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
        [Route("goGuessIt/{guessInt}/{difficulty}")]
        public string goGuessIt(int guessInt, string difficulty)
        {
            if(difficulty.ToLower() == "easy")
            {
                return _guessItServices.goGuessIt(guessInt, 1,10);
            }else if(difficulty.ToLower() == "medium")
            {
                return _guessItServices.goGuessIt(guessInt, 1,50);
            }else if(difficulty.ToLower() == "hard")
            {
                return _guessItServices.goGuessIt(guessInt, 1,100);
            }else
            {
                return "INVALID DIFFICULTY. Difficulty modes are 'easy', 'medium', or 'hard'.";
            }
        }
    }
}