using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// hash function №0
    /// </summary>
    public class HashFunction0 : IHashFunction
    {
        /// <summary>
        /// hash-function
        /// </summary>
        /// <param name="workingString">value</param>
        /// <returns>key</returns>
        public int Function(string workingString)
        {
            int result = 0;
            for (int i = 0; i < workingString.Length; i++)
            {
                result = result + workingString[i] * i;
            }

            return result;
        }
    }
}