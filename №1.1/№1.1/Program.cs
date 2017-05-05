using System;

namespace _1._1
{
    public class Program
    {
        /// <summary>
        /// Realization of factorial
        /// </summary>
        /// <returns>Factorial of number</returns>
        public static int Factorial(int number)
        {
            
            if (number < 0)
            {
                
                throw new PushException("Error. The number is negative");
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Good day! Please enter the number:");
            int newNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(newNumber));

        }

    }

}
