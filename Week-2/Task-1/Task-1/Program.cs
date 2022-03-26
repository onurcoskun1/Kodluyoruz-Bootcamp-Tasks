using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "Ankara", "Ankara", "İstanbul", "İzmir", "Ankara", "İstanbul", "İstanbul", "Ankara" };

            List<string> cityList = cities.Distinct().ToList();

            foreach (string city in cityList)
            {
                Console.WriteLine(city);
            }
        }
    }
}
