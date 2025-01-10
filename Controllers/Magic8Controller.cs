using ARobinsonMC5Eight2Ten_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC5Eight2Ten_EndPnt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Magic8Controller : ControllerBase
    {
        private readonly Magic8Services _magic8Services;

        public Magic8Controller(Magic8Services magic8Services)
        {
            _magic8Services = magic8Services;
        }

        [HttpGet]
        [Route("goMagic8/{question}")]
        public string goMagic8(string question)
        {
            return _magic8Services.goMagic8(question);
        }
    }
}