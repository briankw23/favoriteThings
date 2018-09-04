using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    class Run
    {
        public void runInfo()
        {
            if (didYouRunQuestion())
            {
                Console.WriteLine("How many miles?");
                var milesRan = Console.ReadLine();
                Console.WriteLine("How many mintutes did you run?");
                var runDuration = Console.ReadLine();
                var paceResult = pace(Convert.ToInt32(milesRan), Convert.ToInt32(runDuration));
                Console.WriteLine($"Good Job, your pace was {paceResult} per mile");
            }  

            else
            {
                Console.WriteLine("Weak sauce");
            }
        }


        bool didYouRunQuestion()
        {
        Console.WriteLine("Did you run today? (y/n)");
        var runAnswer = Console.ReadLine();
            return runAnswer == "y";
        }

        public int pace (int distance, int timeRan)
        {
            return timeRan / distance;
        }
    }
}
