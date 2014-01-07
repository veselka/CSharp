using System;

namespace MinMaxOfSequence
{
    class FindMinMaxOfSequance
    {
        static void Main()
        {/* 03.Write a program that reads from the console a sequence of N integer numbers 
          *    and returns the minimal and maximal of them.*/
                    
            Console.WriteLine("Please enter a number of integer numbers n= ");
            int n = Int32.Parse(Console.ReadLine());    // n - number of numbers in sequence
            decimal[] numbers = new decimal[n];               //declare array of n elements - type decimal, because user may enter a big number
            decimal minValue, maxValue;
            Console.WriteLine("Please entered sequence of n numbers one by one n{0} = ");
                    for (int i = 0; i < n; i++)     //enter n numbers of array
                    {
                    numbers[i] = Int64.Parse(Console.ReadLine());
                    }                    
                     minValue = numbers[0];         //to minValue assigned first element of array
                     maxValue = numbers[0];         //to maxValue assigned first element of array
                        for (int i = 0; i < n; i++)
			            {
		                    if (numbers[i] < minValue)
                            {
                                minValue = numbers[i];
                            }
                            if (numbers[i] > maxValue)
                            {
                                maxValue = numbers[i];
                            }
                    
                    } 
                Console.WriteLine("Min value = {0}. Max value = {1}.", minValue, maxValue);
          }
      }
 }

