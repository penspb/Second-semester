using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    /// <summary>
    /// interface of hash function
    /// </summary>
    public interface IHashFunction
    {
        /// <summary>
        /// get hash function
        /// </summary>
        /// <param name="word">value</param>
        /// <returns>key</returns>
        int Function(string word);
    }
}
