using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //
            //
            //showOutput("Kodluyoruz bootcamp çok iyi! :)");
            //int[] numbers = { 12, 9, 25, 36, 0, 22 };
            //int avarage = getAvarage(numbers.ToList());

            //showOutput($"Avarage : {avarage}");

            //primeNumbersOnValue(10000);


            //string[] value = IndexOf("bilgisayar", 'i');
            //foreach (var item in value)
            //{
            //    Console.WriteLine(item);
            //}


            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> small1 = new List<int> { 1, 2, 3 };
            List<int> number2 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> small2 = new List<int> { 6, 7, 8 };
            bool result1= isSubCollection(numbers1,small1 );
            bool result2 = isSubCollection(number2,small2 );

            Console.WriteLine(result1);
            Console.WriteLine(result2);




        }

        //static void showOutput(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //static int getAvarage(List<int> numbers)  //değer döndüğü için bu bir fonksiyondur.
        //{
        //    int total = 0;
        //    foreach (int number in numbers)
        //    {
        //        total += number;
        //    }
        //    return total/numbers.Count;
        //}

        //static bool isPrime(int number)
        //{
        //    bool isPrimeValue = true;

        //    for (int i = 2; i < number; i++)
        //    {
        //        if(number % i == 0)
        //        {
        //            isPrimeValue=false;
        //            break;
        //        }
        //    }

        //    return isPrimeValue;

        //}

        //static void primeNumbersOnValue(int value)
        //{
        //    for (int i = 0; i < value; i++)
        //    {
        //        if (isPrime(i))
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }
        //}

        static string[] IndexOf(string word, char letter)
        {
            string value = "";
            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] == letter)
                {
                    value+=index.ToString()+" ";
                }
            }

            string[] valueR=value.Split(" ");
            return valueR;
        }

        static bool isSubCollection(List<int> main, List<int> small)
        {
            /*
             * main: 2,4,6,8
             * small: 6,7,8
             */

            bool isSub = true;
            foreach (var num in small)
            {
                if (!main.Contains(num))
                {
                    isSub = false;
                    break;
                }
            }
            return isSub;
        }
    }
}
