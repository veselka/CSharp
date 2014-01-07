using System;

namespace NumbersNotDevidetBy3And7
{
    class NumbersNotDivBy3And7
    {
        static void Main()
        {/*02. Write a program that prints all the numbers from 1 to N, 
          *    that are not divisible by 3 and 7 at the same time.*/

            Console.WriteLine("Please enter a positive integer number n= ");
            string str=Console.ReadLine();
            long n;
            if (Int64.TryParse(str, out n) && (n > 0))
            {
                for (long i = 1; i <= n; i++)
                {
                    if ((i % 3 == 0) && (i % 7 == 0))
                        continue;
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("You have entered string, 0, or negative number '{0}'!", str);
            }
        }
    }
}
