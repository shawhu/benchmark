using System;
using System.Collections.Generic;

namespace benchmark
{
    
    class Program
    {
        static int length = 10000000;
        static void Main(string[] args)
        {
            List<string> BigList = new List<string>();
            Console.WriteLine("Start the benchmark");
            Console.WriteLine($"Adding {length} string");
            DateTime start = DateTime.Now;
            //create a big list
            for (int i = 0; i < length; i++)
            {
                BigList.Add($"string{i}");
            }
            DateTime end = DateTime.Now;
            TimeSpan totaltime = end - start;

            Console.WriteLine($"{length} string added. Took {Math.Round(totaltime.TotalSeconds,3)} seconds");
        }
    }
}
