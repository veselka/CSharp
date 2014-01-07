using System;

namespace CatalanNumbers
{
    class Program
    {
        static void Main()
        {/* In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
            ........

            Write a program to calculate the Nth Catalan number by given N. */

            //after optimizattion ((n+2)(n+3)...(n+n)/n!

            //int i = 0;
            long catalanNumber;
            long topExpession = 1;
            long nFacturiel = 1;
            Console.Write("Please enter a possitive integer number n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
			{
                nFacturiel *= i;
			}
            for (int i = 2; i <= n; i++)
            {
                topExpession *= (n + i);
            }
            
                catalanNumber = topExpession / nFacturiel;
                Console.WriteLine("N-th Catalan number is {0}",catalanNumber);
        }
    }
}
