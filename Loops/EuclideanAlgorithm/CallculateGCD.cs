using System;

namespace EuclideanAlgorithm
{
    class CallculateGCD
    {
        static void Main()
        {// 08. Write a program that calculates the greatest common divisor (GCD) of given two numbers.
         //     Use the Euclidean algorithm (find it in Internet).

            /*   Алгоритъм за намиране на най-голям общ делител по Евклид.
             *   1) За делимо се взима по-голямото число, а за делител - по-малкото число.
                 2) Делителя от предишната стъпка се разделя на получения остатък.
                 3) Това се повтаря дотогава, докато получим остатък 0. 
                    Този делител, при който частното няма остатък е НОД.*/

            Console.Write("Please enter a positive integer number n1 = "); // without validation
            int n1 = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter a positive integer number n2 = "); // without validation
            int n2 = Int32.Parse(Console.ReadLine());
            int remainder = 1;
            int tempNumber;

            if (n1>n2)
            {  
                tempNumber=n2; //exchange values so that n1<n2
                n2=n1;
                n1=tempNumber;
            }

               while (remainder !=0)
			    {
                    remainder = n2 % n1;
                    n2 = n1;
                    n1 = remainder;
			    }
               Console.WriteLine(" GCD is:{0} ",n2);
        }


    }
}
