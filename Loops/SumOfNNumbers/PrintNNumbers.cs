using System;

namespace PrintNumbers
{
    class PrintNNumbers
    {
        static void Main()
        {//01. Write a program that prints all  numbers from 1 to N.
            Console.WriteLine("Please enter a positive integer number n= ");
            string str=Console.ReadLine();
            long n;
            if (Int64.TryParse(str,out n)&&(n>0))
            {
                for (int i = 1; i <= n; i++)
                    if (true)
                {
			    Console.WriteLine(i);
			    }
            }
            else
            {
                Console.WriteLine("You have entered string, 0, or negative number '{0}'!",str);
            }
         }
      }
   }

