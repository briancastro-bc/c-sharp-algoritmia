using System;
using System.Collections.Generic;

namespace Algorithym
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            Arithmetic arithmetic = new Arithmetic();
            /*arithmetic.PrintWord(5, "Sena");
            List<int> nums = arithmetic.GenerateNaturalNums(5);
            nums.ForEach(delegate (int num)
            {
                Console.WriteLine(num);
            });
            arithmetic.PrintNumsSum(10);*/
            arithmetic.CalculateEvenSum(10);
            arithmetic.CalculateOddSum(21);
            arithmetic.Factorial(6);
        }
    }
}
