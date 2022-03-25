using System;
using System.Collections.Generic;

namespace BasicExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enter the number: 5
            //Expected Output:
            //5 * 0 = 0
            //5 * 1 = 5
            //5 * 2 = 10
            //5 * 3 = 15....5 * 10 = 50


            Console.WriteLine("Give me a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            //********************************************************************
            //Test Data:
            //Enter the First number: 10
            //Enter the Second number: 15
            //Enter the third number: 20
            //Enter the four number: 30

            //Expected Output:
            //The average of 10 , 15 , 20 , 30 is: 18


            Console.WriteLine("Give me a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("One more : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("One more.. : ");
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Last one, I promise : ");
            int number4 = int.Parse(Console.ReadLine());

            int[] numbers = new int[] { number, number2, number3, number4 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"Avarage is {sum / numbers.Length}");

            //*******************************************************************

            //Test Data:
            //w3resource
            //Sample Output:
            //wresource
            //w3resourc
            //3resource

            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));

            static string remove_char(string s, int n)
            {
                return s.Remove(n, 1);
            }


            //Test Data:
            //w3resource
            //Python
            //Sample Output:
            //e3resourcw
            //nythoP
            //x

            string first = "w3resource";
            string second = "Python";
            string x = "x";

            char[] first1 = first.ToCharArray();
            char[] second1 = second.ToCharArray();

            char temp = first1[0];
            first1[0] = first1[first1.Length - 1];
            first1[first1.Length - 1] = temp;

            char temp1 = second1[0];
            second1[0] = second1[second1.Length - 1];
            second1[second1.Length - 1] = temp1;

            Console.WriteLine(first1);
            Console.WriteLine(second1);
            Console.WriteLine(x);

            //Write a C# program to create a new string from a given string
            //(length 1 or more) with the first character added at the front and back

            Console.WriteLine("Input your sentence: ");
            string sentence = Console.ReadLine();

            string letter = sentence.Substring(0, 1);

            Console.WriteLine(letter + sentence + letter);

        }
    }
}
