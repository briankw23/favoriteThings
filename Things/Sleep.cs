using System;
using System.Collections.Generic;
using System.Text;

namespace favoriteThings.Things
{
    class Sleep
    {
        public void getSleepInfo()
        {
            Console.WriteLine("How many hours of sleep did you get last night?");
            var sleep = Console.ReadLine();
            if (Convert.ToInt32(sleep) >= 8)
            {
                Console.WriteLine("Great, you got a good night of rest!");
            } else
            {
                Console.WriteLine("Get to bed early, bruh. Not enough sleep");
            }
        }
    }
}
