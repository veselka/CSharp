using System;
using System.Numerics;

namespace SequenceOfFibonacci
{
    class SumFibonacci
    {
        static void Main()
        {// 07. Write a program that reads a number N and calculates the sum of the first N members 
         //     of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
         //     Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
 

            Console.Write("Please enter number N = ");
            int n = Int32.Parse(Console.ReadLine());

        // Извинете, ще реша задачата с long, не с BigInteger, защото ми хвърля някаква грешка, с която  
        // не успях да се спарвя. :-(

            long firstNumber = 0; 
            long secondNumber = 1;
            long tempNumber = 0;
            long sum = 0;

            if (n == 0 || n == 1)
            {
                Console.WriteLine("The sum of first {0} numbers of Fibonacci is 0.", n);
            }
            else
            {
                for (int counter = 2; counter < n; counter++)
                {

                    tempNumber = firstNumber+secondNumber;
                    sum = sum + tempNumber;
                    firstNumber = secondNumber;
                    secondNumber = tempNumber;
                   
                }
                Console.WriteLine("The sum of first {0} numbers of Fibonacci is {1}.", n, 1+sum);
            }
            
        }
    }
}
