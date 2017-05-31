using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    /// <summary>
    /// class Operand
    /// </summary>
    internal class Operand : KnotOfTree
    {
        /// <summary>
        /// value
        /// </summary>
        private int value;

        /// <summary>
        /// constructor 
        /// </summary>
        /// <param name="value">value</param>
        public Operand(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// function: count the result
        /// </summary>
        /// <returns>result</returns>
        public override int Count() => value;

        /// <summary>
        /// function: print operand
        /// </summary>
        /// <returns></returns>
        public override string Print() => value.ToString();
    }
}
