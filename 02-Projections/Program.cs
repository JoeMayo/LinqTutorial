using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02_Projections
{
    class Program
    {
        static Data data = new Data();

        static void Main(string[] args)
        {
            DemoAsIs();
            DemoNewType();
            DemoAnonymous();
            DemoMethod();
        }

        static void DemoAsIs()
        {
            Console.WriteLine("As-Is:");

            IEnumerable<Gamer> gamers =
                from gamer in data.Gamers
                select gamer;

            foreach (var gamer in gamers)
                Console.WriteLine($"ID: {gamer.ID}  Name: {gamer.Name}");
        }

        static void DemoNewType()
        {
            Console.WriteLine("\nNew Type:");

            IEnumerable<GamerLookup> lookups =
                from gamer in data.Gamers
                select new GamerLookup
                {
                    ID = gamer.ID,
                    Name = gamer.Name
                };

            foreach (var lookup in lookups)
                Console.WriteLine($"ID: {lookup.ID}  Name: {lookup.Name}");
        }

        static void DemoAnonymous()
        {
            Console.WriteLine("\nAnonymous:");

            var gamers =
                from gamer in data.Gamers
                select new
                {
                    ID = gamer.ID,
                    Name = gamer.Name
                };

            var highScores = new List<(string name, int score)>();

            foreach (var gamer in gamers)
            {
                foreach (var play in data.Scores)
                {
                    if (play.GamerID == gamer.ID)
                    {
                        highScores.Add((gamer.Name, play.Score));
                        break;
                    }
                }
            }

            foreach (var score in highScores)
                Console.WriteLine($"Name: {score.name}  Score: {score.score}");
        }

        static void DemoMethod()
        {
            Console.WriteLine("\nMethod:");

            IEnumerable<byte[]> avatars =
                from gamer in data.Gamers
                select GetAvatar(gamer.AvatarUrl);

            foreach (var avatar in avatars)
                Console.WriteLine($"First Byte: {avatar[0]}");
        }

        static byte[] GetAvatar(string url)
        {
            return new byte[] 
            { 
                (byte)new Random().Next(byte.MinValue, byte.MaxValue) 
            };
        }
    }
}
