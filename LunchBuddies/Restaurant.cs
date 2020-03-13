using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class Restaurant
    {
        public List<string> Restaurants = new List<string> { "Taco Bell", "Panera", "Olive Garden", "Buffalo Wild Wings" };
        public string Name { get; set; }

        public Restaurant()
        {
            var Random = new Random();
            int RestaurantIndex = Random.Next(Restaurants.Count);

            Name = Restaurants[RestaurantIndex];
        }
    }
}
