using System.Collections.Generic;

namespace _03_Filtering
{
    class Data
    {
        public List<Gamer> Gamers { get; set; } =
            new List<Gamer>
            {
                new Gamer { ID = 1, Name = "Helen Jones" },
                new Gamer { ID = 2, Name = "John Smith" },
                new Gamer { ID = 3, Name = "Xavier Jones" },
                new Gamer { ID = 4, Name = "Jane Doe" }
            };

        public List<Play> Scores { get; set; } =
            new List<Play>
            {
                new Play { GamerID = 1, Score=52 },
                new Play { GamerID = 2, Score=83 },
                new Play { GamerID = 3, Score=29 },
                new Play { GamerID = 4, Score=75 }
            };
    }
}
