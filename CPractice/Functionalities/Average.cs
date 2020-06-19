using System;
using System.Collections.Generic;
using System.Linq;

namespace CPractice
{
    public class AverageInRange
    {

        public static void Average(List<int> li, int min, int max)
        {
            var filtered = li.Where(value => (value >= min && value <= max));
            double answer = filtered.Average();
            Console.WriteLine(answer);
            Console.WriteLine("Average Done");
        }



    }
}
