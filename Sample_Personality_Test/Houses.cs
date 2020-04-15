using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Houses
    {
        public Houses()
        {
        }

        public Houses(string name, int points)
        {
            Name = name;
            Points = points;
        }

        public string Name { private set; get; }

        public int Points { set; get; }

        static Houses()
        {
            List<Houses> all = new List<Houses>
            {
                new Houses("Optimist", 0),
                new Houses("Pessimist",0),
                new Houses("Realist",0),
            };
            All = all;
        }
        public static IList<Houses> All { set; get; }
    }
}
