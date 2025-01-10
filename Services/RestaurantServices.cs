namespace ARobinsonMC5Eight2Ten_EndPnt.Services
{
    public class RestaurantServices
    {
        public string goRestaurant(string genre)
        {
            Random rng = new Random();
            switch (genre.ToLower())
            {
                case "italian":
                    string[] italianRestaurants = { "Pete's", "Olive Garden", "Spaghetti Factory", "Brick House", "Roma's", "Lamppost Pizza", "BJ's", "Giovanni's", "Tony Baloney's", "Pizza Guys" };
                    int randomRestaurant = rng.Next(italianRestaurants.Length);
                    return $"Let's eat at {italianRestaurants[randomRestaurant]} tonight!";

                case "mexican":
                    string[] mexicanRestaurants = { "Taco Bell", "Del Taco", "Cilantro's", "Super Taco", "El Forastero", "Fiestaa Mexicana", "Adalberto's", "Toro Bravo", "Carolina's Grill", "El Poblana" };
                    randomRestaurant = rng.Next(mexicanRestaurants.Length);
                    return $"Let's eat at {mexicanRestaurants[randomRestaurant]} tonight!";

                case "chinese":
                    string[] chineseRestaurants = { "Happy Garden", "Panda Express", "Far East", "Sun's Garden", "Saigon Bowl Noodle House", "The Chopstick", "Frank Fat's", "China Wok Express", "New Yen Ching", "Dave Wong's Deli" };
                    randomRestaurant = rng.Next(chineseRestaurants.Length);
                    return $"Let's eat at {chineseRestaurants[randomRestaurant]} tonight! ";

                default:
                    return "INVALID INPUT. Valid genres are italian, chinese, or mexican.";
            }
        }
    }
}