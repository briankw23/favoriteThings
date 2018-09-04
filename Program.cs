using System;
using favoriteThings.Things;

namespace favoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = new Run();
            run.runInfo();
            var sleep = new Sleep();
            sleep.getSleepInfo();

            Console.ReadLine();
        }
    }
}
