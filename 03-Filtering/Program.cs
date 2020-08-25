using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Filtering
{
    class Program
    {
        static Data data = new Data();

        static void Main()
        {
            DemoSimpleFilter();
            DemoMethodFilter();
            DemoAndFilter();
            DemoOrFilter();
        }

        static void DemoSimpleFilter()
        {
            Console.WriteLine("Simple Equality:");

            IEnumerable<Gamer> gamers =
                from gamer in data.Gamers
                where gamer.ID == 2
                select gamer;

            foreach (var gamer in gamers)
                Console.WriteLine($"ID: {gamer.ID}  Name: {gamer.Name}");
        }

        static void DemoMethodFilter()
        {
            Console.WriteLine("\nInvoking a Method:");

            IEnumerable<Gamer> gamers =
                from gamer in data.Gamers
                where gamer.Name.Contains("Jones")
                select gamer;

            foreach (var gamer in gamers)
                Console.WriteLine($"ID: {gamer.ID}  Name: {gamer.Name}");
        }

        static void DemoAndFilter()
        {
            Console.WriteLine("\nAND Condition:");

            IEnumerable<Gamer> gamers =
                from gamer in data.Gamers
                where gamer.Name.StartsWith("Xavier") && gamer.Name.EndsWith("Jones")
                select gamer;

            foreach (var gamer in gamers)
                Console.WriteLine($"ID: {gamer.ID}  Name: {gamer.Name}");
        }

        static void DemoOrFilter()
        {
            Console.WriteLine("\nOR Condition:");

            IEnumerable<Gamer> gamers =
                from gamer in data.Gamers
                where gamer.Name.EndsWith("Doe") || gamer.Name.EndsWith("Jones")
                select gamer;

            foreach (var gamer in gamers)
                Console.WriteLine($"ID: {gamer.ID}  Name: {gamer.Name}");
        }
    }
}
