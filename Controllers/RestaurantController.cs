using ARobinsonMC5Eight2Ten_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC5Eight2Ten_EndPnt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantServices _restaurantServices;
        
        public RestaurantController(RestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        [HttpGet]
        [Route ("goRestaurant/{genre}")]
        public string goRestaurant(string genre)
        {
            return _restaurantServices.goRestaurant(genre);
        }
    }
}