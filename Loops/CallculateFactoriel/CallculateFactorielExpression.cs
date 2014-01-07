using System;
using System.Numerics;

namespace CallculateFactoriel
{
    class CallculateFactorielExpression
    {
        static void Main()
        {// 04. Write a program that calculates N!/K! for given N and K (1<K<N).
            //int n, k;
            BigInteger expression=1;  //because function factoriel is groing very fast when n is much bigger than k
            Console.Write("Please enter a positive integer number n = "); // without validation
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a positive integer number (1<k<n) k = "); // without validation
            int k = Int32.Parse(Console.ReadLine());
 
            if (k < n)
            {
                for (int i = n; i > k; i--)
                {
                    expression *= i;
                }
                Console.WriteLine("{0}!/{1}! = {2}",n,k, expression);
            }
            else
            {
                Console.WriteLine("You have entered invalid numbers! N should be bigged than K!");
            }
        }
    }
}
