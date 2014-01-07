using System;
using System.Numerics;

namespace CallculateSumExpression
{
    class CallcSumExpression
    {
        static void Main()
        {// 06. Write a program that, for a given two integer numbers N and X, 
         // calculates the sumS = 1 + 1!/X + 2!/X*X + … + N!/X*X*...N
  
            Console.Write("Please enter a positive integer number N = "); // without validation
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a positive integer number X = "); // without validation
            int x = Int32.Parse(Console.ReadLine());
            decimal sum = 1M;
            decimal facturielN=1L;
            decimal degreeOfX = 1L;

            for (int i = 1; i <= n; i++)
            {
             facturielN = facturielN * i;
             degreeOfX = degreeOfX * x;
            // expression = facturielN / degreeOfX;
            
             
             sum = sum + (facturielN/degreeOfX);
            }
            Console.WriteLine("Sum is {0}.",sum);
        }
    }
}
