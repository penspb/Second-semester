using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    /// <summary>
    /// Program with realization of spiral line of numbers and conversation with user
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Transformation from two-dimensional array to dimensional
        /// </summary>
        public static int[] SpiralLine(int[,] firstArray)
        {
            if (firstArray.GetLength(0) % 2 == 0)
            {
                throw new EvenNumberException("Error. The number " + firstArray.GetLength(0) +" is even");
            }

            int[] lastArray = new int[firstArray.GetLength(0) * firstArray.GetLength(0)];
            int ending = firstArray.GetLength(0) / 2 - 1;
            int iLast = 1;
            int squareSize = 3;

            lastArray[0] = firstArray[ending + 1, ending + 1];

            while (ending >= 0)
            {
                for (int j = ending + 1; j < ending + squareSize; j++)
                {
                    lastArray[iLast] = firstArray[ending, j];
                    iLast++;
                }

                for (int i = ending + 1; i < ending + squareSize; i++)
                {
                    lastArray[iLast] = firstArray[i, ending + squareSize - 1];
                    iLast++;
                }

                for (int j = ending + squareSize - 2; j >= ending; j--)
                {
                    lastArray[iLast] = firstArray[ending + squareSize - 1, j];
                    iLast++;
                }

                for (int i = ending + squareSize - 2; i >= ending; i--)
                {
                    lastArray[iLast] = firstArray[i, ending];
                    iLast++;
                }

                ending--;
                squareSize = squareSize + 2;
            }

            return lastArray;
        }

        /// <summary>
        /// Print the final array
        /// </summary>
        private static void Print(int[] lastArray)
        {
            for (int i = 0; i < lastArray.Length; i++)
            {
                Console.Write($"{lastArray[i]} ");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Good day! Please enter the positive number:");
            int number = int.Parse(Console.ReadLine());
            int[,] firstArray = new int[number, number];
            int[] lastArray = new int[number * number];

            Console.WriteLine("Fine! Please enter the array:");
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    firstArray[i, j] = int.Parse(Console.ReadLine());
                }
            }

            lastArray = SpiralLine(firstArray);
            Print(lastArray);
        }
    }
}
