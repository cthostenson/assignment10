using System;
using System.Collections.Generic;

namespace Sample_Personality_Test
{
    public class Questions
    {
        // Instance members.
        private Questions()
        {
        }

        public Questions(string prompt, string left, string right, int affirmative, int negative)
        {
            Prompt = prompt;
            Left = left;
            Right = right;
            Affirmative = affirmative;
            Negative = negative; 
        }

        public string Prompt { private set; get; }

        public string Left { private set; get; }

        public string Right { private set; get; }

        public int Affirmative { private set; get; }

        public int Negative { private set; get; }

        // Static members.
        static Questions()
        {
            List<Questions> all = new List<Questions>
            {

                new Questions("Dogs or Cats?", "Dogs",
                              "Cats",0,1),
                new Questions("True or False?", "True",
                              "False",0,1),
                new Questions("Inside or Outside?", "Inside",
                              "Outside",1,2),
                new Questions("Fact or Fiction?", "Fact",
                              "Fiction",2,1),
                new Questions("Stand or Sit?", "Stand",
                              "Sit",2,1)
            };
            All = all;
        }
        
     public static IList<Questions> All { private set; get; }
    }

}
