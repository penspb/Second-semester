using System;

namespace _1._5
{
    /// <summary>
    /// Project implementation. Including line sort and conversation with user
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Swap adjacent columns
        /// </summary>
        public static void SwapColumn(int[,] array, int numberOfFirstColumn)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int zero = array[i, numberOfFirstColumn];
                array[i, numberOfFirstColumn] = array[i, numberOfFirstColumn + 1];
                array[i, numberOfFirstColumn + 1] = zero;
            }
        }

        /// <summary>
        /// Probable sort
        /// </summary>s
        public static void LineSort(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1) - 1; i++)
            {
                for (int j = 0; j < array.GetLength(1) - 1 - i; j++)
                {
                    if (array[0, j + 1] < array[0, j])
                    {
                        SwapColumn(array, j);
                    }
                }
            }
        }

        /// <summary>
        /// Read array from consol
        /// </summary>
        static void ReadArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        /// <summary>
        /// Print result of sort
        /// </summary>
        /// <param name="array"></param>
        static void WriteArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Good day! Please enter the size of array: lines, columns");
            int line = 0;
            line = Convert.ToInt32(Console.ReadLine());
            int column = 0;
            column = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[line, column];

            Console.WriteLine("Fine! Please enter the array:");
            ReadArray(array);

            LineSort(array);

            Console.WriteLine("Result of sort:");
            WriteArray(array);
        }
    }
}
