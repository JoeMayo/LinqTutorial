using System;
using System.Linq;

namespace _01_IntroToLinq
{
    class Program
    {
        static void Main()
        {
            var gamers = new string[]
            {
                "Helen Jones",
                "John Smith",
                "Xavier Jones",
                "Jane Doe"
            };

            var names =
                from name in gamers
                where name.EndsWith("Jones")
                select name;

            Console.WriteLine("Names ending in \"Jones\":\n");

            foreach (var name in names)
                Console.WriteLine("  - " + name);

            //
            // you can also use the fluent API
            //

            var namesFluent =
                gamers
                    .Where(name => name.EndsWith("Jones"))
                    .Select(name => name);

            Console.WriteLine("\n\nNames ending in \"Jones\":\n");

            foreach (var name in namesFluent)
                Console.WriteLine("  - " + name);
        }
    }
}
