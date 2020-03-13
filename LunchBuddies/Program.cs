using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<LunchBuddy> companions = new List<LunchBuddy> { };

            var buddy1 = new LunchBuddy("Alex", "Marble");
            var buddy2 = new LunchBuddy("Laura", "Collins");
            var buddy3 = new LunchBuddy("Bryan", "Tidwell");
            var buddy4 = new LunchBuddy("Orion", "Marble");

            companions.Add(buddy2);
            companions.Add(buddy3);

            buddy1.Eat("pizza", companions);

            buddy2.Eat("yakitori");

            buddy3.Eat();

            companions.Add(buddy1);
            companions.Remove(buddy3);

            buddy4.Eat(companions);

            Console.ReadKey();
        }
    }
}
