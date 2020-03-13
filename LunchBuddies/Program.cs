using System;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurant = new Restaurant();

            Console.WriteLine(restaurant.Name);
            Console.ReadLine();
        }
    }
}
