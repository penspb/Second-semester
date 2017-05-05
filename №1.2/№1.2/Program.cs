using System;

namespace _1._2
{
    /// <summary>
    /// Program with realization of fibonacci and conversation with user
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Realization of fibonacci
        /// </summary>
        /// <returns>Fibonacci number</returns>
        public static int Fibonacci(int number)
        {
            if (number < 0)
            {
                throw new NegativeReferenceException("Error. The number is negative");
            }

            if ((number == 0) || (number == 1))
            {
                return 1;
            }

            return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Good day! Please enter the number:");
            int newNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(newNumber));
        }

    }
}
