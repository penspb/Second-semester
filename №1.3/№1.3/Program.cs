using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    /// <summary>
    /// Project implementation. Including bubble sort and conversation with user
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Realization of bubble sort
        /// </summary>
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int variable = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = variable;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Good day! Please enter the size of array:");

            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Fine! Please enter the array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            BubbleSort(array);

            Console.WriteLine("After all:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
