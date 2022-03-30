using System;
using System.Linq;
using System.Collections.Generic;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * We need to create a structure that writes the repetitive city names in the list once.
             */

            List<string> cities = new List<string>() { "Ankara", "Ankara", "İstanbul", "İzmir", "Ankara", "İstanbul", "İstanbul", "Ankara" };

            List<string> cityList = cities.Distinct().ToList(); //With the new list we created with the Distinct method, we prevent the repetitive records in the first list from being written to the screen.

            foreach (string city in cityList)  //We write the city names in the list with foreach on the screen.
            {
                Console.WriteLine(city);  
            }
        }
    }
}
