using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public LunchBuddy (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Will select a random restaurant name from a list of strings,
        /// print to console that the employee is at that restaurant,
        /// and also return the restaurant.
        /// </summary>
        /// <returns>restaurant name</returns>
        public string Eat()
        {
            var restaurant = new Restaurant();

            Console.WriteLine($"\n{FirstName} {LastName} is at {restaurant.Name}.");

            return restaurant.Name;
        }

        /// <summary>
        /// Will output that the employee ate the specific food at the office.
        /// </summary>
        /// <param name="food">something edible</param>
        public void Eat(string food)
        {
            Console.WriteLine($"\n{FirstName} {LastName} ate {food} at the office.");
        }

        /// <summary>
        /// Will select a random restaurant name from a list of strings,
        /// print to console that the employee is at that restaurant 
        /// and also output the first name of each lunch buddy in the specified list.
        /// </summary>
        /// <param name="companions">list of lunch buddiees</param>
        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"\n{FirstName} {LastName} is at {restaurant.Name} with...");

            foreach (var buddy in companions)
            {
                Console.WriteLine($"{buddy.FirstName} {buddy.LastName}");
            }
        }

        /// <summary>
        /// Will select a random restaurant name from a list of strings,
        /// print to console that the employee at that restaurant,
        /// and ordered the specified food, with the first name of the teammates specified in the list.
        /// </summary>
        /// <param name="food">something edible</param>
        /// <param name="companions">list of lunch buddies</param>
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"\n{FirstName} {LastName} is at {restaurant.Name} and ordered {food} to eat with...");

            foreach (var buddy in companions)
            {
                Console.WriteLine($"{buddy.FirstName} {buddy.LastName}");
            }
        }
    }
}
