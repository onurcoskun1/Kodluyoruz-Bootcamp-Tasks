using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task-3
             * Program that detects that the entered number is a prime number
             */
            
            try 
	        {	        
		        int number;
                int checking=0;
                Console.WriteLine("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                int i=2;

                while (i<number)
                {
                    if (number % i == 0)
                    {
                    checking++;
                    }

                    i++;
                }

                if (checking != 0)
                {
                Console.WriteLine("Number is NOT prime!");
                }
                else
                {
                Console.WriteLine("Number is PRIME");
                }
	        }
	        
            catch (FormatException)
	        {
                Console.WriteLine("Please just give digits");
	        }

            Console.ReadLine();

        }
    }
}
