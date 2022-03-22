using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task-2
             * Program to list prime numbers between 1-1000000
            */
            
            int correct=0;
            int counter=0;
            for (int i=2; i<1000000; i++)
            {
                correct=0;
                for (int j=2; j<i/2; j++)
                {
                    if (i % j == 0)
                    {
                        correct++;
                        break;
                    }
                }
                if (correct == 0)
                {
                    counter++;
                    Console.Write(i+"-");
                }
               
            }
            Console.WriteLine();
            Console.WriteLine($"Bu sayı aralığında bulunan {counter} adet asal sayı yukarıda listelenmiştir.");
        }
    }
}
