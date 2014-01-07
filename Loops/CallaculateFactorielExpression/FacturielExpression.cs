using System;
using System.Numerics;

namespace CallaculateFactorielExpression
{
    class FacturielExpression
    {
        static void Main()
        {// Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
       
            Console.Write("Please enter a positive integer number N = "); // without validation
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a positive integer number (1<N<K) K = "); // without validation
            int k = Int32.Parse(Console.ReadLine());      
            BigInteger factorielExp = 1;  // bigInteger ,because factoriel expression is groing very fast


            if (k > n && n>1)
            {
                for (int i = 1; i<= k; i++)
                {
                    if (i<= n)
                    { 
                        factorielExp *= i;
                    }
                    if(i>=(k-n+1))
                    {
                        factorielExp*=i;
                    }
                 }
                 Console.WriteLine("{0}!*{1}!/({1}-{0})! = {2}", n, k, factorielExp);
            }
            else
            {
                Console.WriteLine("You have entered invalid numbers! ");
            }
           
        }
    }
}   // N=6, K=9
    // N!=1*2*...*N  =  1*2*...*9
    // K!/(K-N)!= (1*2*...*K)/(K-N)!=(K-N+1)*(K-N+2)...*K  

    // 1*2*3*4*5*6*7*8*9     1*2*3*4*5*6*7*8*9
    // ------------------ = -------------------  = 4*5*6*7*8*9
    //     (9-6)!               1*2*3

    // 1*2*3...*N  * (K-N+1)*(K-N+2)*....*K