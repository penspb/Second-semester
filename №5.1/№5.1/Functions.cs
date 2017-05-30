using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    /// <summary>
    /// functions: Map, Filter, Fold
    /// </summary>
    public class Functions
    {
        /// <summary>
        /// function: change list
        /// </summary>
        /// <returns>new lists</returns>
        public static IList<int> Map(IList<int> list, Func<int, int> unaryFunction)
        {
            var newList = new List<int>(list.Count);

            foreach (var item in list)
            {
                newList.Add(unaryFunction(item));
            }

            return newList;
        }

        /// <summary>
        /// function: list to list with only "true" result
        /// </summary>
        /// <returns>new list</returns>
        public static IList<int> Filter(IList<int> list, Func<int, bool> unaryPredicate)
        {
            var newList = new List<int>();

            foreach (var item in list)
            {
                if (unaryPredicate(item))
                {
                    newList.Add(item);
                }
            }

            return newList;
        }

        /// <summary>
        /// function: accamulate values
        /// </summary>
        /// <returns>accamulated value</returns>
        public static int Fold(IList<int> list, int accumulator, Func<int, int, int> binaryFunction)
        {
            foreach (var item in list)
            {
                accumulator = binaryFunction(accumulator, item);
            }

            return accumulator;
        }
    }
}
