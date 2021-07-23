using System;
using System.Collections.Generic;

namespace Algorithym
{
    class Arithmetic
    {

        private List<int> numbersList;
        private int sum;

        public Arithmetic()
        {
            this.numbersList = new List<int>();
            this.sum = 0;
        }

        /**
         * Imprime N veces X palabara.
         */
        public void PrintWord(int N, string palabra)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Repitiendo {palabra}({i})");
            }
        }

        /**
         * Leer el valor de N e imprimir los primeros N números naturales.
         */
        public List<int> GenerateNaturalNums(int N)
        {
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine($"Número {i}");
                numbersList.Add(i);
            }
            return numbersList;
        }

        /**
         * Leer el valor de N, imprimir y sumar los números de 1 a N.
         */
        public void PrintNumsSum(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine($"Suma = {sum}");
        }

        /**
         * Calcular la suma de los primeros N números pares.
         */
        public void CalculateEvenSum(int N)
        {
            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                if (i % 2 == 0) sum += i;
                Console.WriteLine($"Número {i}");
            }
            Console.WriteLine($"Suma: {sum}");
        }

        /**
         * Imprimir la serie de los N primeros números impares y la suma de ellos.
         */
        public void CalculateOddSum(int N)
        {
            string serie = "";
            for (int i = 0; i <= N; i++)
            {
                if (i % 2 == 1)
                {
                    serie += $" {i} ";
                    sum += i;
                }
            }
            Console.WriteLine($"Serie: {serie}");
            Console.WriteLine($"Suma de los impares: {sum}");
        }

        /**
         * Para calcular el factorial de un número se deben multiplicar todos los números previos a él y el
         * mismo número, por ejemplo, el factorial de 6 es 1*2*3*4*5*6. Dado un número N calcular su 
         * factorial.
         */

        public void Factorial(int number)
        {
            int factorial = 1;
            string serie = "";
            for (int i = 1; i <= number; i++)
            {
                serie += $"{i} * ";
                factorial *= i;
            }
            Console.WriteLine($"Factorial {number}! = {serie} = {factorial}!");
        }

        /**
         * Generar e imprimir la serie y la suma los primero N números múltiplos de M.
         */
        public void GenerateMultiples(int N, int M)
        {
            string serie = "";
            for(int i = 0; i <= N; i++)
            {
                if(i % M == 0)
                {
                    serie += $" + {i}";
                    sum += i;
                }
            }
            Console.WriteLine($"Serie: {serie} = {sum}");
        }

        /**
         * Calcular e imprimir la suma de S definida por la siguiente serie.
         * S = 1 – 2 + 3 – 4 + 5 – 6 … + n
         */
        public void SumSeries(int N)
        {
            string serie = "";
            for(int i = 1; i <= N; i++)
            {
                serie += $" + {i}";
                sum += i;
            }
            Console.WriteLine($"S = {serie} = {sum}");
        }

        /**
         * Generar e imprimir las primeras N tablas de multiplicar, desde el 1 hasta el 9.
         */
        public void Multiply(int stop, int number)
        {
            for(int i = 1; i <= stop; i++)
            {
                Console.WriteLine($"{number} x {i} = {number*i}");
            }
        }

    }
}
